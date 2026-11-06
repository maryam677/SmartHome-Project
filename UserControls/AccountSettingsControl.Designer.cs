namespace WinFormsApp2.UserControls
{
    partial class AccountSettingsControl
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
            lblSettingsTitle = new Label();
            lblSettingsSubtitle = new Label();
            pnlPersonalSettings = new Panel();
            btnEditInformation = new Button();
            txtEmail = new TextBox();
            txtName = new TextBox();
            lblEmail = new Label();
            lblName = new Label();
            lblPersonalTitle = new Label();
            pnlNotificationSettings = new Panel();
            lblNotificationTitle = new Label();
            chkDeviceNotifications = new CheckBox();
            chkAutomationUpdates = new CheckBox();
            chkSecurityAlerts = new CheckBox();
            pnlSecuritySettings = new Panel();
            chk2FA = new CheckBox();
            btnChangePassword = new Button();
            lbl2FA = new Label();
            lblPasswordDesc = new Label();
            lblPassword = new Label();
            lblSecurityTitle = new Label();
            pnlAppearanceSettings = new Panel();
            cmbLanguage = new ComboBox();
            cmbTheme = new ComboBox();
            lblLanguage = new Label();
            lblTheme = new Label();
            lblAppearanceTitle = new Label();
            pnlPersonalSettings.SuspendLayout();
            pnlNotificationSettings.SuspendLayout();
            pnlSecuritySettings.SuspendLayout();
            pnlAppearanceSettings.SuspendLayout();
            SuspendLayout();
            // 
            // lblSettingsTitle
            // 
            lblSettingsTitle.AutoSize = true;
            lblSettingsTitle.ForeColor = Color.LightGray;
            lblSettingsTitle.Location = new Point(25, 66);
            lblSettingsTitle.Name = "lblSettingsTitle";
            lblSettingsTitle.Size = new Size(120, 20);
            lblSettingsTitle.TabIndex = 0;
            lblSettingsTitle.Text = "Account Settings";
            // 
            // lblSettingsSubtitle
            // 
            lblSettingsSubtitle.AutoSize = true;
            lblSettingsSubtitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSettingsSubtitle.Location = new Point(25, 20);
            lblSettingsSubtitle.Name = "lblSettingsSubtitle";
            lblSettingsSubtitle.Size = new Size(774, 46);
            lblSettingsSubtitle.TabIndex = 1;
            lblSettingsSubtitle.Text = "Manage your account, security and preferences";
            // 
            // pnlPersonalSettings
            // 
            pnlPersonalSettings.BackColor = Color.FromArgb(32, 38, 77);
            pnlPersonalSettings.Controls.Add(btnEditInformation);
            pnlPersonalSettings.Controls.Add(txtEmail);
            pnlPersonalSettings.Controls.Add(txtName);
            pnlPersonalSettings.Controls.Add(lblEmail);
            pnlPersonalSettings.Controls.Add(lblName);
            pnlPersonalSettings.Controls.Add(lblPersonalTitle);
            pnlPersonalSettings.Location = new Point(25, 110);
            pnlPersonalSettings.Name = "pnlPersonalSettings";
            pnlPersonalSettings.Size = new Size(1025, 170);
            pnlPersonalSettings.TabIndex = 2;
            // 
            // btnEditInformation
            // 
            btnEditInformation.FlatStyle = FlatStyle.Flat;
            btnEditInformation.Location = new Point(850, 130);
            btnEditInformation.Name = "btnEditInformation";
            btnEditInformation.Size = new Size(150, 30);
            btnEditInformation.TabIndex = 5;
            btnEditInformation.Text = "Edit Information";
            btnEditInformation.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(520, 80);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(440, 27);
            txtEmail.TabIndex = 4;
            txtEmail.Text = "student@smarthome.com";
            // 
            // txtName
            // 
            txtName.Location = new Point(20, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(440, 27);
            txtName.TabIndex = 3;
            txtName.Text = "Student User";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(520, 55);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(103, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email Address";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 55);
            lblName.Name = "lblName";
            lblName.Size = new Size(76, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Full Name";
            // 
            // lblPersonalTitle
            // 
            lblPersonalTitle.AutoSize = true;
            lblPersonalTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersonalTitle.Location = new Point(20, 15);
            lblPersonalTitle.Name = "lblPersonalTitle";
            lblPersonalTitle.Size = new Size(211, 28);
            lblPersonalTitle.TabIndex = 0;
            lblPersonalTitle.Text = "Personal Information";
            // 
            // pnlNotificationSettings
            // 
            pnlNotificationSettings.BackColor = Color.FromArgb(32, 38, 77);
            pnlNotificationSettings.Controls.Add(lblNotificationTitle);
            pnlNotificationSettings.Controls.Add(chkDeviceNotifications);
            pnlNotificationSettings.Controls.Add(chkAutomationUpdates);
            pnlNotificationSettings.Controls.Add(chkSecurityAlerts);
            pnlNotificationSettings.Location = new Point(25, 490);
            pnlNotificationSettings.Name = "pnlNotificationSettings";
            pnlNotificationSettings.Size = new Size(1025, 170);
            pnlNotificationSettings.TabIndex = 3;
            // 
            // lblNotificationTitle
            // 
            lblNotificationTitle.AutoSize = true;
            lblNotificationTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotificationTitle.Location = new Point(20, 15);
            lblNotificationTitle.Name = "lblNotificationTitle";
            lblNotificationTitle.Size = new Size(244, 28);
            lblNotificationTitle.TabIndex = 3;
            lblNotificationTitle.Text = "Notification Preferences";
            // 
            // chkDeviceNotifications
            // 
            chkDeviceNotifications.AutoSize = true;
            chkDeviceNotifications.Location = new Point(20, 90);
            chkDeviceNotifications.Name = "chkDeviceNotifications";
            chkDeviceNotifications.Size = new Size(165, 24);
            chkDeviceNotifications.TabIndex = 2;
            chkDeviceNotifications.Text = "Device Notifications";
            chkDeviceNotifications.UseVisualStyleBackColor = true;
            // 
            // chkAutomationUpdates
            // 
            chkAutomationUpdates.AutoSize = true;
            chkAutomationUpdates.Location = new Point(20, 125);
            chkAutomationUpdates.Name = "chkAutomationUpdates";
            chkAutomationUpdates.Size = new Size(169, 24);
            chkAutomationUpdates.TabIndex = 1;
            chkAutomationUpdates.Text = "Automation Updates";
            chkAutomationUpdates.UseVisualStyleBackColor = true;
            // 
            // chkSecurityAlerts
            // 
            chkSecurityAlerts.AutoSize = true;
            chkSecurityAlerts.Location = new Point(20, 55);
            chkSecurityAlerts.Name = "chkSecurityAlerts";
            chkSecurityAlerts.Size = new Size(125, 24);
            chkSecurityAlerts.TabIndex = 0;
            chkSecurityAlerts.Text = "Security Alerts";
            chkSecurityAlerts.UseVisualStyleBackColor = true;
            // 
            // pnlSecuritySettings
            // 
            pnlSecuritySettings.BackColor = Color.FromArgb(32, 38, 77);
            pnlSecuritySettings.Controls.Add(chk2FA);
            pnlSecuritySettings.Controls.Add(btnChangePassword);
            pnlSecuritySettings.Controls.Add(lbl2FA);
            pnlSecuritySettings.Controls.Add(lblPasswordDesc);
            pnlSecuritySettings.Controls.Add(lblPassword);
            pnlSecuritySettings.Controls.Add(lblSecurityTitle);
            pnlSecuritySettings.Location = new Point(25, 300);
            pnlSecuritySettings.Name = "pnlSecuritySettings";
            pnlSecuritySettings.Size = new Size(1025, 170);
            pnlSecuritySettings.TabIndex = 4;
            // 
            // chk2FA
            // 
            chk2FA.AutoSize = true;
            chk2FA.Location = new Point(850, 125);
            chk2FA.Name = "chk2FA";
            chk2FA.Size = new Size(76, 24);
            chk2FA.TabIndex = 5;
            chk2FA.Text = "Enable";
            chk2FA.UseVisualStyleBackColor = true;
            // 
            // btnChangePassword
            // 
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Location = new Point(737, 55);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(187, 29);
            btnChangePassword.TabIndex = 4;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // lbl2FA
            // 
            lbl2FA.AutoSize = true;
            lbl2FA.Location = new Point(20, 125);
            lbl2FA.Name = "lbl2FA";
            lbl2FA.Size = new Size(183, 20);
            lbl2FA.TabIndex = 3;
            lbl2FA.Text = "Two-Factor Authentication";
            // 
            // lblPasswordDesc
            // 
            lblPasswordDesc.AutoSize = true;
            lblPasswordDesc.Location = new Point(20, 80);
            lblPasswordDesc.Name = "lblPasswordDesc";
            lblPasswordDesc.Size = new Size(214, 20);
            lblPasswordDesc.TabIndex = 2;
            lblPasswordDesc.Text = "Update your account password";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(20, 55);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblSecurityTitle
            // 
            lblSecurityTitle.AutoSize = true;
            lblSecurityTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSecurityTitle.Location = new Point(20, 15);
            lblSecurityTitle.Name = "lblSecurityTitle";
            lblSecurityTitle.Size = new Size(89, 28);
            lblSecurityTitle.TabIndex = 0;
            lblSecurityTitle.Text = "Security";
            // 
            // pnlAppearanceSettings
            // 
            pnlAppearanceSettings.BackColor = Color.FromArgb(32, 38, 77);
            pnlAppearanceSettings.Controls.Add(cmbLanguage);
            pnlAppearanceSettings.Controls.Add(cmbTheme);
            pnlAppearanceSettings.Controls.Add(lblLanguage);
            pnlAppearanceSettings.Controls.Add(lblTheme);
            pnlAppearanceSettings.Controls.Add(lblAppearanceTitle);
            pnlAppearanceSettings.Location = new Point(25, 680);
            pnlAppearanceSettings.Name = "pnlAppearanceSettings";
            pnlAppearanceSettings.Size = new Size(1025, 170);
            pnlAppearanceSettings.TabIndex = 5;
            // 
            // cmbLanguage
            // 
            cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Items.AddRange(new object[] { "English ", "Arabic" });
            cmbLanguage.Location = new Point(520, 80);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(151, 28);
            cmbLanguage.TabIndex = 4;
            // 
            // cmbTheme
            // 
            cmbTheme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTheme.FormattingEnabled = true;
            cmbTheme.Items.AddRange(new object[] { "System Default", "Dark ", "Light" });
            cmbTheme.Location = new Point(20, 80);
            cmbTheme.Name = "cmbTheme";
            cmbTheme.Size = new Size(151, 28);
            cmbTheme.TabIndex = 3;
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Location = new Point(520, 55);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(74, 20);
            lblLanguage.TabIndex = 2;
            lblLanguage.Text = "Language";
            // 
            // lblTheme
            // 
            lblTheme.AutoSize = true;
            lblTheme.Location = new Point(20, 55);
            lblTheme.Name = "lblTheme";
            lblTheme.Size = new Size(54, 20);
            lblTheme.TabIndex = 1;
            lblTheme.Text = "Theme";
            // 
            // lblAppearanceTitle
            // 
            lblAppearanceTitle.AutoSize = true;
            lblAppearanceTitle.Location = new Point(20, 15);
            lblAppearanceTitle.Name = "lblAppearanceTitle";
            lblAppearanceTitle.Size = new Size(173, 20);
            lblAppearanceTitle.TabIndex = 0;
            lblAppearanceTitle.Text = "Appearance & Preferences";
            // 
            // AccountSettingsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 15, 38);
            Controls.Add(pnlAppearanceSettings);
            Controls.Add(pnlSecuritySettings);
            Controls.Add(pnlNotificationSettings);
            Controls.Add(pnlPersonalSettings);
            Controls.Add(lblSettingsSubtitle);
            Controls.Add(lblSettingsTitle);
            ForeColor = Color.White;
            Name = "AccountSettingsControl";
            Size = new Size(1100, 900);
            pnlPersonalSettings.ResumeLayout(false);
            pnlPersonalSettings.PerformLayout();
            pnlNotificationSettings.ResumeLayout(false);
            pnlNotificationSettings.PerformLayout();
            pnlSecuritySettings.ResumeLayout(false);
            pnlSecuritySettings.PerformLayout();
            pnlAppearanceSettings.ResumeLayout(false);
            pnlAppearanceSettings.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSettingsTitle;
        private Label lblSettingsSubtitle;
        private Panel pnlPersonalSettings;
        private Panel pnlNotificationSettings;
        private Panel pnlSecuritySettings;
        private Panel pnlAppearanceSettings;
        private Button btnEditInformation;
        private TextBox txtEmail;
        private TextBox txtName;
        private Label lblEmail;
        private Label lblName;
        private Label lblPersonalTitle;
        private Label lblNotificationTitle;
        private CheckBox chkDeviceNotifications;
        private CheckBox chkAutomationUpdates;
        private CheckBox chkSecurityAlerts;
        private CheckBox chk2FA;
        private Button btnChangePassword;
        private Label lbl2FA;
        private Label lblPasswordDesc;
        private Label lblPassword;
        private Label lblSecurityTitle;
        private ComboBox cmbLanguage;
        private ComboBox cmbTheme;
        private Label lblLanguage;
        private Label lblTheme;
        private Label lblAppearanceTitle;
    }
}
