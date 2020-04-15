#region Namespaces and lib

using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

#endregion

namespace ServiceStation
{
	/// <summary>
	/// Log in form window
	/// </summary>
	public partial class AuthorizationForm : Form
	{
		#region Variables

		System.Data.DataRowCollection dataRow;
		private static int bgWidth;
		private static int moveX;
		private static int moveImgWidth;

		#endregion

		/// <summary>
		/// Initialization authorization form window components
		/// </summary>
		public AuthorizationForm()
		{
			InitializeComponent();
		}

		private void AuthorizationFormLoad(object sender, EventArgs e)
		{
			// Slow form display
			timerSlowDisplay.Start();

			//*#1541

			//dataAdapter.Fill(serviceStationDS.DATA);
			dataAdapterNew.Fill(dbssDS.DATA);

			// Mbar movement
			//dataRow = serviceStationDS.DATA.Rows;
			dataRow = dbssDS.DATA.Rows;
			bgWidth = backgroundImg.Width;
			moveImgWidth = moveImg.Width;
			moveX = -moveImgWidth;

			// When form show, u can enter the login now
			loginBox.Select();
		}

		/// <summary>
		/// Leave application
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtExit(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// Password visible flag
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PassVisible(object sender, EventArgs e)
		{
			if (passBox.UseSystemPasswordChar.Equals(true))
			{
				passBox.UseSystemPasswordChar = false;
			}
			else
			{
				passBox.UseSystemPasswordChar = true;
			}
		}

		#region Synchronization

		private string SyncAction(string str)
		{
			str = "1t$_Am@31ng" + str + "y0UrL0g1№";
			byte[] inputBytes = Encoding.Unicode.GetBytes(str);
			byte[] hashedBytes = new SHA256CryptoServiceProvider().ComputeHash(inputBytes);

			str = string.Empty;

			foreach (byte b in hashedBytes)
				str += b.ToString("x2").ToUpper();

			return str;
		}

		private void LoginAction(object sender, EventArgs e)
		{
			if (loginBox.Text.Equals(string.Empty)
				|| passBox.Text.Equals(string.Empty))
			{
				_ = MessageBox.Show(
					"Fill in all the fields",
					"Attention!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning,
					MessageBoxDefaultButton.Button1,
					MessageBoxOptions.ServiceNotification);
				return;
			}

			string log = loginBox.Text;
			string pswd = SyncAction(passBox.Text);

			foreach (System.Data.DataRow v in dataRow)
			{
				if (v["Login"].Equals(log)
						&& v["Password"].Equals(pswd))
				{
					DBSS.staffID = short.Parse(v["MasterID"].ToString());
					ActiveForm.Close();
					return;
				}
			}

			invalidPassLog.Visible = true;
		}

		#endregion

		// MBar move actions by timer
		private void MoveTimerTick(object sender, EventArgs e)
		{
			if (moveX >= bgWidth) moveX = (int)(-moveImgWidth * 1.9);
			moveImg.Location = new Point(moveX, 0);
			moveX += 3;
		}

		// Slow form display by timer
		private void SlowlyShowForm(object sender, EventArgs e)
		{
			if ((Opacity += 0.01D) == 1) timerSlowDisplay.Stop();
		}

		//private void FillToolStripButton_Click(object sender, EventArgs e)
		//{
		//	try
		//	{
		//		dataAdapterNew.Fill(dbssDS.DATA);
		//	}
		//	catch (System.Exception ex)
		//	{
		//		System.Windows.Forms.MessageBox.Show(ex.Message);
		//	}

		//}

		//private void FillToolStripButton_Click_1(object sender, EventArgs e)
		//{
		//	try
		//	{
		//		dataAdapterNew.Fill(dbssDS.DATA);
		//	}
		//	catch (System.Exception ex)
		//	{
		//		System.Windows.Forms.MessageBox.Show(ex.Message);
		//	}

		//}
	}
}