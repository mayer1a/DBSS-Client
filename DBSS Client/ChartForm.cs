#region Namespaces and lib

using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

#endregion

namespace ServiceStation
{
	/// <summary>
	/// Results form and multifunctional chart
	/// </summary>
	public partial class ChartForm : Form
	{
		#region Variables

		private static SqlDataReader dataReader;
		private Random rnd;
		private static Bitmap bm;
		private static PictureBox pb;
		private static string xAxis, title;

		#endregion

		/// <summary>
		/// Initialization of form components
		/// </summary>
		public ChartForm(SqlDataReader dataReader, string xAxis, string title)
		{
			InitializeComponent();

			#region Initialize other component for chart

			ChartForm.dataReader = dataReader;
			ChartForm.xAxis = xAxis;
			ChartForm.title = title;
			pb = new PictureBox();

			#endregion
		}

		/// <summary>
		/// Form loading and chart customization
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TotalFormLoad(object sender, EventArgs e)
		{
			#region Customize chart and editing to print

			rnd = new Random(DateTime.Now.Millisecond);

			mainTotalChart.Series.Clear();
			mainTotalChart.Titles["mainTitle"].Text = title;
			mainTotalChart.DataBindTable(dataReader, xAxis);
			mainTotalChart.Series[0].BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			mainTotalChart.Series[0].BackSecondaryColor = Color.FromArgb(rnd.Next(120, 240), rnd.Next(120, 240), rnd.Next(120, 240));
			mainTotalChart.Series[0].Color = Color.FromArgb(rnd.Next(120, 240), rnd.Next(120, 240), rnd.Next(120, 240));
			mainTotalChart.Series[0].CustomProperties = "EmptyPointValue=Zero, LabelStyle=Bottom";
			mainTotalChart.Series[0].Font = new Font("Segoe UI", (float)9.75, FontStyle.Bold);
			mainTotalChart.Series[0].IsValueShownAsLabel = true;
			mainTotalChart.Series[0].LabelForeColor = Color.FromKnownColor(KnownColor.WindowText);
			mainTotalChart.Series[0].ShadowColor = Color.Gray;
			mainTotalChart.Series[0].ShadowOffset = 7;
			mainTotalChart.ChartAreas[0].AxisY.Title = "Y axis: " + mainTotalChart.Series[0].Name;
			mainTotalChart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", (float)9.75);
			mainTotalChart.ChartAreas[0].AxisX.MaximumAutoSize = 100F;
			mainTotalChart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;


			if (xAxis.Equals(string.Empty))
			{
				mainTotalChart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
			}
			else
			{
				mainTotalChart.ChartAreas[0].AxisX.Title = "X axis: " + xAxis;
			}

			

			bm = new Bitmap(mainTotalPanel.Width, mainTotalPanel.Height);

			#endregion

			dataReader.Close();

			timerSlowDisplay.Start();
		}

		/// <summary>
		/// Just a close button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CloseButton(object sender, EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// Initialize par-s for ptinting
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PrintChartPage(object sender, PrintPageEventArgs e)
		{
			mainTotalPanel.DrawToBitmap(bm, new Rectangle(Point.Empty, bm.Size));

			#region Resolution/size scailing

			int pbWidth = e.MarginBounds.Width;
			int pbHeight = e.MarginBounds.Height;
			int ImageWidth = bm.Width;
			int ImageHeight = bm.Height;

			SizeF sizef = new SizeF(ImageWidth / bm.HorizontalResolution, ImageHeight / bm.VerticalResolution);
			float fSeale = Math.Min(pbWidth / sizef.Width, pbHeight / sizef.Height);
			sizef.Width *= fSeale;
			sizef.Height *= fSeale;
			Size size = Size.Ceiling(sizef);
			Rectangle rect = new Rectangle(Point.Empty, size);

			#endregion

			e.Graphics.DrawImage(bm, rect);
		}

		/// <summary>
		/// The folder selection dialog itself
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SaveFileDialog(object sender, CancelEventArgs e)
		{
			mainTotalPanel.DrawToBitmap(bm, new Rectangle(Point.Empty, bm.Size));
			pb.Image = bm;
		}

		/// <summary>
		/// Image save button and folder selector 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SaveButton(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog().Equals(DialogResult.OK))
			{
				switch (saveFileDialog.FilterIndex)
				{
					case 1:
						pb.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
						break;
					case 2:
						pb.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
						break;
					case 3:
						pb.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
						break;
					default:
						break;
				}
			}
		}

		/// <summary>
		/// Change display mode 3D/2D
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void VolumeButton(object sender, EventArgs e)
		{
			if (volumeButton.Tag.Equals("0"))
			{
				mainTotalChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
				mainTotalChart.ChartAreas[0].Area3DStyle.Enable3D = true;
				volumeButton.Tag = "1";
			}
			else
			{
				mainTotalChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
				mainTotalChart.ChartAreas[0].Area3DStyle.Enable3D = false;
				volumeButton.Tag = "0";
			}
		}

		/// <summary>
		/// PDF save button - sending document to file or print  
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PrintButton(object sender, EventArgs e)
		{
			if (printDialog.ShowDialog().Equals(DialogResult.OK))
			{
				printDocument.Print();
			}
		}
		
		/// <summary>
		/// Leave form after clicking on Esc
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CloseKeyPress(object sender, KeyEventArgs e)
		{
			if (e.KeyData.Equals(Keys.Escape)) Close();
		}

		/// <summary>
		/// Slow form display
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SlowlyFormShow(object sender, EventArgs e)
		{
			if ((Opacity += 0.05D) == 1) timerSlowDisplay.Stop();
		}
	}
}