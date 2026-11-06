namespace WinFormsApp2.UserControls
{
    partial class ProfileControl
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
            lblProfileTitle = new Label();
            lblProfileSubtitle = new Label();
            btnEditProfile = new Button();
            pnlProfileInfo = new Panel();
            lblUserRole = new Label();
            lblEmail = new Label();
            lblUserName = new Label();
            picAvatar = new PictureBox();
            pnlDevicesStat = new Panel();
            lblDevicesText = new Label();
            lblDevicesCount = new Label();
            pnlRoomsStat = new Panel();
            lblroomstext = new Label();
            lblroomscount = new Label();
            pnlRoutinesStat = new Panel();
            lblactiveroutinestext = new Label();
            lblactiveroutinescount = new Label();
            pnlPersonalInfo = new Panel();
            lblRoleValue = new Label();
            lblRoleTitle = new Label();
            lblPhoneValue = new Label();
            lblPhoneTitle = new Label();
            lblEmailValue = new Label();
            lblEmailTitle = new Label();
            lblFullNameValue = new Label();
            lblFullNameTitle = new Label();
            lblPersonalTitle = new Label();
            pnlProfileInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            pnlDevicesStat.SuspendLayout();
            pnlRoomsStat.SuspendLayout();
            pnlRoutinesStat.SuspendLayout();
            pnlPersonalInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblProfileTitle
            // 
            lblProfileTitle.AutoSize = true;
            lblProfileTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfileTitle.Location = new Point(25, 20);
            lblProfileTitle.Name = "lblProfileTitle";
            lblProfileTitle.Size = new Size(186, 46);
            lblProfileTitle.TabIndex = 0;
            lblProfileTitle.Text = "My Profile";
            // 
            // lblProfileSubtitle
            // 
            lblProfileSubtitle.AutoSize = true;
            lblProfileSubtitle.ForeColor = Color.LightGray;
            lblProfileSubtitle.Location = new Point(25, 60);
            lblProfileSubtitle.Name = "lblProfileSubtitle";
            lblProfileSubtitle.Size = new Size(407, 20);
            lblProfileSubtitle.TabIndex = 1;
            lblProfileSubtitle.Text = "Manage your personal information and smart home account";
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = Color.FromArgb(112, 72, 220);
            btnEditProfile.Cursor = Cursors.Hand;
            btnEditProfile.FlatAppearance.BorderSize = 0;
            btnEditProfile.FlatStyle = FlatStyle.Flat;
            btnEditProfile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditProfile.Location = new Point(976, 20);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(150, 38);
            btnEditProfile.TabIndex = 2;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = false;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // pnlProfileInfo
            // 
            pnlProfileInfo.Controls.Add(lblUserRole);
            pnlProfileInfo.Controls.Add(lblEmail);
            pnlProfileInfo.Controls.Add(lblUserName);
            pnlProfileInfo.Controls.Add(picAvatar);
            pnlProfileInfo.Location = new Point(25, 110);
            pnlProfileInfo.Name = "pnlProfileInfo";
            pnlProfileInfo.Size = new Size(1025, 150);
            pnlProfileInfo.TabIndex = 3;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Location = new Point(115, 95);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(110, 20);
            lblUserRole.TabIndex = 3;
            lblUserRole.Text = "● Home Owner";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(115, 65);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(179, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "student@smarthome.com";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(115, 30);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(93, 20);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Student User";
            // 
            // picAvatar
            // 
            picAvatar.BackgroundImage = Properties.Resources.user_solid;
            picAvatar.Image = Properties.Resources.user_solid;
            picAvatar.Location = new Point(20, 25);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(80, 80);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            // 
            // pnlDevicesStat
            // 
            pnlDevicesStat.BackColor = Color.FromArgb(36, 43, 86);
            pnlDevicesStat.Controls.Add(lblDevicesText);
            pnlDevicesStat.Controls.Add(lblDevicesCount);
            pnlDevicesStat.Location = new Point(25, 290);
            pnlDevicesStat.Name = "pnlDevicesStat";
            pnlDevicesStat.Size = new Size(325, 110);
            pnlDevicesStat.TabIndex = 4;
            // 
            // lblDevicesText
            // 
            lblDevicesText.AutoSize = true;
            lblDevicesText.ForeColor = Color.FromArgb(185, 190, 220);
            lblDevicesText.Location = new Point(95, 70);
            lblDevicesText.Name = "lblDevicesText";
            lblDevicesText.Size = new Size(135, 20);
            lblDevicesText.TabIndex = 1;
            lblDevicesText.Text = "Connected Devices";
            // 
            // lblDevicesCount
            // 
            lblDevicesCount.AutoSize = true;
            lblDevicesCount.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDevicesCount.Location = new Point(140, 20);
            lblDevicesCount.Name = "lblDevicesCount";
            lblDevicesCount.Size = new Size(43, 50);
            lblDevicesCount.TabIndex = 0;
            lblDevicesCount.Text = "8";
            // 
            // pnlRoomsStat
            // 
            pnlRoomsStat.BackColor = Color.FromArgb(36, 43, 86);
            pnlRoomsStat.Controls.Add(lblroomstext);
            pnlRoomsStat.Controls.Add(lblroomscount);
            pnlRoomsStat.Location = new Point(397, 290);
            pnlRoomsStat.Name = "pnlRoomsStat";
            pnlRoomsStat.Size = new Size(325, 110);
            pnlRoomsStat.TabIndex = 5;
            // 
            // lblroomstext
            // 
            lblroomstext.AutoSize = true;
            lblroomstext.ForeColor = Color.FromArgb(185, 190, 220);
            lblroomstext.Location = new Point(128, 70);
            lblroomstext.Name = "lblroomstext";
            lblroomstext.Size = new Size(55, 20);
            lblroomstext.TabIndex = 1;
            lblroomstext.Text = "Rooms";
            // 
            // lblroomscount
            // 
            lblroomscount.AutoSize = true;
            lblroomscount.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblroomscount.Location = new Point(140, 20);
            lblroomscount.Name = "lblroomscount";
            lblroomscount.Size = new Size(43, 50);
            lblroomscount.TabIndex = 0;
            lblroomscount.Text = "4";
            // 
            // pnlRoutinesStat
            // 
            pnlRoutinesStat.BackColor = Color.FromArgb(36, 43, 86);
            pnlRoutinesStat.Controls.Add(lblactiveroutinestext);
            pnlRoutinesStat.Controls.Add(lblactiveroutinescount);
            pnlRoutinesStat.Location = new Point(769, 290);
            pnlRoutinesStat.Name = "pnlRoutinesStat";
            pnlRoutinesStat.Size = new Size(325, 110);
            pnlRoutinesStat.TabIndex = 6;
            // 
            // lblactiveroutinestext
            // 
            lblactiveroutinestext.AutoSize = true;
            lblactiveroutinestext.ForeColor = Color.FromArgb(185, 190, 220);
            lblactiveroutinestext.Location = new Point(95, 70);
            lblactiveroutinestext.Name = "lblactiveroutinestext";
            lblactiveroutinestext.Size = new Size(111, 20);
            lblactiveroutinestext.TabIndex = 1;
            lblactiveroutinestext.Text = "Active Routines";
            // 
            // lblactiveroutinescount
            // 
            lblactiveroutinescount.AutoSize = true;
            lblactiveroutinescount.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblactiveroutinescount.Location = new Point(140, 20);
            lblactiveroutinescount.Name = "lblactiveroutinescount";
            lblactiveroutinescount.Size = new Size(43, 50);
            lblactiveroutinescount.TabIndex = 0;
            lblactiveroutinescount.Text = "5";
            // 
            // pnlPersonalInfo
            // 
            pnlPersonalInfo.BackColor = Color.FromArgb(32, 38, 77);
            pnlPersonalInfo.Controls.Add(lblRoleValue);
            pnlPersonalInfo.Controls.Add(lblRoleTitle);
            pnlPersonalInfo.Controls.Add(lblPhoneValue);
            pnlPersonalInfo.Controls.Add(lblPhoneTitle);
            pnlPersonalInfo.Controls.Add(lblEmailValue);
            pnlPersonalInfo.Controls.Add(lblEmailTitle);
            pnlPersonalInfo.Controls.Add(lblFullNameValue);
            pnlPersonalInfo.Controls.Add(lblFullNameTitle);
            pnlPersonalInfo.Controls.Add(lblPersonalTitle);
            pnlPersonalInfo.Location = new Point(25, 430);
            pnlPersonalInfo.Name = "pnlPersonalInfo";
            pnlPersonalInfo.Size = new Size(1070, 240);
            pnlPersonalInfo.TabIndex = 7;
            // 
            // lblRoleValue
            // 
            lblRoleValue.AutoSize = true;
            lblRoleValue.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoleValue.Location = new Point(520, 165);
            lblRoleValue.Name = "lblRoleValue";
            lblRoleValue.Size = new Size(124, 25);
            lblRoleValue.TabIndex = 8;
            lblRoleValue.Text = "Home Owner";
            // 
            // lblRoleTitle
            // 
            lblRoleTitle.AutoSize = true;
            lblRoleTitle.ForeColor = Color.FromArgb(175, 182, 213);
            lblRoleTitle.Location = new Point(520, 140);
            lblRoleTitle.Name = "lblRoleTitle";
            lblRoleTitle.Size = new Size(98, 20);
            lblRoleTitle.TabIndex = 7;
            lblRoleTitle.Text = "Account Type";
            // 
            // lblPhoneValue
            // 
            lblPhoneValue.AutoSize = true;
            lblPhoneValue.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneValue.Location = new Point(25, 165);
            lblPhoneValue.Name = "lblPhoneValue";
            lblPhoneValue.Size = new Size(180, 25);
            lblPhoneValue.TabIndex = 6;
            lblPhoneValue.Text = "+20 XXX XXX XXXX";
            // 
            // lblPhoneTitle
            // 
            lblPhoneTitle.AutoSize = true;
            lblPhoneTitle.ForeColor = Color.FromArgb(175, 182, 213);
            lblPhoneTitle.Location = new Point(25, 140);
            lblPhoneTitle.Name = "lblPhoneTitle";
            lblPhoneTitle.Size = new Size(108, 20);
            lblPhoneTitle.TabIndex = 5;
            lblPhoneTitle.Text = "Phone Number";
            // 
            // lblEmailValue
            // 
            lblEmailValue.AutoSize = true;
            lblEmailValue.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailValue.Location = new Point(520, 90);
            lblEmailValue.Name = "lblEmailValue";
            lblEmailValue.Size = new Size(232, 25);
            lblEmailValue.TabIndex = 4;
            lblEmailValue.Text = "student@smarthome.com";
            // 
            // lblEmailTitle
            // 
            lblEmailTitle.AutoSize = true;
            lblEmailTitle.ForeColor = Color.FromArgb(175, 182, 213);
            lblEmailTitle.Location = new Point(520, 65);
            lblEmailTitle.Name = "lblEmailTitle";
            lblEmailTitle.Size = new Size(103, 20);
            lblEmailTitle.TabIndex = 3;
            lblEmailTitle.Text = "Email Address";
            // 
            // lblFullNameValue
            // 
            lblFullNameValue.AutoSize = true;
            lblFullNameValue.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullNameValue.Location = new Point(25, 90);
            lblFullNameValue.Name = "lblFullNameValue";
            lblFullNameValue.Size = new Size(122, 25);
            lblFullNameValue.TabIndex = 2;
            lblFullNameValue.Text = "Student User";
            // 
            // lblFullNameTitle
            // 
            lblFullNameTitle.AutoSize = true;
            lblFullNameTitle.ForeColor = Color.FromArgb(175, 182, 213);
            lblFullNameTitle.Location = new Point(25, 65);
            lblFullNameTitle.Name = "lblFullNameTitle";
            lblFullNameTitle.Size = new Size(76, 20);
            lblFullNameTitle.TabIndex = 1;
            lblFullNameTitle.Text = "Full Name";
            // 
            // lblPersonalTitle
            // 
            lblPersonalTitle.AutoSize = true;
            lblPersonalTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersonalTitle.Location = new Point(20, 15);
            lblPersonalTitle.Name = "lblPersonalTitle";
            lblPersonalTitle.Size = new Size(241, 31);
            lblPersonalTitle.TabIndex = 0;
            lblPersonalTitle.Text = "Personal Information";
            // 
            // ProfileControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(10, 15, 38);
            Controls.Add(pnlPersonalInfo);
            Controls.Add(pnlRoutinesStat);
            Controls.Add(pnlRoomsStat);
            Controls.Add(pnlDevicesStat);
            Controls.Add(pnlProfileInfo);
            Controls.Add(btnEditProfile);
            Controls.Add(lblProfileSubtitle);
            Controls.Add(lblProfileTitle);
            ForeColor = Color.White;
            Name = "ProfileControl";
            Size = new Size(1225, 754);
            pnlProfileInfo.ResumeLayout(false);
            pnlProfileInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            pnlDevicesStat.ResumeLayout(false);
            pnlDevicesStat.PerformLayout();
            pnlRoomsStat.ResumeLayout(false);
            pnlRoomsStat.PerformLayout();
            pnlRoutinesStat.ResumeLayout(false);
            pnlRoutinesStat.PerformLayout();
            pnlPersonalInfo.ResumeLayout(false);
            pnlPersonalInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProfileTitle;
        private Label lblProfileSubtitle;
        private Button btnEditProfile;
        private Panel pnlProfileInfo;
        private Label lblUserRole;
        private Label lblEmail;
        private Label lblUserName;
        private PictureBox picAvatar;
        private Panel pnlDevicesStat;
        private Panel pnlRoomsStat;
        private Panel pnlRoutinesStat;
        private Label lblDevicesText;
        private Label lblDevicesCount;
        private Label lblroomstext;
        private Label lblroomscount;
        private Label lblactiveroutinestext;
        private Label lblactiveroutinescount;
        private Panel pnlPersonalInfo;
        private Label lblPersonalTitle;
        private Label lblRoleValue;
        private Label lblRoleTitle;
        private Label lblPhoneValue;
        private Label lblPhoneTitle;
        private Label lblEmailValue;
        private Label lblEmailTitle;
        private Label lblFullNameValue;
        private Label lblFullNameTitle;
    }
}
