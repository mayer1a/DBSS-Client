namespace ServiceStation
{
	partial class AuthorizationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
			this.welcomeLabel = new System.Windows.Forms.Label();
			this.loginBox = new System.Windows.Forms.TextBox();
			this.passBox = new System.Windows.Forms.TextBox();
			this.passTip = new System.Windows.Forms.ToolTip(this.components);
			this.passPicture = new System.Windows.Forms.PictureBox();
			this.dataAdapter = new ServiceStation.ServiceStationDSTableAdapters.DATATableAdapter();
			this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.serviceStationDS = new ServiceStation.ServiceStationDS();
			this.AdapterManager = new ServiceStation.ServiceStationDSTableAdapters.TableAdapterManager();
			this.invalidPassLog = new System.Windows.Forms.Label();
			this.timerMove = new System.Windows.Forms.Timer(this.components);
			this.loginButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.moveImg = new System.Windows.Forms.PictureBox();
			this.backgroundImg = new System.Windows.Forms.PictureBox();
			this.loginPicture = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timerSlowDisplay = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.passPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceStationDS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.moveImg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.backgroundImg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.loginPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// welcomeLabel
			// 
			this.welcomeLabel.AutoEllipsis = true;
			resources.ApplyResources(this.welcomeLabel, "welcomeLabel");
			this.welcomeLabel.Name = "welcomeLabel";
			this.welcomeLabel.UseCompatibleTextRendering = true;
			// 
			// loginBox
			// 
			this.loginBox.BackColor = System.Drawing.Color.Snow;
			this.loginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.loginBox, "loginBox");
			this.loginBox.Name = "loginBox";
			// 
			// passBox
			// 
			this.passBox.BackColor = System.Drawing.Color.Snow;
			this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.passBox, "passBox");
			this.passBox.Name = "passBox";
			this.passBox.UseSystemPasswordChar = true;
			// 
			// passTip
			// 
			this.passTip.BackColor = System.Drawing.Color.LavenderBlush;
			this.passTip.ForeColor = System.Drawing.SystemColors.WindowText;
			this.passTip.IsBalloon = true;
			this.passTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.passTip.ToolTipTitle = "Click to display password char";
			// 
			// passPicture
			// 
			resources.ApplyResources(this.passPicture, "passPicture");
			this.passPicture.Image = global::ServiceStation.Properties.Resources.securityprotect;
			this.passPicture.Name = "passPicture";
			this.passPicture.TabStop = false;
			this.passTip.SetToolTip(this.passPicture, resources.GetString("passPicture.ToolTip"));
			this.passPicture.Click += new System.EventHandler(this.PassVisible);
			// 
			// dataAdapter
			// 
			this.dataAdapter.ClearBeforeFill = true;
			// 
			// bindingSource
			// 
			this.bindingSource.AllowNew = false;
			this.bindingSource.DataMember = "DATA";
			this.bindingSource.DataSource = this.serviceStationDS;
			// 
			// serviceStationDS
			// 
			this.serviceStationDS.DataSetName = "ServiceStationDS";
			this.serviceStationDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// AdapterManager
			// 
			this.AdapterManager.ApplicationsTableAdapter = null;
			this.AdapterManager.BackupDataSetBeforeUpdate = false;
			this.AdapterManager.CarOwnersTableAdapter = null;
			this.AdapterManager.CarsTableAdapter = null;
			this.AdapterManager.DATATableAdapter = this.dataAdapter;
			this.AdapterManager.ManufacturersTableAdapter = null;
			this.AdapterManager.MastersTableAdapter = null;
			this.AdapterManager.ServicesTableAdapter = null;
			this.AdapterManager.UpdateOrder = ServiceStation.ServiceStationDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// invalidPassLog
			// 
			this.invalidPassLog.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			resources.ApplyResources(this.invalidPassLog, "invalidPassLog");
			this.invalidPassLog.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.invalidPassLog.ForeColor = System.Drawing.Color.Crimson;
			this.invalidPassLog.Name = "invalidPassLog";
			this.invalidPassLog.UseCompatibleTextRendering = true;
			// 
			// timerMove
			// 
			this.timerMove.Enabled = true;
			this.timerMove.Interval = 1;
			this.timerMove.Tick += new System.EventHandler(this.MoveTimerTick);
			// 
			// loginButton
			// 
			resources.ApplyResources(this.loginButton, "loginButton");
			this.loginButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.loginButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
			this.loginButton.FlatAppearance.BorderSize = 0;
			this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Ivory;
			this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
			this.loginButton.ForeColor = System.Drawing.SystemColors.WindowText;
			this.loginButton.Image = global::ServiceStation.Properties.Resources.login;
			this.loginButton.Name = "loginButton";
			this.loginButton.Tag = "close";
			this.loginButton.UseCompatibleTextRendering = true;
			this.loginButton.UseVisualStyleBackColor = false;
			this.loginButton.Click += new System.EventHandler(this.LoginAction);
			// 
			// button1
			// 
			resources.ApplyResources(this.button1, "button1");
			this.button1.BackgroundImage = global::ServiceStation.Properties.Resources.close;
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Ivory;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
			this.button1.ForeColor = System.Drawing.Color.Lavender;
			this.button1.Name = "button1";
			this.button1.Tag = "close";
			this.button1.UseCompatibleTextRendering = true;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ButtExit);
			// 
			// moveImg
			// 
			resources.ApplyResources(this.moveImg, "moveImg");
			this.moveImg.Image = global::ServiceStation.Properties.Resources.move;
			this.moveImg.Name = "moveImg";
			this.moveImg.TabStop = false;
			// 
			// backgroundImg
			// 
			resources.ApplyResources(this.backgroundImg, "backgroundImg");
			this.backgroundImg.Image = global::ServiceStation.Properties.Resources.background;
			this.backgroundImg.Name = "backgroundImg";
			this.backgroundImg.TabStop = false;
			// 
			// loginPicture
			// 
			resources.ApplyResources(this.loginPicture, "loginPicture");
			this.loginPicture.Image = global::ServiceStation.Properties.Resources.securityaccount;
			this.loginPicture.Name = "loginPicture";
			this.loginPicture.TabStop = false;
			// 
			// pictureBox1
			// 
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Image = global::ServiceStation.Properties.Resources.authorize;
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			// 
			// timerSlowDisplay
			// 
			this.timerSlowDisplay.Interval = 10;
			this.timerSlowDisplay.Tick += new System.EventHandler(this.SlowlyShowForm);
			// 
			// AuthorizationForm
			// 
			this.AcceptButton = this.loginButton;
			resources.ApplyResources(this, "$this");
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.CancelButton = this.button1;
			this.ControlBox = false;
			this.Controls.Add(this.moveImg);
			this.Controls.Add(this.backgroundImg);
			this.Controls.Add(this.invalidPassLog);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.passBox);
			this.Controls.Add(this.loginBox);
			this.Controls.Add(this.passPicture);
			this.Controls.Add(this.loginPicture);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.welcomeLabel);
			this.Controls.Add(this.pictureBox1);
			this.ForeColor = System.Drawing.SystemColors.WindowText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AuthorizationForm";
			this.Opacity = 0D;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Tag = "authorization";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.AuthorizationFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.passPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceStationDS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.moveImg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.backgroundImg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.loginPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label welcomeLabel;
		private System.Windows.Forms.PictureBox loginPicture;
		private System.Windows.Forms.PictureBox passPicture;
		private System.Windows.Forms.TextBox loginBox;
		private System.Windows.Forms.TextBox passBox;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.ToolTip passTip;
		private ServiceStationDSTableAdapters.DATATableAdapter dataAdapter;
		private System.Windows.Forms.BindingSource bindingSource;
		private ServiceStationDS serviceStationDS;
		private ServiceStationDSTableAdapters.TableAdapterManager AdapterManager;
		private System.Windows.Forms.Label invalidPassLog;
		private System.Windows.Forms.Timer timerMove;
		private System.Windows.Forms.PictureBox backgroundImg;
		private System.Windows.Forms.PictureBox moveImg;
		private System.Windows.Forms.Timer timerSlowDisplay;
	}
}