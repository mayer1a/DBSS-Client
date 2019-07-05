using System;
using System.Windows.Forms;

namespace ServiceStation
{
	/// <summary>
	/// Finder window
	/// </summary>
	public partial class FinderForm : Form
	{
		/// <summary>
		/// Found results by this request and return to main form
		/// </summary>
		private static string Query { set; get; }
		
		/// <summary>
		/// Return generated query
		/// </summary>
		public static string ReturnQuery { get => Query; }
		private string TableName { set; get; }

		/// <summary>
		/// Constructor of all components in the form
		/// </summary>
		public FinderForm(string TableName)
		{
			InitializeComponent();
			this.TableName = TableName;
			Query = string.Empty;
		}

		
		private void FinderFormLoader(object sender, EventArgs e)
		{
			findBox.Focus();

			tableBox.Text = $"Table: { TableName }";

			//TODO: данная строка кода позволяет очистить данные из бокса выбора столбца поиска
			columnBox.Items.Clear();

			#region Autocomplete combobox find on column

			switch (TableName)
			{
				case "Cars":
					foreach (object col in serviceStationDS.Cars.Columns)
					{
						columnBox.Items.Add(col.ToString());
					}
					break;
				case "CarOwners":
					foreach (object col in serviceStationDS.CarOwners.Columns)
					{
						columnBox.Items.Add(col.ToString());
					}
					break;
				case "Manufacturers":
					foreach (object col in serviceStationDS.Manufacturers.Columns)
					{
						columnBox.Items.Add(col.ToString());
					}
					break;
				case "Applications":
					foreach (object col in serviceStationDS.Applications.Columns)
					{
						columnBox.Items.Add(col.ToString());
					}
					break;
				case "Masters":
					foreach (object col in serviceStationDS.Masters.Columns)
					{
						columnBox.Items.Add(col.ToString());
					}
					break;
				case "Services":
					foreach (object col in serviceStationDS.Services.Columns)
					{
						columnBox.Items.Add(col.ToString());
					}
					break;
				case "Data":
					foreach (object col in serviceStationDS.DATA.Columns)
					{
						columnBox.Items.Add(col.ToString());
					}
					break;
				default:
					break;
			}

			#endregion

			columnBox.SelectedIndex = 0;
		}

		private void FinderFormClose(object sender, KeyEventArgs e)
		{
			if (e.KeyData.Equals(Keys.Escape)) Close();
		}

		private void CloseAction(object sender, EventArgs e)
		{
			Close();
		}

		private void FocusOnFindAction(object sender, EventArgs e)
		{
			buttonFind.Focus();
		}

		private void FindAction(object sender, EventArgs e)
		{
			string choose = columnBox.Items[columnBox.SelectedIndex].ToString();

			if (!findBox.Equals(""))
			{
				if (softRadio.Checked)
				{
					Query = string.Format($"CONVERT({ choose }, System.String) like '%{findBox.Text}%'");
				}
				else
				{
					Query = string.Format($"CONVERT({ choose }, System.String)='{ findBox.Text }'");
				}
			}
		}
	}
}