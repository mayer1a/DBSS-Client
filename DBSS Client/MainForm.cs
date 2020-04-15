#region Namespaces and lib

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

#endregion

namespace ServiceStation
{
    /// <summary>
    /// Main application window
    /// </summary>
    public partial class MainForm : Form
    {
        #region Variables

        private Bitmap bmp;
        private PictureBox pb;
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        protected SqlDataReader sqlDataReader;
        private Excel.Application app;
        private Excel.Workbook workbook;
        private Excel.Worksheet worksheet;
        private List<Panel> PanelList { get; set; }
        private List<BindingSource> SourceList { get; set; }
        private short BeActive { get; set; }
        private string sqlExpression;
        private double timespan;

        #endregion


        /// <summary>
        /// Constructor of all components in the form
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            BeActive = 0;
        }

        /// <summary>
        /// Main from loader
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFormLoader(object sender, EventArgs e)
        {

            timerSlowDisplay.Start();

            #region Adapter filling

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbssDS.Applications". При необходимости она может быть перемещена или удалена.
            applicationsTableAdapter.Fill(dbssDS.Applications);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbssDS.Masters". При необходимости она может быть перемещена или удалена.
            mastersTableAdapter.Fill(dbssDS.Masters);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbssDS.Services". При необходимости она может быть перемещена или удалена.
            servicesTableAdapter.Fill(dbssDS.Services);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbssDS.Manufacturers". При необходимости она может быть перемещена или удалена.
            manufacturersTableAdapter.Fill(dbssDS.Manufacturers);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbssDS.DATA". При необходимости она может быть перемещена или удалена.
            dataTableAdapter.Fill(dbssDS.DATA);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbssDS.CarOwners". При необходимости она может быть перемещена или удалена.
            carOwnersTableAdapter.Fill(dbssDS.CarOwners);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbssDS.Cars". При необходимости она может быть перемещена или удалена.
            carsTableAdapter.Fill(dbssDS.Cars);

            #endregion

            // TODO: create a connection
            sqlConnect = new SqlConnection(Properties.Settings.Default.ConnectionString);

            // TODO: create a command
            sqlCommand = new SqlCommand
            {
                Connection = sqlConnect
            };

            pb = new PictureBox();

            timespan = DateTime.Now.Millisecond;

            #region Create list of tables source & list of panels

            PanelList = Controls.OfType<Panel>().ToList();
            PanelList.Reverse();

            SourceList = new List<BindingSource>(7)
            {
                carsBindingSource,
                carOwnersBindingSource,
                mastersBindingSource,
                manufacturersBindingSource,
                applicationsBindingSource,
                servicesBindingSource,
                dataBindingSource
            };

            List<MonthCalendar> mc = new List<MonthCalendar>(7)
            {
                applicationsCalendar,
                carOwnersCalendar,
                carsCalendar,
                dataCalendar,
                manufacturersCalendar,
                mastersCalendar,
                servicesCalendar
            };

            // Filling calendar
            for (int i = 0; i < mc.Count; i++)
            {
                for (int j = 0; j < mastersGrid.Rows.Count - 1; j++)
                {
                    mc[i].AddAnnuallyBoldedDate(
                        (DateTime)mastersGrid.Rows[j].Cells["mastersBirthColumn"].Value);
                }
            }
            mc.Clear();
            mc.TrimExcess();

            carsOpenItem.PerformClick();

            #endregion
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SlowlyFormShow(object sender, EventArgs e)
        {
            if ((Opacity += 0.05D) == 1) timerSlowDisplay.Stop();
        }

        #region Management of panel

        /// <summary>
        /// Enable/disable panel & menu binding to a specific panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelManage(object sender, EventArgs e)
        {
            // Access to "Data" -> Security
            if (((ToolStripMenuItem)sender).Tag.ToString().Equals("6")
                && (DateTime.Now.Millisecond - timespan) > Math.Pow(96.411410, 2.0))
            {
                if (new PasswordForm().ShowDialog().Equals(DialogResult.OK))
                {
                    if (!PasswordForm.access) return;
                }
            }

            BeActive = short.Parse(((ToolStripMenuItem)sender).Tag.ToString());

            #region Enable/Disable panel

            for (int i = 0; i < PanelList.Count; i++)
            {
                PanelList[i].Enabled = false;
                PanelList[i].Visible = false;
                PanelList[i].Hide();

                SourceList[i].RemoveFilter();
            }

            PanelList[BeActive].Enabled = true;
            PanelList[BeActive].Visible = true;
            PanelList[BeActive].Show();

            #endregion

            #region Choose source that will be displayed 

            switch (PanelList[BeActive].Tag.ToString())
            {
                case "Cars":
                    bindingNavigator.BindingSource = carsBindingSource;
                    break;
                case "CarOwners":
                    bindingNavigator.BindingSource = carOwnersBindingSource;
                    break;
                case "Applications":
                    bindingNavigator.BindingSource = applicationsBindingSource;
                    break;
                case "Masters":
                    bindingNavigator.BindingSource = mastersBindingSource;
                    break;
                case "Services":
                    bindingNavigator.BindingSource = servicesBindingSource;
                    break;
                case "Manufacturers":
                    bindingNavigator.BindingSource = manufacturersBindingSource;
                    break;
                case "Data":
                    bindingNavigator.BindingSource = dataBindingSource;
                    break;
                default:
                    break;
            }

            #endregion

            binNavMoveFirstItem.PerformClick();
        }

        #endregion


        #region Some action

        private void UpdateAction(object sender, EventArgs e)
        {
            #region Update selected table to default without saving changes

            switch (BeActive)
            {
                case 0:
                    carsBindingSource.RemoveFilter();
                    carsTableAdapter.Fill(dbssDS.Cars);
                    break;
                case 1:
                    carOwnersBindingSource.RemoveFilter();
                    carOwnersTableAdapter.Fill(dbssDS.CarOwners);
                    break;
                case 2:
                    applicationsBindingSource.RemoveFilter();
                    applicationsTableAdapter.Fill(dbssDS.Applications);
                    break;
                case 3:
                    mastersBindingSource.RemoveFilter();
                    mastersTableAdapter.Fill(dbssDS.Masters);
                    break;
                case 4:
                    servicesBindingSource.RemoveFilter();
                    servicesTableAdapter.Fill(dbssDS.Services);
                    break;
                case 5:
                    manufacturersBindingSource.RemoveFilter();
                    manufacturersTableAdapter.Fill(dbssDS.Manufacturers);
                    break;
                case 6:
                    dataBindingSource.RemoveFilter();
                    dataTableAdapter.Fill(dbssDS.DATA);
                    break;
                default:
                    break;
            }

            #endregion
        }

        private void SaveAction(object sender, EventArgs e)
        {
            Validate();
            carsBindingSource.EndEdit();
            carOwnersBindingSource.EndEdit();
            applicationsBindingSource.EndEdit();
            mastersBindingSource.EndEdit();
            servicesBindingSource.EndEdit();
            dataBindingSource.EndEdit();
            manufacturersBindingSource.EndEdit();
            adapterManager.UpdateAll(dbssDS);
        }

        private void ExitAction(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TimerAction(object sender, EventArgs e)
        {
            timeLabel.Text = "Time now: " +
                DateTime.Now.TimeOfDay.ToString().Substring(0, 8);
        }

        private void TablePrintAction(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog().Equals(DialogResult.OK))
            {
                printDocument.Print();
            }
        }

        private void DrawnCompSaveAction(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        pb.Image.Save(
                            saveFileDialog.FileName,
                            System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        pb.Image.Save(
                            saveFileDialog.FileName,
                            System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case 3:
                        pb.Image.Save(
                            saveFileDialog.FileName,
                            System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    default:
                        WindowState = FormWindowState.Maximized;
                        break;
                }
            }
        }

        private void ExporClickAction(object sender, EventArgs e)
        {
            switch (PanelList[BeActive].Tag.ToString())
            {
                case "Cars":
                    ExportToExcel(carsGrid);
                    break;
                case "CarOwners":
                    ExportToExcel(carOwnersGrid);
                    break;
                case "Data":
                    _ = MessageBox.Show(
                        "Export is not possible for the \"Data\" table",
                        "Attention!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop,
                        MessageBoxDefaultButton.Button1);
                    break;
                case "Services":
                    ExportToExcel(servicesGrid);
                    break;
                case "Masters":
                    ExportToExcel(mastersGrid);
                    break;
                case "Manufacturers":
                    ExportToExcel(manufacturersGrid);
                    break;
                case "Applications":
                    ExportToExcel(applicationsGrid);
                    break;
                default:
                    break;
            }
        }

        private void ExportToExcel(object sender)
        {
            #region Basis for export operation
            app = new Excel.Application
            {
                Visible = false,
                SheetsInNewWorkbook = 1,
                DisplayAlerts = false
            };

            app.WorkbookAfterSave += WorkbookAfterSave;

            ((DataGridView)sender).SelectAll();
            DataObject obj = ((DataGridView)sender).GetClipboardContent();
            ((DataGridView)sender).ClearSelection();

            if (obj.Equals(null))
            {
                _ = MessageBox.Show(
                    "Export table internal error",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, 0);

                throw new ArgumentNullException(nameof(obj));
            }
            else Clipboard.SetDataObject(obj, false, 1, 0);

            workbook = app.Workbooks.Add();
            worksheet = app.ActiveSheet;
            worksheet.PasteSpecial(
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                true);

            #endregion

            #region Personalization

            app.Goto("C1:C26");
            app.Selection.Columns.AutoFit();
            app.Selection.Rows.Autofit();
            //worksheet.Columns.EntireColumn.AutoFit();
            worksheet.Name = "Report table";
            worksheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;
            worksheet.PageSetup.PrintGridlines = true;
            worksheet.PageSetup.BlackAndWhite = true;
            worksheet.PageSetup.BottomMargin = 20.0;
            worksheet.PageSetup.LeftMargin = 20.0;
            worksheet.PageSetup.RightMargin = 20.0;
            worksheet.PageSetup.PaperSize = Excel.XlPaperSize.xlPaperA3;
            worksheet.PageSetup.TopMargin = 20.0;
            worksheet.Range["A1"].Select();
            worksheet.Rows[1].Font.Bold = true;


            #endregion

            #region Select save format

            if (exportFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                switch (exportFileDialog.FilterIndex)
                {
                    case 1:
                        workbook.SaveAs(exportFileDialog.FileName, app.DefaultSaveFormat);
                        break;
                    case 2:
                        workbook.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, exportFileDialog.FileName);
                        break;
                    case 3:
                        workbook.SaveAs(exportFileDialog.FileName, Excel.XlFileFormat.xlCSV);
                        break;
                    case 4:
                        workbook.SaveAs(exportFileDialog.FileName, Excel.XlFileFormat.xlCurrentPlatformText);
                        break;
                    case 5:
                        workbook.SaveAs(exportFileDialog.FileName, Excel.XlFileFormat.xlHtml);
                        break;
                    case 6:
                        workbook.SaveAs(exportFileDialog.FileName, Excel.XlFileFormat.xlOpenXMLStrictWorkbook);
                        break;
                    case 7:
                        workbook.SaveAs(exportFileDialog.FileName, Excel.XlFileFormat.xlXMLSpreadsheet);
                        break;
                    case 8:
                        workbook.SaveAs(exportFileDialog.FileName, Excel.XlFileFormat.xlOpenXMLWorkbook);
                        break;
                    default:
                        break;
                }
            }

            #endregion
        }

        /// <summary>
        /// Delete temporary export objects: mem. clean
        /// </summary>
        /// <param name="Wb"></param>
        /// <param name="Success"></param>
        private void WorkbookAfterSave(Excel.Workbook Wb, bool Success)
        {
            if (Success)
            {
                _ = MessageBox.Show(
                    "Export success!",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1, 0);
                app.Quit();
                worksheet.Delete();
                Wb.Close();
            }
        }

        private void SelectedMasterAction(object sender, EventArgs e)
        {
            parcButton.Enabled = true;
            revenueButton.Enabled = true;
        }

        private void LogoutAction(object sender, EventArgs e)
        {
            DBSS.reauthorize = true;
            ActiveForm.Close();
        }

        #endregion


        #region Form window state

        private void WindowStateMax(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void WindowStateMin(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void WindowStateNorm(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void WindowStateStretchH(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(
                width: Screen.PrimaryScreen.WorkingArea.Width,
                height: ClientSize.Height);
            Location = new System.Drawing.Point(-8, Location.Y);
        }

        private void WindowStateStretchV(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(
                width: Size.Width,
                height: (int)(Screen.PrimaryScreen.Bounds.Height * 0.94));
            Location = new System.Drawing.Point(Location.X, 0);
        }

        #endregion


        #region Show

        private void FindFormShow(object sender, EventArgs e)
        {
            using (FinderForm ff = new FinderForm(
                TableName: PanelList[BeActive].Tag.ToString()))
            {

                ff.ShowDialog();
                string query = FinderForm.ReturnQuery;

                #region Choose source which to filter

                if (!query.Equals(""))
                {
                    switch (PanelList[BeActive].Tag.ToString())
                    {
                        case "Cars":
                            carsBindingSource.Filter = query;
                            break;
                        case "CarOwners":
                            carOwnersBindingSource.Filter = query;
                            break;
                        case "Applications":
                            applicationsBindingSource.Filter = query;
                            break;
                        case "Services":
                            servicesBindingSource.Filter = query;
                            break;
                        case "Masterts":
                            mastersBindingSource.Filter = query;
                            break;
                        case "Data":
                            dataBindingSource.Filter = query;
                            break;
                        case "Manufacturers":
                            manufacturersBindingSource.Filter = query;
                            break;
                        default:
                            break;
                    }
                }

                #endregion
            }
        }

        private void ChartFormShow(string xAxis, string title)
        {
            using (sqlConnect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                sqlCommand.Connection = sqlConnect;
                sqlCommand.CommandText = sqlExpression;

                sqlConnect.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                new ChartForm(dataReader: sqlDataReader, xAxis, title).Show();
            }
        }

        private void SaveDialogShow(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CreateDrawingComp();
            pb.Image = bmp;
        }

        #endregion


        #region Reports

        private void ConditionCarsReport(object sender, EventArgs e)
        {
            sqlExpression = "SELECT COUNT(ID) AS [Count], " +
                "Condition FROM Cars GROUP BY Condition " +
                "ORDER BY Condition ASC";
            ChartFormShow(xAxis: "Condition",
                 title: "Vehicle condition");
        }

        private void TypeCarsReport(object sender, EventArgs e)
        {
            sqlExpression = "SELECT COUNT(ID) AS [Count], " +
                "Type FROM Cars GROUP BY Type ORDER BY Type ASC";
            ChartFormShow(xAxis: "Type", title: "Vehicle type");
        }

        private void SteerLocCarsReport(object sender, EventArgs e)
        {
            sqlExpression = "SELECT COUNT(ID) AS [Count], " +
                "SteeringLocation AS [Steering location] " +
                "FROM Cars GROUP BY SteeringLocation " +
                "ORDER BY SteeringLocation ASC";
            ChartFormShow(xAxis: "Steering location",
                 title: "Vehicle steering location");
        }

        private void AvgMileageCarsReport(object sender, EventArgs e)
        {
            sqlExpression = "SELECT AVG(Mileage) AS " +
                "[Average vehicle mileage] FROM Cars";
            ChartFormShow(xAxis: string.Empty,
                 title: "Average vehicle mileage");
        }

        private void CountRegMastersReport(object sender, EventArgs e)
        {
            sqlExpression = "SELECT COUNT(MasterID) " +
                "AS [Registered masters] FROM DATA";
            ChartFormShow(xAxis: string.Empty,
                 title: "Count of registered service station masters");
        }

        private void CountCarOwnersReport(object sender, EventArgs e)
        {
            sqlExpression = "SELECT COUNT(ID) " +
                "AS [All car owners] FROM [CarOwners]";
            ChartFormShow(xAxis: string.Empty,
                title: "Count of all car owners in the database");
        }

        private void CountYearAppReport(object sender, EventArgs e)
        {
            sqlExpression = "SELECT COUNT(ID) AS " +
                "[Count of applications by year], " +
                "YEAR([Date]) as [Year] FROM [Applications] " +
                "GROUP BY YEAR([Date]) ORDER BY YEAR([Date]) ASC";
            ChartFormShow(xAxis: "Year", title: "Applications by year");
        }

        private void TotalCostReport(object sender, EventArgs e)
        {
            sqlExpression = "SELECT YEAR(Applications.Date) AS Year, "
                   + "SUM(Services.Cost) AS[Total cost] FROM Applications "
                   + "INNER JOIN Services ON Applications.ServiceID = Services.ID "
                   + "GROUP BY YEAR(Applications.Date) ORDER BY Year";
            ChartFormShow(xAxis: "Year", title: "Total cost of services sold");
        }

        private void CountMasterAppReport(object sender, EventArgs e)
        {
            sqlExpression = "SELECT COUNT(Applications.MasterID) "
                   + "AS [Applications count], Masters.FullName "
                   + "AS [Master's name] FROM Applications "
                   + "INNER JOIN Masters ON Applications.MasterID "
                   + "= Masters.ID GROUP BY Masters.FullName";
            ChartFormShow(xAxis: "Master's name",
                title: "The number of application of each masters");
        }

        private void TotalCostThisYearReport(object sender, EventArgs e)
        {
            string _askYear = "";

            using (AskYearForm ff = new AskYearForm())
            {
                ff.ShowDialog();
                _askYear = AskYearForm.ReturnValue;
            }

            if (_askYear is null)
            {
                _ = MessageBox.Show(
                    "Invalid input!",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    0);
            }
            else
            {
                sqlExpression = $"SELECT FORMAT([Applications].[Date], 'MMMM') "
                    + $"AS [Month of this year], SUM([Services].[Cost]) "
                    + $"AS [Total sold by service] FROM Applications "
                    + $"INNER JOIN Services "
                    + $"ON [Applications].[ServiceID] = [Services].[ID] "
                    + $"WHERE (YEAR([Applications].[Date]) = { _askYear } ) "
                    + $"GROUP BY FORMAT(Applications.Date, 'MMMM') ";
                ChartFormShow(xAxis: "Month of this year",
                    title: $"Total monthly revenue on { _askYear } year");
            }
        }

        private void PARCReport(object sender, EventArgs e)
        {
            sqlExpression = $"EXEC [dbo].[crtView] "
                   + $"@masterID = { masterSelectBox.SelectedValue }";
            ChartFormShow(xAxis: "Sign of",
                 title: $"P.A.R.C. report by { masterSelectBox.Text }");
        }

        private void RevenueReport(object sender, EventArgs e)
        {
            string _askYear;

            using (AskYearForm ff = new AskYearForm())
            {
                if(ff.ShowDialog() == DialogResult.Cancel) return;

                _askYear = AskYearForm.ReturnValue;

                if ((new System.Text.RegularExpressions.Regex(@"[1|2][0-9]{3}")).IsMatch(_askYear))
                {
                    sqlExpression =
                        $"SELECT FORMAT([Date], 'MMMM') AS [Month], SUM([Cost]) AS [Revenue] " +
                        $"FROM Applications " +
                        $"INNER JOIN [Services] ON Applications.ServiceID = [Services].ID " +
                        $"WHERE YEAR([Date]) = { _askYear } " +
                        $"AND [MasterID] = { masterSelectBox.SelectedValue } " +
                        $"GROUP BY FORMAT([Applications].[Date], 'MMMM');";

                    ChartFormShow(xAxis: "Month",
                         title: $"Revenue report by { masterSelectBox.Text } at { _askYear }");
                }
                else
                {
                    _ = MessageBox.Show(
                        "Invalid input!",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        0);
                }
            }
        }

        private void RevenueAllYearReport(object sender, EventArgs e)
        {
            sqlExpression = $"SELECT FORMAT([Date], 'MMMM') AS [Month], "
                    + $"SUM([Cost]) AS [Revenue] FROM Applications "
                    + $"INNER JOIN [Services] ON Applications.ServiceID=[Services].ID "
                    + $"WHERE MasterID = { masterSelectBox.SelectedValue } "
                    + $"GROUP BY FORMAT([Applications].[Date], 'MMMM') "
                    + $"ORDER BY Month DESC";
            ChartFormShow(xAxis: "Month", title: $"Revenue report by "
                    + $"{ masterSelectBox.Text } for all year");
        }

        private void CountMastersEachQualReport(object sender, EventArgs e)
        {
            sqlExpression = "SELECT Qualification, "
                + "COUNT(ID) AS [Count of masters] "
                + "FROM Masters GROUP BY Qualification "
                + "ORDER BY Qualification";
            ChartFormShow(xAxis: "Qualification",
                title: "The number of masters of each qualification");
        }

        private void AgeEachMasterReport(object sender, EventArgs e)
        {
            sqlExpression = "SELECT FullName AS [Master], "
                + "FLOOR(CONVERT(INT, GETDATE()-CONVERT(DATETIME,Birth))/365.25) "
                + "AS Age FROM Masters ORDER BY Age DESC";
            ChartFormShow(xAxis: "Master",
                title: "The age of each master");
        }

        private void CountAllMastersReport(object sender, EventArgs e)
        {
            sqlExpression = "SELECT COUNT(ID) AS "
                + "[Count of masters] FROM Masters";
            ChartFormShow(xAxis: string.Empty,
                title: "The number of all masters");
        }

        private void AvgAgeOfMastersReport(object sender, EventArgs e)
        {
            sqlExpression = "SELECT FLOOR(AVG(CONVERT(INT, "
                + "GETDATE()-CONVERT(DATETIME,Birth))/365.25)) "
                + "AS [Average age] FROM Masters";
            ChartFormShow(xAxis: string.Empty,
                title: "The average age of master");
        }

        private void MaxMinServiceCostsReport(object sender, EventArgs e)
        {
            sqlExpression = "SELECT [Name] AS [Service name], "
                + "[Cost] AS [Service cost] FROM [Services] "
                + "WHERE Cost = (SELECT MAX(Cost) FROM [Services]) "
                + "OR Cost = (SELECT MIN(Cost) FROM [Services]) "
                + "ORDER BY Cost DESC";
            ChartFormShow(xAxis: "Service name",
                title: "The maximum and minimum cost of services");
        }

        private void AvgServicesCost(object sender, EventArgs e)
        {
            sqlExpression = "SELECT CONVERT(INT, "
                + "AVG(Cost)) AS [Average cost] "
                + "FROM [Services]";
            ChartFormShow(xAxis: string.Empty,
                title: "The average cost of services");
        }

        private void CountServicesComplexReport(object sender, EventArgs e)
        {
            sqlExpression = "SELECT COUNT(ID) AS [Count], "
                + "Complexity FROM [Services] GROUP BY Complexity";
            ChartFormShow(xAxis: "Complexity",
                title: "The number of services by complexity");
        }

        private void CountServicesDurationReport(object sender, EventArgs e)
        {
            sqlExpression = "SELECT COUNT(ID) AS [Count], "
                + "Duration AS [Duration (in days)] "
                + "FROM [Services] GROUP BY Duration";
            ChartFormShow(xAxis: "Duration (in days)",
                title: "The number of services by duration");
        }

        private void CountOfServices(object sender, EventArgs e)
        {
            sqlExpression = "SELECT "
                + "COUNT(ID) AS [Count of all services] "
                + "FROM [Services]";
            ChartFormShow(xAxis: string.Empty,
                title: "The number of all services");
        }

        private void CountOfModelsReport(object sender, EventArgs e)
        {
            sqlExpression = "SELECT COUNT(ID) AS "
                + "[Count of all models] FROM Manufacturers";
            ChartFormShow(xAxis: string.Empty,
                title: "The number of all models");
        }

        private void AvgLoginLenghtReport(object sender, EventArgs e)
        {
            sqlExpression = "SELECT AVG(LEN([Login])) "
                + "AS [Average length]FROM [DATA]";
            ChartFormShow(xAxis: string.Empty,
                title: "The average length of login");
        }

        private void CountDistinctColorReport(object sender, EventArgs e)
        {
            sqlExpression = "SELECT COUNT(DISTINCT Color) "
                + "AS [Count of different colors] FROM Cars";
            ChartFormShow(xAxis: string.Empty,
                title: "The number of different colors of cars");
        }



        #endregion


        #region Drawing

        private void CreateDrawingComp()
        {
            switch (PanelList[BeActive].Tag.ToString())
            {
                case "Cars":
                    bmp = new Bitmap(
                        width: Bounds.Width,
                        height: Bounds.Height);

                    DrawToBitmap(
                        bmp,
                        new Rectangle(DisplayRectangle.Location, Bounds.Size));
                    break;
                case "CarOwners":
                    bmp = new Bitmap(
                        width: Bounds.Width,
                        height: Bounds.Height);

                    carOwnersGrid.DrawToBitmap(
                        bmp,
                        new Rectangle(DisplayRectangle.Location, Bounds.Size));
                    break;
                case "Applications":
                    bmp = new Bitmap(
                        width: Bounds.Width,
                        height: Bounds.Height);

                    applicationsGrid.DrawToBitmap(
                        bmp,
                        new Rectangle(DisplayRectangle.Location, Bounds.Size));
                    break;
                case "Services":
                    bmp = new Bitmap(
                        width: Bounds.Width,
                        height: Bounds.Height);

                    servicesGrid.DrawToBitmap(
                        bmp,
                        new Rectangle(DisplayRectangle.Location, Bounds.Size));
                    break;
                case "Masterts":
                    bmp = new Bitmap(
                        width: Bounds.Width,
                        height: Bounds.Height);

                    mastersGrid.DrawToBitmap(
                        bmp,
                        new Rectangle(DisplayRectangle.Location, Bounds.Size));
                    break;
                case "Data":
                    bmp = new Bitmap(
                        width: Bounds.Width,
                        height: Bounds.Height);

                    dataGrid.DrawToBitmap(
                        bmp,
                        new Rectangle(DisplayRectangle.Location, Bounds.Size));
                    break;
                case "Manufacturers":
                    bmp = new Bitmap(
                        width: Bounds.Width,
                        height: Bounds.Height);

                    manufacturersGrid.DrawToBitmap(
                        bmp,
                        new Rectangle(DisplayRectangle.Location, Bounds.Size));
                    break;
                default:
                    break;
            }
        }

        private void DrawPrintingComp(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            CreateDrawingComp();
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        #endregion
    }
}