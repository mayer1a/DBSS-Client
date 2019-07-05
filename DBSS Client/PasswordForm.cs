#region Namespaces and lib

using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

#endregion

namespace ServiceStation
{
	/// <summary>
	/// Re-request password for access
	/// </summary>
	public partial class PasswordForm : Form
	{
		public static bool access;
		/// <summary>
		/// Constructor for all components in this form
		/// </summary>
		public PasswordForm()
		{
			InitializeComponent();
			access = false;
		}

		/// <summary>
		/// Password visible flag
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PasswordVisible(object sender, EventArgs e)
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

		/// <summary>
		/// Verify your identity and continue
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SubmitAction(object sender, EventArgs e)
		{
			if (passBox.Text.Equals(string.Empty))
			{
				_ = MessageBox.Show(
					"Fill in the field",
					"Attention!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning,
					MessageBoxDefaultButton.Button1,
					MessageBoxOptions.ServiceNotification);
				return;
			}

			System.Data.DataRowCollection dataRow;
			dataRow = serviceStationDS.DATA.Rows;
			string str = $"1t$_Am@31ng{passBox.Text}y0UrL0g1№";
			

			byte[] inputBytes = Encoding.Unicode.GetBytes(str);
			byte[] hashedBytes = new SHA256CryptoServiceProvider().ComputeHash(inputBytes);

			str = string.Empty;
			foreach (byte b in hashedBytes) str += b.ToString("x2").ToUpper();

			foreach (System.Data.DataRow v in dataRow)
			{
				if (v["Password"].Equals(str))
				{
					access = true;
					return;
				}
			}

			_ = MessageBox.Show(
				"Incorrect password! Access is denied..",
				"Wrong!",
				MessageBoxButtons.OK,
				MessageBoxIcon.Stop,
				MessageBoxDefaultButton.Button1,
				MessageBoxOptions.ServiceNotification);
		}

		/// <summary>
		///	Cancel access attempt
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CancelAction(object sender, EventArgs e)
		{
			Close();
		}
	}
}
