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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinderForm));
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.findPanel = new System.Windows.Forms.Panel();
            this.sensFindBox = new System.Windows.Forms.GroupBox();
            this.hardRadio = new System.Windows.Forms.RadioButton();
            this.softRadio = new System.Windows.Forms.RadioButton();
            this.toolFindBox = new System.Windows.Forms.GroupBox();
            this.columnBox = new System.Windows.Forms.ComboBox();
            this.finderBox = new System.Windows.Forms.GroupBox();
            this.findBox = new System.Windows.Forms.TextBox();
            this.dbssDS = new ServiceStation.DbssDS();
            this.mainPanel.SuspendLayout();
            this.findPanel.SuspendLayout();
            this.sensFindBox.SuspendLayout();
            this.toolFindBox.SuspendLayout();
            this.finderBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbssDS)).BeginInit();
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
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.buttonClose.Image = global::ServiceStation.Properties.Resources.close;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Tag = "Cancel";
            this.buttonClose.UseCompatibleTextRendering = true;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.CloseAction);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Lavender;
            this.mainPanel.Controls.Add(this.buttonClose);
            this.mainPanel.Controls.Add(this.findPanel);
            this.mainPanel.Controls.Add(this.sensFindBox);
            this.mainPanel.Controls.Add(this.toolFindBox);
            this.mainPanel.Controls.Add(this.finderBox);
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
            // 
            // findPanel
            // 
            this.findPanel.Controls.Add(this.buttonFind);
            resources.ApplyResources(this.findPanel, "findPanel");
            this.findPanel.Name = "findPanel";
            // 
            // sensFindBox
            // 
            resources.ApplyResources(this.sensFindBox, "sensFindBox");
            this.sensFindBox.Controls.Add(this.hardRadio);
            this.sensFindBox.Controls.Add(this.softRadio);
            this.sensFindBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sensFindBox.Name = "sensFindBox";
            this.sensFindBox.TabStop = false;
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
            // toolFindBox
            // 
            resources.ApplyResources(this.toolFindBox, "toolFindBox");
            this.toolFindBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.toolFindBox.Controls.Add(this.columnBox);
            this.toolFindBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolFindBox.Name = "toolFindBox";
            this.toolFindBox.TabStop = false;
            this.toolFindBox.UseCompatibleTextRendering = true;
            // 
            // columnBox
            // 
            this.columnBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.columnBox.BackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.columnBox, "columnBox");
            this.columnBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnBox.FormattingEnabled = true;
            this.columnBox.Name = "columnBox";
            // 
            // finderBox
            // 
            resources.ApplyResources(this.finderBox, "finderBox");
            this.finderBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.finderBox.Controls.Add(this.findBox);
            this.finderBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.finderBox.Name = "finderBox";
            this.finderBox.TabStop = false;
            // 
            // findBox
            // 
            this.findBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.findBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.findBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.findBox.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.findBox, "findBox");
            this.findBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.findBox.Name = "findBox";
            // 
            // dbssDS
            // 
            this.dbssDS.DataSetName = "DbssDS";
            this.dbssDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.findPanel.ResumeLayout(false);
            this.sensFindBox.ResumeLayout(false);
            this.sensFindBox.PerformLayout();
            this.toolFindBox.ResumeLayout(false);
            this.finderBox.ResumeLayout(false);
            this.finderBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbssDS)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonFind;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.GroupBox finderBox;
		private System.Windows.Forms.GroupBox toolFindBox;
		private System.Windows.Forms.RadioButton hardRadio;
		private System.Windows.Forms.RadioButton softRadio;
		private System.Windows.Forms.ComboBox columnBox;
		private System.Windows.Forms.TextBox findBox;
		private DbssDS dbssDS;
        private System.Windows.Forms.Panel findPanel;
        private System.Windows.Forms.GroupBox sensFindBox;
    }
}