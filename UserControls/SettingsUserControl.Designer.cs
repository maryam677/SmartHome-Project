namespace WinFormsApp2.UserControls
{
    partial class SettingsUserControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitleIcon = new WinFormsApp2.Controls.RoundedPanel();
            this.lblTitleIcon = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlLightingSettings = new WinFormsApp2.Controls.RoundedPanel();
            this.lblLightingSettingsIcon = new System.Windows.Forms.Label();
            this.lblLightingSettingsTitle = new System.Windows.Forms.Label();
            this.lblDefaultBrightness = new System.Windows.Forms.Label();
            this.lblDefaultBrightnessValue = new System.Windows.Forms.Label();
            this.trackDefaultBrightness = new System.Windows.Forms.TrackBar();
            this.lblDefaultBrightnessHint = new System.Windows.Forms.Label();
            this.chkAutoOff = new System.Windows.Forms.CheckBox();
            this.lblAutoOffHint = new System.Windows.Forms.Label();
            this.pnlGeneralSettings = new WinFormsApp2.Controls.RoundedPanel();
            this.lblGeneralSettingsIcon = new System.Windows.Forms.Label();
            this.lblGeneralSettingsTitle = new System.Windows.Forms.Label();
            this.chkNotifications = new System.Windows.Forms.CheckBox();
            this.lblNotificationsHint = new System.Windows.Forms.Label();
            this.lblTheme = new System.Windows.Forms.Label();
            this.cmbTheme = new System.Windows.Forms.ComboBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnResetSettings = new System.Windows.Forms.Button();
            this.lblSaveStatus = new System.Windows.Forms.Label();
            this.pnlTitleIcon.SuspendLayout();
            this.pnlLightingSettings.SuspendLayout();
            this.pnlGeneralSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackDefaultBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleIcon
            // 
            this.pnlTitleIcon.Controls.Add(this.lblTitleIcon);
            this.pnlTitleIcon.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitleIcon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.pnlTitleIcon.BorderRadius = 14;
            this.pnlTitleIcon.BorderThickness = 1F;
            this.pnlTitleIcon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(21)))), ((int)(((byte)(56)))));
            this.pnlTitleIcon.Location = new System.Drawing.Point(24, 18);
            this.pnlTitleIcon.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlTitleIcon.Size = new System.Drawing.Size(58, 58);
            this.pnlTitleIcon.Name = "pnlTitleIcon";
            this.pnlTitleIcon.TabIndex = 0;
            // 
            // lblTitleIcon
            // 
            this.lblTitleIcon.AutoSize = true;
            this.lblTitleIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.lblTitleIcon.Location = new System.Drawing.Point(12, 13);
            this.lblTitleIcon.Size = new System.Drawing.Size(41, 45);
            this.lblTitleIcon.Text = "\uE713";
            this.lblTitleIcon.UseMnemonic = false;
            this.lblTitleIcon.Name = "lblTitleIcon";
            this.lblTitleIcon.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblTitle.Location = new System.Drawing.Point(94, 14);
            this.lblTitle.Size = new System.Drawing.Size(130, 42);
            this.lblTitle.Text = "Settings";
            this.lblTitle.UseMnemonic = false;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 1;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblSubtitle.Location = new System.Drawing.Point(97, 54);
            this.lblSubtitle.Size = new System.Drawing.Size(250, 23);
            this.lblSubtitle.Text = "Customize your SmartHome experience";
            this.lblSubtitle.UseMnemonic = false;
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.TabIndex = 2;
            // 
            // pnlLightingSettings
            // 
            this.pnlLightingSettings.Controls.Add(this.lblLightingSettingsIcon);
            this.pnlLightingSettings.Controls.Add(this.lblLightingSettingsTitle);
            this.pnlLightingSettings.Controls.Add(this.lblDefaultBrightness);
            this.pnlLightingSettings.Controls.Add(this.lblDefaultBrightnessValue);
            this.pnlLightingSettings.Controls.Add(this.trackDefaultBrightness);
            this.pnlLightingSettings.Controls.Add(this.lblDefaultBrightnessHint);
            this.pnlLightingSettings.Controls.Add(this.chkAutoOff);
            this.pnlLightingSettings.Controls.Add(this.lblAutoOffHint);
            this.pnlLightingSettings.BackColor = System.Drawing.Color.Transparent;
            this.pnlLightingSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.pnlLightingSettings.BorderRadius = 16;
            this.pnlLightingSettings.BorderThickness = 1F;
            this.pnlLightingSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(21)))), ((int)(((byte)(56)))));
            this.pnlLightingSettings.Location = new System.Drawing.Point(24, 100);
            this.pnlLightingSettings.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlLightingSettings.Size = new System.Drawing.Size(548, 260);
            this.pnlLightingSettings.Name = "pnlLightingSettings";
            this.pnlLightingSettings.TabIndex = 3;
            // 
            // lblLightingSettingsIcon
            // 
            this.lblLightingSettingsIcon.AutoSize = true;
            this.lblLightingSettingsIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblLightingSettingsIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLightingSettingsIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.lblLightingSettingsIcon.Location = new System.Drawing.Point(20, 20);
            this.lblLightingSettingsIcon.Size = new System.Drawing.Size(28, 32);
            this.lblLightingSettingsIcon.Text = "\uEA80";
            this.lblLightingSettingsIcon.UseMnemonic = false;
            this.lblLightingSettingsIcon.Name = "lblLightingSettingsIcon";
            this.lblLightingSettingsIcon.TabIndex = 0;
            // 
            // lblLightingSettingsTitle
            // 
            this.lblLightingSettingsTitle.AutoSize = true;
            this.lblLightingSettingsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblLightingSettingsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLightingSettingsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblLightingSettingsTitle.Location = new System.Drawing.Point(48, 14);
            this.lblLightingSettingsTitle.Size = new System.Drawing.Size(193, 26);
            this.lblLightingSettingsTitle.Text = "Lighting Preferences";
            this.lblLightingSettingsTitle.UseMnemonic = false;
            this.lblLightingSettingsTitle.Name = "lblLightingSettingsTitle";
            this.lblLightingSettingsTitle.TabIndex = 1;
            // 
            // lblDefaultBrightness
            // 
            this.lblDefaultBrightness.AutoSize = true;
            this.lblDefaultBrightness.BackColor = System.Drawing.Color.Transparent;
            this.lblDefaultBrightness.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDefaultBrightness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblDefaultBrightness.Location = new System.Drawing.Point(20, 66);
            this.lblDefaultBrightness.Size = new System.Drawing.Size(131, 23);
            this.lblDefaultBrightness.Text = "Default Brightness";
            this.lblDefaultBrightness.UseMnemonic = false;
            this.lblDefaultBrightness.Name = "lblDefaultBrightness";
            this.lblDefaultBrightness.TabIndex = 2;
            // 
            // lblDefaultBrightnessValue
            // 
            this.lblDefaultBrightnessValue.AutoSize = false;
            this.lblDefaultBrightnessValue.BackColor = System.Drawing.Color.Transparent;
            this.lblDefaultBrightnessValue.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDefaultBrightnessValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblDefaultBrightnessValue.Location = new System.Drawing.Point(450, 64);
            this.lblDefaultBrightnessValue.Size = new System.Drawing.Size(78, 24);
            this.lblDefaultBrightnessValue.Text = "75%";
            this.lblDefaultBrightnessValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDefaultBrightnessValue.UseMnemonic = false;
            this.lblDefaultBrightnessValue.Name = "lblDefaultBrightnessValue";
            this.lblDefaultBrightnessValue.TabIndex = 3;
            // 
            // trackDefaultBrightness
            // 
            this.trackDefaultBrightness.AutoSize = false;
            this.trackDefaultBrightness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(21)))), ((int)(((byte)(56)))));
            this.trackDefaultBrightness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackDefaultBrightness.Location = new System.Drawing.Point(14, 96);
            this.trackDefaultBrightness.Maximum = 100;
            this.trackDefaultBrightness.Size = new System.Drawing.Size(520, 30);
            this.trackDefaultBrightness.TickFrequency = 10;
            this.trackDefaultBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackDefaultBrightness.Value = 75;
            this.trackDefaultBrightness.Name = "trackDefaultBrightness";
            this.trackDefaultBrightness.TabIndex = 4;
            this.trackDefaultBrightness.Scroll += new System.EventHandler(this.trackDefaultBrightness_Scroll);
            // 
            // lblDefaultBrightnessHint
            // 
            this.lblDefaultBrightnessHint.AutoSize = true;
            this.lblDefaultBrightnessHint.BackColor = System.Drawing.Color.Transparent;
            this.lblDefaultBrightnessHint.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDefaultBrightnessHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblDefaultBrightnessHint.Location = new System.Drawing.Point(20, 132);
            this.lblDefaultBrightnessHint.Size = new System.Drawing.Size(232, 20);
            this.lblDefaultBrightnessHint.Text = "Used when a light is turned on from 0%";
            this.lblDefaultBrightnessHint.UseMnemonic = false;
            this.lblDefaultBrightnessHint.Name = "lblDefaultBrightnessHint";
            this.lblDefaultBrightnessHint.TabIndex = 5;
            // 
            // chkAutoOff
            // 
            this.chkAutoOff.AutoSize = true;
            this.chkAutoOff.BackColor = System.Drawing.Color.Transparent;
            this.chkAutoOff.Checked = false;
            this.chkAutoOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAutoOff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkAutoOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.chkAutoOff.Location = new System.Drawing.Point(20, 178);
            this.chkAutoOff.Size = new System.Drawing.Size(274, 23);
            this.chkAutoOff.Text = "Auto-Off lights when nobody is home";
            this.chkAutoOff.UseVisualStyleBackColor = true;
            this.chkAutoOff.Name = "chkAutoOff";
            this.chkAutoOff.TabIndex = 6;
            // 
            // lblAutoOffHint
            // 
            this.lblAutoOffHint.AutoSize = true;
            this.lblAutoOffHint.BackColor = System.Drawing.Color.Transparent;
            this.lblAutoOffHint.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAutoOffHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblAutoOffHint.Location = new System.Drawing.Point(42, 206);
            this.lblAutoOffHint.Size = new System.Drawing.Size(309, 20);
            this.lblAutoOffHint.Text = "Simulated feature: lights turn off after 30 minutes";
            this.lblAutoOffHint.UseMnemonic = false;
            this.lblAutoOffHint.Name = "lblAutoOffHint";
            this.lblAutoOffHint.TabIndex = 7;
            // 
            // pnlGeneralSettings
            // 
            this.pnlGeneralSettings.Controls.Add(this.lblGeneralSettingsIcon);
            this.pnlGeneralSettings.Controls.Add(this.lblGeneralSettingsTitle);
            this.pnlGeneralSettings.Controls.Add(this.chkNotifications);
            this.pnlGeneralSettings.Controls.Add(this.lblNotificationsHint);
            this.pnlGeneralSettings.Controls.Add(this.lblTheme);
            this.pnlGeneralSettings.Controls.Add(this.cmbTheme);
            this.pnlGeneralSettings.BackColor = System.Drawing.Color.Transparent;
            this.pnlGeneralSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.pnlGeneralSettings.BorderRadius = 16;
            this.pnlGeneralSettings.BorderThickness = 1F;
            this.pnlGeneralSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(21)))), ((int)(((byte)(56)))));
            this.pnlGeneralSettings.Location = new System.Drawing.Point(596, 100);
            this.pnlGeneralSettings.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlGeneralSettings.Size = new System.Drawing.Size(550, 260);
            this.pnlGeneralSettings.Name = "pnlGeneralSettings";
            this.pnlGeneralSettings.TabIndex = 4;
            // 
            // lblGeneralSettingsIcon
            // 
            this.lblGeneralSettingsIcon.AutoSize = true;
            this.lblGeneralSettingsIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblGeneralSettingsIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGeneralSettingsIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.lblGeneralSettingsIcon.Location = new System.Drawing.Point(20, 20);
            this.lblGeneralSettingsIcon.Size = new System.Drawing.Size(28, 32);
            this.lblGeneralSettingsIcon.Text = "\uE713";
            this.lblGeneralSettingsIcon.UseMnemonic = false;
            this.lblGeneralSettingsIcon.Name = "lblGeneralSettingsIcon";
            this.lblGeneralSettingsIcon.TabIndex = 0;
            // 
            // lblGeneralSettingsTitle
            // 
            this.lblGeneralSettingsTitle.AutoSize = true;
            this.lblGeneralSettingsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGeneralSettingsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGeneralSettingsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblGeneralSettingsTitle.Location = new System.Drawing.Point(48, 14);
            this.lblGeneralSettingsTitle.Size = new System.Drawing.Size(71, 26);
            this.lblGeneralSettingsTitle.Text = "General";
            this.lblGeneralSettingsTitle.UseMnemonic = false;
            this.lblGeneralSettingsTitle.Name = "lblGeneralSettingsTitle";
            this.lblGeneralSettingsTitle.TabIndex = 1;
            // 
            // chkNotifications
            // 
            this.chkNotifications.AutoSize = true;
            this.chkNotifications.BackColor = System.Drawing.Color.Transparent;
            this.chkNotifications.Checked = true;
            this.chkNotifications.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkNotifications.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkNotifications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.chkNotifications.Location = new System.Drawing.Point(20, 66);
            this.chkNotifications.Size = new System.Drawing.Size(170, 23);
            this.chkNotifications.Text = "Enable notifications";
            this.chkNotifications.UseVisualStyleBackColor = true;
            this.chkNotifications.Name = "chkNotifications";
            this.chkNotifications.TabIndex = 2;
            // 
            // lblNotificationsHint
            // 
            this.lblNotificationsHint.AutoSize = true;
            this.lblNotificationsHint.BackColor = System.Drawing.Color.Transparent;
            this.lblNotificationsHint.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNotificationsHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblNotificationsHint.Location = new System.Drawing.Point(42, 94);
            this.lblNotificationsHint.Size = new System.Drawing.Size(273, 20);
            this.lblNotificationsHint.Text = "Show a message when lights or security change";
            this.lblNotificationsHint.UseMnemonic = false;
            this.lblNotificationsHint.Name = "lblNotificationsHint";
            this.lblNotificationsHint.TabIndex = 3;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.BackColor = System.Drawing.Color.Transparent;
            this.lblTheme.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblTheme.Location = new System.Drawing.Point(20, 142);
            this.lblTheme.Size = new System.Drawing.Size(41, 23);
            this.lblTheme.Text = "Theme";
            this.lblTheme.UseMnemonic = false;
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.TabIndex = 4;
            // 
            // cmbTheme
            // 
            this.cmbTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(46)))));
            this.cmbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTheme.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.Location = new System.Drawing.Point(20, 170);
            this.cmbTheme.Size = new System.Drawing.Size(300, 27);
            this.cmbTheme.Items.AddRange(new object[] {
            "Dark Purple",
            "Midnight Blue",
            "Deep Violet"});
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.TabIndex = 5;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnSaveSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnSaveSettings.FlatAppearance.BorderSize = 0;
            this.btnSaveSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(40)))), ((int)(((byte)(217)))));
            this.btnSaveSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnSaveSettings.Image = global::WinFormsApp2.Properties.Resources.btn_save;
            this.btnSaveSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveSettings.Location = new System.Drawing.Point(24, 384);
            this.btnSaveSettings.Size = new System.Drawing.Size(170, 44);
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.TabIndex = 5;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(46)))));
            this.btnResetSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.btnResetSettings.FlatAppearance.BorderSize = 1;
            this.btnResetSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.btnResetSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(27)))), ((int)(((byte)(69)))));
            this.btnResetSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnResetSettings.Image = global::WinFormsApp2.Properties.Resources.btn_reset;
            this.btnResetSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnResetSettings.Location = new System.Drawing.Point(210, 384);
            this.btnResetSettings.Size = new System.Drawing.Size(170, 44);
            this.btnResetSettings.Text = "Reset Settings";
            this.btnResetSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnResetSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetSettings.UseVisualStyleBackColor = false;
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.TabIndex = 6;
            this.btnResetSettings.Click += new System.EventHandler(this.btnResetSettings_Click);
            // 
            // lblSaveStatus
            // 
            this.lblSaveStatus.AutoSize = true;
            this.lblSaveStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblSaveStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaveStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(230)))), ((int)(((byte)(168)))));
            this.lblSaveStatus.Location = new System.Drawing.Point(400, 396);
            this.lblSaveStatus.Size = new System.Drawing.Size(6, 23);
            this.lblSaveStatus.Text = "";
            this.lblSaveStatus.UseMnemonic = false;
            this.lblSaveStatus.Name = "lblSaveStatus";
            this.lblSaveStatus.TabIndex = 7;
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.pnlTitleIcon);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.pnlLightingSettings);
            this.Controls.Add(this.pnlGeneralSettings);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.btnResetSettings);
            this.Controls.Add(this.lblSaveStatus);
            this.Size = new System.Drawing.Size(1170, 750);
            this.Name = "SettingsUserControl";
            ((System.ComponentModel.ISupportInitialize)(this.trackDefaultBrightness)).EndInit();
            this.pnlTitleIcon.ResumeLayout(false);
            this.pnlTitleIcon.PerformLayout();
            this.pnlLightingSettings.ResumeLayout(false);
            this.pnlLightingSettings.PerformLayout();
            this.pnlGeneralSettings.ResumeLayout(false);
            this.pnlGeneralSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinFormsApp2.Controls.RoundedPanel pnlTitleIcon;
        private System.Windows.Forms.Label lblTitleIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private WinFormsApp2.Controls.RoundedPanel pnlLightingSettings;
        private System.Windows.Forms.Label lblLightingSettingsIcon;
        private System.Windows.Forms.Label lblLightingSettingsTitle;
        private System.Windows.Forms.Label lblDefaultBrightness;
        private System.Windows.Forms.Label lblDefaultBrightnessValue;
        private System.Windows.Forms.TrackBar trackDefaultBrightness;
        private System.Windows.Forms.Label lblDefaultBrightnessHint;
        private System.Windows.Forms.CheckBox chkAutoOff;
        private System.Windows.Forms.Label lblAutoOffHint;
        private WinFormsApp2.Controls.RoundedPanel pnlGeneralSettings;
        private System.Windows.Forms.Label lblGeneralSettingsIcon;
        private System.Windows.Forms.Label lblGeneralSettingsTitle;
        private System.Windows.Forms.CheckBox chkNotifications;
        private System.Windows.Forms.Label lblNotificationsHint;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.ComboBox cmbTheme;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnResetSettings;
        private System.Windows.Forms.Label lblSaveStatus;
    }
}
