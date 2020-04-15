using System;
using System.Windows.Forms;

namespace ServiceStation
{
	/// <summary>
	/// Finder window
	/// </summary>
	public partial class AskYearForm : Form
	{
		/// <summary>
		/// Return generated query
		/// </summary>
		public static string ReturnValue { get; private set; }

		/// <summary>
		/// Constructor of all components in the form
		/// </summary>
		public AskYearForm()
		{
			InitializeComponent();
		}
		
		private void AskYearFormLoader(object sender, EventArgs e)
		{
			yearBox.Focus();
		}

		private void AskYearFormClose(object sender, KeyEventArgs e)
		{
			if (e.KeyData.Equals(Keys.Escape)) Close();
		}

		private void CloseAction(object sender, EventArgs e)
		{
			Close();
		}

		private void FocusOnFindAction(object sender, EventArgs e)
		{
			buttonOK.Focus();
		}

		private void Action(object sender, EventArgs e)
		{
			ReturnValue = yearBox.Text.Trim();
		}
	}
}