namespace ServiceStation
{
	partial class AskYearForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AskYearForm));
            this.buttonOK = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.finderBox = new System.Windows.Forms.GroupBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.finderBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOK.AutoEllipsis = true;
            this.buttonOK.BackColor = System.Drawing.Color.Lavender;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Ivory;
            this.buttonOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Tag = "Find";
            this.buttonOK.UseCompatibleTextRendering = true;
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.Action);
            this.buttonOK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AskYearFormClose);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Lavender;
            this.mainPanel.Controls.Add(this.buttonOK);
            this.mainPanel.Controls.Add(this.buttonCancel);
            this.mainPanel.Controls.Add(this.finderBox);
            this.mainPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCancel.AutoEllipsis = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Ivory;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Tag = "Cancel";
            this.buttonCancel.UseCompatibleTextRendering = true;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.CloseAction);
            this.buttonCancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AskYearFormClose);
            // 
            // finderBox
            // 
            resources.ApplyResources(this.finderBox, "finderBox");
            this.finderBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.finderBox.Controls.Add(this.yearBox);
            this.finderBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.finderBox.Name = "finderBox";
            this.finderBox.TabStop = false;
            // 
            // yearBox
            // 
            this.yearBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.yearBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.yearBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.yearBox.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.yearBox, "yearBox");
            this.yearBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.yearBox.Name = "yearBox";
            // 
            // AskYearForm
            // 
            this.AcceptButton = this.buttonOK;
            resources.ApplyResources(this, "$this");
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.CancelButton = this.buttonCancel;
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AskYearForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Tag = "findform";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AskYearFormLoader);
            this.Click += new System.EventHandler(this.FocusOnFindAction);
            this.mainPanel.ResumeLayout(false);
            this.finderBox.ResumeLayout(false);
            this.finderBox.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.GroupBox finderBox;
		private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.Button buttonCancel;
    }
}