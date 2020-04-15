namespace ServiceStation
{
	partial class ChartForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.mainTotalPanel = new System.Windows.Forms.Panel();
            this.mainTotalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.volumeButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.timerSlowDisplay = new System.Windows.Forms.Timer(this.components);
            this.mainTotalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTotalChart)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTotalPanel
            // 
            resources.ApplyResources(this.mainTotalPanel, "mainTotalPanel");
            this.mainTotalPanel.Controls.Add(this.mainTotalChart);
            this.mainTotalPanel.Name = "mainTotalPanel";
            // 
            // mainTotalChart
            // 
            this.mainTotalChart.BackColor = System.Drawing.Color.Lavender;
            this.mainTotalChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            resources.ApplyResources(this.mainTotalChart, "mainTotalChart");
            this.mainTotalChart.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkHorizontal;
            this.mainTotalChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.mainTotalChart.BackSecondaryColor = System.Drawing.Color.Honeydew;
            this.mainTotalChart.BorderlineWidth = 0;
            this.mainTotalChart.BorderSkin.BackColor = System.Drawing.Color.Honeydew;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.Area3DStyle.Inclination = 45;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.PointDepth = 70;
            chartArea1.Area3DStyle.Rotation = 35;
            chartArea1.Area3DStyle.WallWidth = 5;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 8;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep90) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Angle = -90;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisX.LineColor = System.Drawing.Color.SlateBlue;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Interval = 0D;
            chartArea1.AxisX.MajorTickMark.IntervalOffset = 0D;
            chartArea1.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.SystemColors.WindowText;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisX.MaximumAutoSize = 100F;
            chartArea1.AxisX.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.SystemColors.WindowText;
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.Lavender;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Honeydew;
            chartArea1.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.SlateBlue;
            chartArea1.AxisX.ScrollBar.Size = 20D;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.SystemColors.WindowText;
            chartArea1.AxisX2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX2.LabelAutoFitMinFontSize = 8;
            chartArea1.AxisX2.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep90) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX2.LineColor = System.Drawing.SystemColors.WindowText;
            chartArea1.AxisX2.MaximumAutoSize = 100F;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelAutoFitMinFontSize = 8;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            chartArea1.AxisY.LineColor = System.Drawing.Color.YellowGreen;
            chartArea1.AxisY.MajorGrid.Interval = 0D;
            chartArea1.AxisY.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.SystemColors.WindowText;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorTickMark.Interval = 0D;
            chartArea1.AxisY.MajorTickMark.IntervalOffset = 0D;
            chartArea1.AxisY.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.SystemColors.WindowText;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisY.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Straight;
            chartArea1.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.ScaleBreakStyle.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.ScrollBar.BackColor = System.Drawing.Color.Lavender;
            chartArea1.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.Honeydew;
            chartArea1.AxisY.ScrollBar.IsPositionedInside = false;
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.YellowGreen;
            chartArea1.AxisY.ScrollBar.Size = 20D;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.SystemColors.WindowText;
            chartArea1.BackColor = System.Drawing.Color.Azure;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Lavender;
            chartArea1.BorderColor = System.Drawing.SystemColors.WindowText;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorX.LineColor = System.Drawing.Color.Maroon;
            chartArea1.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.CursorX.LineWidth = 2;
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.LightSkyBlue;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.CursorY.LineColor = System.Drawing.Color.Blue;
            chartArea1.CursorY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.CursorY.SelectionColor = System.Drawing.Color.PaleGoldenrod;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "mainChartArea";
            chartArea1.ShadowColor = System.Drawing.Color.Gray;
            chartArea1.ShadowOffset = 10;
            this.mainTotalChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.GhostWhite;
            legend1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkHorizontal;
            legend1.BorderColor = System.Drawing.Color.LightSkyBlue;
            legend1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            legend1.DockedToChartArea = "mainChartArea";
            legend1.Font = new System.Drawing.Font("Segoe UI", 8F);
            legend1.ForeColor = System.Drawing.SystemColors.WindowText;
            legend1.InterlacedRows = true;
            legend1.InterlacedRowsColor = System.Drawing.Color.AliceBlue;
            legend1.IsEquallySpacedItems = true;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.ShadowOffset = 7;
            legend1.TextWrapThreshold = 20;
            legend1.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTotalChart.Legends.Add(legend1);
            this.mainTotalChart.Name = "mainTotalChart";
            this.mainTotalChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "mainChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.CustomProperties = "EmptyPointValue=Zero, LabelStyle=Bottom";
            series1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.IsValueShownAsLabel = true;
            series1.LabelBorderWidth = 0;
            series1.LabelForeColor = System.Drawing.SystemColors.WindowText;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 0;
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.Gray;
            series1.ShadowOffset = 7;
            series1.SmartLabelStyle.CalloutLineColor = System.Drawing.SystemColors.WindowText;
            this.mainTotalChart.Series.Add(series1);
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.BorderWidth = 0;
            title1.DockingOffset = -3;
            title1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.SystemColors.WindowText;
            title1.IsDockedInsideChartArea = false;
            title1.Name = "mainTitle";
            title1.ShadowColor = System.Drawing.Color.Gray;
            title1.ShadowOffset = 7;
            title1.Text = "Total diagramm";
            title1.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            this.mainTotalChart.Titles.Add(title1);
            this.mainTotalChart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CloseKeyPress);
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.BackColor = System.Drawing.Color.Azure;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.saveButton.Image = global::ServiceStation.Properties.Resources.download;
            this.saveButton.Name = "saveButton";
            this.saveButton.UseCompatibleTextRendering = true;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton);
            this.saveButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CloseKeyPress);
            // 
            // closeButton
            // 
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.BackColor = System.Drawing.Color.Azure;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.closeButton.Image = global::ServiceStation.Properties.Resources.close;
            this.closeButton.Name = "closeButton";
            this.closeButton.Tag = "& Esc";
            this.closeButton.UseCompatibleTextRendering = true;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton);
            this.closeButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CloseKeyPress);
            // 
            // printButton
            // 
            resources.ApplyResources(this.printButton, "printButton");
            this.printButton.BackColor = System.Drawing.Color.Azure;
            this.printButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.printButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.printButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.printButton.Image = global::ServiceStation.Properties.Resources.print;
            this.printButton.Name = "printButton";
            this.printButton.UseCompatibleTextRendering = true;
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.PrintButton);
            this.printButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CloseKeyPress);
            // 
            // printDocument
            // 
            this.printDocument.DocumentName = "Total results document";
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintChartPage);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // bottomPanel
            // 
            resources.ApplyResources(this.bottomPanel, "bottomPanel");
            this.bottomPanel.Controls.Add(this.volumeButton);
            this.bottomPanel.Controls.Add(this.closeButton);
            this.bottomPanel.Controls.Add(this.saveButton);
            this.bottomPanel.Controls.Add(this.printButton);
            this.bottomPanel.Name = "bottomPanel";
            // 
            // volumeButton
            // 
            resources.ApplyResources(this.volumeButton, "volumeButton");
            this.volumeButton.BackColor = System.Drawing.Color.Azure;
            this.volumeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.volumeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.volumeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.volumeButton.Image = global::ServiceStation.Properties.Resources._3D_2;
            this.volumeButton.Name = "volumeButton";
            this.volumeButton.Tag = "0";
            this.volumeButton.UseCompatibleTextRendering = true;
            this.volumeButton.UseVisualStyleBackColor = false;
            this.volumeButton.Click += new System.EventHandler(this.VolumeButton);
            this.volumeButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CloseKeyPress);
            // 
            // saveFileDialog
            // 
            resources.ApplyResources(this.saveFileDialog, "saveFileDialog");
            this.saveFileDialog.InitialDirectory = "C:\\Users\\Public\\Documents";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog);
            // 
            // timerSlowDisplay
            // 
            this.timerSlowDisplay.Interval = 1;
            this.timerSlowDisplay.Tick += new System.EventHandler(this.SlowlyFormShow);
            // 
            // ChartForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.mainTotalPanel);
            this.Controls.Add(this.bottomPanel);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "ChartForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.TotalFormLoad);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CloseKeyPress);
            this.mainTotalPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainTotalChart)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel mainTotalPanel;
		private System.Windows.Forms.DataVisualization.Charting.Chart mainTotalChart;
		private System.Windows.Forms.Button printButton;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.PrintDialog printDialog;
		private System.Drawing.Printing.PrintDocument printDocument;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Button volumeButton;
		private System.Windows.Forms.Timer timerSlowDisplay;
	}
}