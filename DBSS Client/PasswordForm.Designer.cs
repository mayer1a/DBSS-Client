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
			this.cancelButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.submitButton = new System.Windows.Forms.Button();
			this.passBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.adapterManager = new ServiceStation.ServiceStationDSTableAdapters.TableAdapterManager();
			this.dataAdapter = new ServiceStation.ServiceStationDSTableAdapters.DATATableAdapter();
			this.serviceStationDS = new ServiceStation.ServiceStationDS();
			this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.passTip = new System.Windows.Forms.ToolTip(this.components);
			passwordPanel = new System.Windows.Forms.Panel();
			passwordPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceStationDS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// passwordPanel
			// 
			passwordPanel.BackColor = System.Drawing.Color.Lavender;
			resources.ApplyResources(passwordPanel, "passwordPanel");
			passwordPanel.Controls.Add(this.cancelButton);
			passwordPanel.Controls.Add(this.pictureBox1);
			passwordPanel.Controls.Add(this.submitButton);
			passwordPanel.Controls.Add(this.passBox);
			passwordPanel.Controls.Add(this.label1);
			passwordPanel.Name = "passwordPanel";
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			resources.ApplyResources(this.cancelButton, "cancelButton");
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.UseCompatibleTextRendering = true;
			this.cancelButton.UseMnemonic = false;
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelAction);
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
			this.submitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
			this.submitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
			this.submitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
			this.submitButton.ForeColor = System.Drawing.SystemColors.WindowText;
			this.submitButton.Name = "submitButton";
			this.submitButton.Tag = "close";
			this.submitButton.UseCompatibleTextRendering = true;
			this.submitButton.UseMnemonic = false;
			this.submitButton.UseVisualStyleBackColor = false;
			this.submitButton.Click += new System.EventHandler(this.SubmitAction);
			// 
			// passBox
			// 
			this.passBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.passBox, "passBox");
			this.passBox.Name = "passBox";
			this.passBox.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// adapterManager
			// 
			this.adapterManager.ApplicationsTableAdapter = null;
			this.adapterManager.BackupDataSetBeforeUpdate = false;
			this.adapterManager.CarOwnersTableAdapter = null;
			this.adapterManager.CarsTableAdapter = null;
			this.adapterManager.DATATableAdapter = this.dataAdapter;
			this.adapterManager.ManufacturersTableAdapter = null;
			this.adapterManager.MastersTableAdapter = null;
			this.adapterManager.ServicesTableAdapter = null;
			this.adapterManager.UpdateOrder = ServiceStation.ServiceStationDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// dataAdapter
			// 
			this.dataAdapter.ClearBeforeFill = true;
			// 
			// serviceStationDS
			// 
			this.serviceStationDS.DataSetName = "ServiceStationDS";
			this.serviceStationDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// passTip
			// 
			this.passTip.BackColor = System.Drawing.Color.LavenderBlush;
			this.passTip.ForeColor = System.Drawing.SystemColors.WindowText;
			this.passTip.IsBalloon = true;
			this.passTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.passTip.ToolTipTitle = "Click to display password char";
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
			this.Click += new System.EventHandler(this.PasswordVisible);
			passwordPanel.ResumeLayout(false);
			passwordPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceStationDS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox passBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		private ServiceStationDSTableAdapters.TableAdapterManager adapterManager;
		private ServiceStationDS serviceStationDS;
		private ServiceStationDSTableAdapters.DATATableAdapter dataAdapter;
		private System.Windows.Forms.BindingSource bindingSource;
		private System.Windows.Forms.ToolTip passTip;
		private System.Windows.Forms.Button cancelButton;
	}
}