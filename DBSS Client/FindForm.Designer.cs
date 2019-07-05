namespace ServiceStation
{
	partial class FinderForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinderForm));
			this.buttonFind = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
			this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.serviceStationDS = new ServiceStation.ServiceStationDS();
			this.carsTableAdapter = new ServiceStation.ServiceStationDSTableAdapters.CarsTableAdapter();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.finderBox = new System.Windows.Forms.GroupBox();
			this.tableBox = new System.Windows.Forms.TextBox();
			this.toolFindBox = new System.Windows.Forms.GroupBox();
			this.hardRadio = new System.Windows.Forms.RadioButton();
			this.softRadio = new System.Windows.Forms.RadioButton();
			this.columnBox = new System.Windows.Forms.ComboBox();
			this.labelFind = new System.Windows.Forms.Label();
			this.findBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceStationDS)).BeginInit();
			this.mainPanel.SuspendLayout();
			this.finderBox.SuspendLayout();
			this.toolFindBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonFind
			// 
			resources.ApplyResources(this.buttonFind, "buttonFind");
			this.buttonFind.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonFind.BackColor = System.Drawing.Color.Lavender;
			this.buttonFind.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonFind.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.buttonFind.FlatAppearance.BorderSize = 0;
			this.buttonFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
			this.buttonFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
			this.buttonFind.Name = "buttonFind";
			this.buttonFind.Tag = "Find";
			this.buttonFind.UseCompatibleTextRendering = true;
			this.buttonFind.UseVisualStyleBackColor = false;
			this.buttonFind.Click += new System.EventHandler(this.FindAction);
			this.buttonFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FinderFormClose);
			// 
			// buttonClose
			// 
			resources.ApplyResources(this.buttonClose, "buttonClose");
			this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
			this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Tag = "Cancel";
			this.buttonClose.UseCompatibleTextRendering = true;
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.CloseAction);
			// 
			// carsBindingSource
			// 
			this.carsBindingSource.DataMember = "Cars";
			this.carsBindingSource.DataSource = this.serviceStationDS;
			// 
			// serviceStationDS
			// 
			this.serviceStationDS.DataSetName = "ServiceStationDS";
			this.serviceStationDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// carsTableAdapter
			// 
			this.carsTableAdapter.ClearBeforeFill = true;
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.Lavender;
			this.mainPanel.Controls.Add(this.finderBox);
			this.mainPanel.Controls.Add(this.buttonClose);
			this.mainPanel.Controls.Add(this.buttonFind);
			resources.ApplyResources(this.mainPanel, "mainPanel");
			this.mainPanel.Name = "mainPanel";
			// 
			// finderBox
			// 
			resources.ApplyResources(this.finderBox, "finderBox");
			this.finderBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.finderBox.Controls.Add(this.tableBox);
			this.finderBox.Controls.Add(this.toolFindBox);
			this.finderBox.Controls.Add(this.columnBox);
			this.finderBox.Controls.Add(this.labelFind);
			this.finderBox.Controls.Add(this.findBox);
			this.finderBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.finderBox.Name = "finderBox";
			this.finderBox.TabStop = false;
			// 
			// tableBox
			// 
			this.tableBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.tableBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tableBox.Cursor = System.Windows.Forms.Cursors.Default;
			resources.ApplyResources(this.tableBox, "tableBox");
			this.tableBox.Name = "tableBox";
			this.tableBox.ReadOnly = true;
			this.tableBox.ShortcutsEnabled = false;
			this.tableBox.TabStop = false;
			// 
			// toolFindBox
			// 
			resources.ApplyResources(this.toolFindBox, "toolFindBox");
			this.toolFindBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.toolFindBox.Controls.Add(this.hardRadio);
			this.toolFindBox.Controls.Add(this.softRadio);
			this.toolFindBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.toolFindBox.Name = "toolFindBox";
			this.toolFindBox.TabStop = false;
			this.toolFindBox.UseCompatibleTextRendering = true;
			// 
			// hardRadio
			// 
			resources.ApplyResources(this.hardRadio, "hardRadio");
			this.hardRadio.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
			this.hardRadio.Name = "hardRadio";
			this.hardRadio.TabStop = true;
			this.hardRadio.UseCompatibleTextRendering = true;
			this.hardRadio.UseVisualStyleBackColor = true;
			this.hardRadio.Click += new System.EventHandler(this.FocusOnFindAction);
			// 
			// softRadio
			// 
			resources.ApplyResources(this.softRadio, "softRadio");
			this.softRadio.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
			this.softRadio.Checked = true;
			this.softRadio.Name = "softRadio";
			this.softRadio.TabStop = true;
			this.softRadio.UseCompatibleTextRendering = true;
			this.softRadio.UseVisualStyleBackColor = true;
			this.softRadio.Click += new System.EventHandler(this.FocusOnFindAction);
			// 
			// columnBox
			// 
			this.columnBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.columnBox.BackColor = System.Drawing.Color.Lavender;
			this.columnBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			resources.ApplyResources(this.columnBox, "columnBox");
			this.columnBox.FormattingEnabled = true;
			this.columnBox.Name = "columnBox";
			// 
			// labelFind
			// 
			this.labelFind.AutoEllipsis = true;
			resources.ApplyResources(this.labelFind, "labelFind");
			this.labelFind.Cursor = System.Windows.Forms.Cursors.Default;
			this.labelFind.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.labelFind.Name = "labelFind";
			this.labelFind.UseCompatibleTextRendering = true;
			// 
			// findBox
			// 
			this.findBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.findBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.findBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.findBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.findBox.ForeColor = System.Drawing.SystemColors.WindowText;
			resources.ApplyResources(this.findBox, "findBox");
			this.findBox.Name = "findBox";
			// 
			// FinderForm
			// 
			this.AcceptButton = this.buttonFind;
			resources.ApplyResources(this, "$this");
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumPurple;
			this.CancelButton = this.buttonClose;
			this.ControlBox = false;
			this.Controls.Add(this.mainPanel);
			this.ForeColor = System.Drawing.SystemColors.WindowText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FinderForm";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Tag = "findform";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FinderFormLoader);
			this.Click += new System.EventHandler(this.FocusOnFindAction);
			((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceStationDS)).EndInit();
			this.mainPanel.ResumeLayout(false);
			this.finderBox.ResumeLayout(false);
			this.finderBox.PerformLayout();
			this.toolFindBox.ResumeLayout(false);
			this.toolFindBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonFind;
		private System.Windows.Forms.Button buttonClose;
		private ServiceStationDS serviceStationDS;
		private System.Windows.Forms.BindingSource carsBindingSource;
		private ServiceStationDSTableAdapters.CarsTableAdapter carsTableAdapter;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.GroupBox finderBox;
		private System.Windows.Forms.TextBox tableBox;
		private System.Windows.Forms.GroupBox toolFindBox;
		private System.Windows.Forms.RadioButton hardRadio;
		private System.Windows.Forms.RadioButton softRadio;
		private System.Windows.Forms.ComboBox columnBox;
		private System.Windows.Forms.Label labelFind;
		private System.Windows.Forms.TextBox findBox;
	}
}