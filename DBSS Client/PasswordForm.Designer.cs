namespace ServiceStation
{
	partial class PasswordForm
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
            System.Windows.Forms.Panel passwordPanel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordForm));
            this.buttonClose = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passTip = new System.Windows.Forms.ToolTip(this.components);
            this.dbssDS = new ServiceStation.DbssDS();
            passwordPanel = new System.Windows.Forms.Panel();
            passwordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbssDS)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordPanel
            // 
            passwordPanel.BackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(passwordPanel, "passwordPanel");
            passwordPanel.Controls.Add(this.buttonClose);
            passwordPanel.Controls.Add(this.cancelButton);
            passwordPanel.Controls.Add(this.pictureBox1);
            passwordPanel.Controls.Add(this.submitButton);
            passwordPanel.Controls.Add(this.passBox);
            passwordPanel.Controls.Add(this.label1);
            passwordPanel.Name = "passwordPanel";
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
            this.buttonClose.Tag = "Close";
            this.buttonClose.UseCompatibleTextRendering = true;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.CloseAction);
            this.buttonClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordFormClose);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseCompatibleTextRendering = true;
            this.cancelButton.UseMnemonic = false;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CloseAction);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::ServiceStation.Properties.Resources.securityprotect;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.passTip.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            this.pictureBox1.Click += new System.EventHandler(this.PasswordVisible);
            // 
            // submitButton
            // 
            resources.ApplyResources(this.submitButton, "submitButton");
            this.submitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Ivory;
            this.submitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.submitButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.submitButton.Name = "submitButton";
            this.submitButton.Tag = "Submit";
            this.submitButton.UseCompatibleTextRendering = true;
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitAction);
            this.submitButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordFormClose);
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.passBox, "passBox");
            this.passBox.Name = "passBox";
            this.passBox.UseSystemPasswordChar = true;
            this.passBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordFormClose);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.UseMnemonic = false;
            // 
            // passTip
            // 
            this.passTip.BackColor = System.Drawing.Color.LavenderBlush;
            this.passTip.ForeColor = System.Drawing.SystemColors.WindowText;
            this.passTip.IsBalloon = true;
            this.passTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.passTip.ToolTipTitle = "Click to display password char";
            // 
            // dbssDS
            // 
            this.dbssDS.DataSetName = "DbssDS";
            this.dbssDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PasswordForm
            // 
            this.AcceptButton = this.submitButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ControlBox = false;
            this.Controls.Add(passwordPanel);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PasswordFormLoad);
            this.Click += new System.EventHandler(this.FocusOnSubmit);
            passwordPanel.ResumeLayout(false);
            passwordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbssDS)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox passBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolTip passTip;
		private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button buttonClose;
        private DbssDS dbssDS;
    }
}