namespace WinFormsApp2
{
    partial class main
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
            pnlSidebar = new Panel();
            btnlight = new Button();
            btnOpenLogin = new Button();
            btnenergy = new Button();
            btnautomation = new Button();
            pnlContent = new Panel();
            btnsecurity = new Button();
            btnDevices = new Button();
            btnRooms = new Button();
            btnHome = new Button();
            picLogo = new PictureBox();
            lblAppName = new Label();
            pnlHeader = new Panel();
            picProfile = new PictureBox();
            btnNotifications = new Button();
            lblConnection = new Label();
            lblAppSubtitle = new Label();
            pnlMainArea = new Panel();
            pnlProfileMenu = new Panel();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            btnAccountSettings = new Button();
            btnMyProfile = new Button();
            lblUserRole = new Label();
            lblUserName = new Label();
            pnlNotificationsMenu = new Panel();
            btnViewAllNotifications = new Button();
            lblAlertDesc2 = new Label();
            lblAlertDesc1 = new Label();
            lblAlert2 = new Label();
            lblAlert1 = new Label();
            lblNotificationsTitle = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            pnlProfileMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlNotificationsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(16, 20, 49);
            pnlSidebar.Controls.Add(btnlight);
            pnlSidebar.Controls.Add(btnOpenLogin);
            pnlSidebar.Controls.Add(btnenergy);
            pnlSidebar.Controls.Add(btnautomation);
            pnlSidebar.Controls.Add(pnlContent);
            pnlSidebar.Controls.Add(btnsecurity);
            pnlSidebar.Controls.Add(btnDevices);
            pnlSidebar.Controls.Add(btnRooms);
            pnlSidebar.Controls.Add(btnHome);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.ForeColor = Color.White;
            pnlSidebar.Location = new Point(0, 95);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Padding = new Padding(10, 15, 10, 10);
            pnlSidebar.Size = new Size(296, 960);
            pnlSidebar.TabIndex = 0;
            // 
            // btnlight
            // 
            btnlight.FlatAppearance.BorderSize = 0;
            btnlight.FlatStyle = FlatStyle.Flat;
            btnlight.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlight.Location = new Point(44, 499);
            btnlight.Name = "btnlight";
            btnlight.Size = new Size(200, 56);
            btnlight.TabIndex = 9;
            btnlight.Text = "light";
            btnlight.TextAlign = ContentAlignment.MiddleLeft;
            btnlight.UseVisualStyleBackColor = true;
            btnlight.Click += btnlight_Click;
            // 
            // btnOpenLogin
            // 
            btnOpenLogin.BackColor = Color.FromArgb(112, 72, 220);
            btnOpenLogin.FlatStyle = FlatStyle.Flat;
            btnOpenLogin.ForeColor = Color.White;
            btnOpenLogin.Location = new Point(74, 772);
            btnOpenLogin.Name = "btnOpenLogin";
            btnOpenLogin.Size = new Size(120, 40);
            btnOpenLogin.TabIndex = 8;
            btnOpenLogin.Text = "Login";
            btnOpenLogin.UseVisualStyleBackColor = false;
            btnOpenLogin.Click += btnOpenLogin_Click;
            // 
            // btnenergy
            // 
            btnenergy.Cursor = Cursors.Hand;
            btnenergy.FlatAppearance.BorderSize = 0;
            btnenergy.FlatStyle = FlatStyle.Flat;
            btnenergy.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnenergy.Location = new Point(44, 427);
            btnenergy.Name = "btnenergy";
            btnenergy.Size = new Size(200, 42);
            btnenergy.TabIndex = 7;
            btnenergy.Text = "Energy Management";
            btnenergy.TextAlign = ContentAlignment.MiddleLeft;
            btnenergy.UseVisualStyleBackColor = true;
            btnenergy.Click += btnenergy_Click;
            // 
            // btnautomation
            // 
            btnautomation.AutoSize = true;
            btnautomation.Cursor = Cursors.Hand;
            btnautomation.FlatAppearance.BorderSize = 0;
            btnautomation.FlatStyle = FlatStyle.Flat;
            btnautomation.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnautomation.Location = new Point(44, 357);
            btnautomation.Name = "btnautomation";
            btnautomation.Size = new Size(200, 42);
            btnautomation.TabIndex = 6;
            btnautomation.Text = "Automation";
            btnautomation.TextAlign = ContentAlignment.MiddleLeft;
            btnautomation.UseVisualStyleBackColor = true;
            btnautomation.Click += button5_Click;
            // 
            // pnlContent
            // 
            pnlContent.AutoScroll = true;
            pnlContent.AutoSize = true;
            pnlContent.BackColor = Color.FromArgb(10, 15, 38);
            pnlContent.Location = new Point(302, 6);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1606, 1034);
            pnlContent.TabIndex = 1;
            // 
            // btnsecurity
            // 
            btnsecurity.Cursor = Cursors.Hand;
            btnsecurity.FlatAppearance.BorderSize = 0;
            btnsecurity.FlatStyle = FlatStyle.Flat;
            btnsecurity.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsecurity.Location = new Point(44, 287);
            btnsecurity.Name = "btnsecurity";
            btnsecurity.Size = new Size(200, 42);
            btnsecurity.TabIndex = 5;
            btnsecurity.Text = "Security Center";
            btnsecurity.TextAlign = ContentAlignment.MiddleLeft;
            btnsecurity.UseVisualStyleBackColor = true;
            btnsecurity.Click += btnsecurity_Click;
            // 
            // btnDevices
            // 
            btnDevices.Cursor = Cursors.Hand;
            btnDevices.FlatAppearance.BorderSize = 0;
            btnDevices.FlatStyle = FlatStyle.Flat;
            btnDevices.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDevices.Location = new Point(44, 217);
            btnDevices.Name = "btnDevices";
            btnDevices.Size = new Size(200, 42);
            btnDevices.TabIndex = 4;
            btnDevices.Text = "Devices";
            btnDevices.TextAlign = ContentAlignment.MiddleLeft;
            btnDevices.UseVisualStyleBackColor = true;
            btnDevices.Click += btnDevices_Click;
            // 
            // btnRooms
            // 
            btnRooms.Cursor = Cursors.Hand;
            btnRooms.FlatAppearance.BorderSize = 0;
            btnRooms.FlatStyle = FlatStyle.Flat;
            btnRooms.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRooms.Location = new Point(44, 147);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(200, 42);
            btnRooms.TabIndex = 3;
            btnRooms.Text = "Rooms";
            btnRooms.TextAlign = ContentAlignment.MiddleLeft;
            btnRooms.UseVisualStyleBackColor = true;
            btnRooms.Click += btnRooms_Click;
            // 
            // btnHome
            // 
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(44, 77);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(200, 42);
            btnHome.TabIndex = 2;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImage = Properties.Resources.house_regular__1_;
            picLogo.ErrorImage = Properties.Resources.house_regular__1_1;
            picLogo.Image = Properties.Resources.house_regular__1_;
            picLogo.Location = new Point(39, 24);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(45, 52);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = Color.Transparent;
            lblAppName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(90, 24);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(144, 31);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "SmartHome";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(34, 36, 82);
            pnlHeader.Controls.Add(picProfile);
            pnlHeader.Controls.Add(btnNotifications);
            pnlHeader.Controls.Add(lblConnection);
            pnlHeader.Controls.Add(lblAppSubtitle);
            pnlHeader.Controls.Add(picLogo);
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(15, 0, 15, 0);
            pnlHeader.Size = new Size(1765, 95);
            pnlHeader.TabIndex = 0;
            // 
            // picProfile
            // 
            picProfile.Image = Properties.Resources.user_solid;
            picProfile.Location = new Point(1690, 33);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(35, 35);
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picProfile.TabIndex = 5;
            picProfile.TabStop = false;
            picProfile.Click += picProfile_Click;
            // 
            // btnNotifications
            // 
            btnNotifications.FlatAppearance.BorderSize = 0;
            btnNotifications.FlatStyle = FlatStyle.Flat;
            btnNotifications.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNotifications.ForeColor = Color.Yellow;
            btnNotifications.Location = new Point(1627, 37);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(69, 31);
            btnNotifications.TabIndex = 4;
            btnNotifications.Text = "🔔";
            btnNotifications.UseVisualStyleBackColor = true;
            btnNotifications.Click += btnNotifications_Click;
            // 
            // lblConnection
            // 
            lblConnection.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblConnection.AutoSize = true;
            lblConnection.BackColor = Color.Transparent;
            lblConnection.ForeColor = Color.FromArgb(128, 255, 128);
            lblConnection.Location = new Point(1330, 48);
            lblConnection.Name = "lblConnection";
            lblConnection.Size = new Size(93, 20);
            lblConnection.TabIndex = 3;
            lblConnection.Text = "● Connected";
            // 
            // lblAppSubtitle
            // 
            lblAppSubtitle.AutoSize = true;
            lblAppSubtitle.BackColor = Color.Transparent;
            lblAppSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppSubtitle.ForeColor = Color.FromArgb(185, 185, 220);
            lblAppSubtitle.Location = new Point(96, 55);
            lblAppSubtitle.Name = "lblAppSubtitle";
            lblAppSubtitle.Size = new Size(148, 20);
            lblAppSubtitle.TabIndex = 2;
            lblAppSubtitle.Text = "Student Smart Home";
            // 
            // pnlMainArea
            // 
            pnlMainArea.AutoScroll = true;
            pnlMainArea.Dock = DockStyle.Fill;
            pnlMainArea.Location = new Point(296, 95);
            pnlMainArea.Name = "pnlMainArea";
            pnlMainArea.Size = new Size(1469, 960);
            pnlMainArea.TabIndex = 1;
            // 
            // pnlProfileMenu
            // 
            pnlProfileMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlProfileMenu.BackColor = Color.FromArgb(37, 42, 80);
            pnlProfileMenu.BorderStyle = BorderStyle.FixedSingle;
            pnlProfileMenu.Controls.Add(pictureBox1);
            pnlProfileMenu.Controls.Add(btnLogout);
            pnlProfileMenu.Controls.Add(btnAccountSettings);
            pnlProfileMenu.Controls.Add(btnMyProfile);
            pnlProfileMenu.Controls.Add(lblUserRole);
            pnlProfileMenu.Controls.Add(lblUserName);
            pnlProfileMenu.ForeColor = Color.White;
            pnlProfileMenu.Location = new Point(0, 0);
            pnlProfileMenu.Name = "pnlProfileMenu";
            pnlProfileMenu.Size = new Size(250, 220);
            pnlProfileMenu.TabIndex = 6;
            pnlProfileMenu.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_solid;
            pictureBox1.Location = new Point(10, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.IndianRed;
            btnLogout.Location = new Point(10, 165);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(225, 35);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Log Out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAccountSettings
            // 
            btnAccountSettings.FlatAppearance.BorderSize = 0;
            btnAccountSettings.FlatStyle = FlatStyle.Flat;
            btnAccountSettings.Location = new Point(10, 115);
            btnAccountSettings.Name = "btnAccountSettings";
            btnAccountSettings.Size = new Size(225, 35);
            btnAccountSettings.TabIndex = 3;
            btnAccountSettings.Text = "Account Settings";
            btnAccountSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnAccountSettings.UseVisualStyleBackColor = true;
            btnAccountSettings.Click += btnAccountSettings_Click;
            // 
            // btnMyProfile
            // 
            btnMyProfile.FlatAppearance.BorderSize = 0;
            btnMyProfile.FlatStyle = FlatStyle.Flat;
            btnMyProfile.Location = new Point(10, 75);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Size = new Size(225, 35);
            btnMyProfile.TabIndex = 2;
            btnMyProfile.Text = "My Profile";
            btnMyProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnMyProfile.UseVisualStyleBackColor = true;
            btnMyProfile.Click += btnMyProfile_Click;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Location = new Point(55, 38);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(140, 20);
            lblUserRole.TabIndex = 1;
            lblUserRole.Text = "Smart Home Owner";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(55, 15);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(93, 20);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Student User";
            // 
            // pnlNotificationsMenu
            // 
            pnlNotificationsMenu.BackColor = Color.FromArgb(32, 38, 77);
            pnlNotificationsMenu.BorderStyle = BorderStyle.FixedSingle;
            pnlNotificationsMenu.Controls.Add(btnViewAllNotifications);
            pnlNotificationsMenu.Controls.Add(lblAlertDesc2);
            pnlNotificationsMenu.Controls.Add(lblAlertDesc1);
            pnlNotificationsMenu.Controls.Add(lblAlert2);
            pnlNotificationsMenu.Controls.Add(lblAlert1);
            pnlNotificationsMenu.Controls.Add(lblNotificationsTitle);
            pnlNotificationsMenu.Controls.Add(panel1);
            pnlNotificationsMenu.Controls.Add(panel2);
            pnlNotificationsMenu.ForeColor = Color.White;
            pnlNotificationsMenu.Location = new Point(258, 115);
            pnlNotificationsMenu.Name = "pnlNotificationsMenu";
            pnlNotificationsMenu.Size = new Size(330, 320);
            pnlNotificationsMenu.TabIndex = 0;
            pnlNotificationsMenu.Visible = false;
            // 
            // btnViewAllNotifications
            // 
            btnViewAllNotifications.BackColor = Color.FromArgb(112, 72, 220);
            btnViewAllNotifications.FlatAppearance.BorderSize = 0;
            btnViewAllNotifications.FlatStyle = FlatStyle.Flat;
            btnViewAllNotifications.Location = new Point(15, 255);
            btnViewAllNotifications.Name = "btnViewAllNotifications";
            btnViewAllNotifications.Size = new Size(300, 40);
            btnViewAllNotifications.TabIndex = 5;
            btnViewAllNotifications.Text = "View All Notifications";
            btnViewAllNotifications.UseVisualStyleBackColor = false;
            btnViewAllNotifications.Click += btnViewAllNotifications_Click;
            // 
            // lblAlertDesc2
            // 
            lblAlertDesc2.AutoSize = true;
            lblAlertDesc2.Location = new Point(15, 165);
            lblAlertDesc2.Name = "lblAlertDesc2";
            lblAlertDesc2.Size = new Size(192, 20);
            lblAlertDesc2.TabIndex = 4;
            lblAlertDesc2.Text = "Morning routine completed";
            // 
            // lblAlertDesc1
            // 
            lblAlertDesc1.AutoSize = true;
            lblAlertDesc1.Location = new Point(15, 85);
            lblAlertDesc1.Name = "lblAlertDesc1";
            lblAlertDesc1.Size = new Size(209, 20);
            lblAlertDesc1.TabIndex = 3;
            lblAlertDesc1.Text = "Motion detected at front door";
            // 
            // lblAlert2
            // 
            lblAlert2.AutoSize = true;
            lblAlert2.Location = new Point(15, 140);
            lblAlert2.Name = "lblAlert2";
            lblAlert2.Size = new Size(166, 20);
            lblAlert2.TabIndex = 2;
            lblAlert2.Text = "Automation Completed";
            // 
            // lblAlert1
            // 
            lblAlert1.AutoSize = true;
            lblAlert1.Location = new Point(15, 60);
            lblAlert1.Name = "lblAlert1";
            lblAlert1.Size = new Size(97, 20);
            lblAlert1.TabIndex = 1;
            lblAlert1.Text = "Security Alert";
            // 
            // lblNotificationsTitle
            // 
            lblNotificationsTitle.AutoSize = true;
            lblNotificationsTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotificationsTitle.Location = new Point(15, 15);
            lblNotificationsTitle.Name = "lblNotificationsTitle";
            lblNotificationsTitle.Size = new Size(122, 25);
            lblNotificationsTitle.TabIndex = 0;
            lblNotificationsTitle.Text = "Notifications";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(3, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 62);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(3, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 76);
            panel2.TabIndex = 7;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 15, 38);
            ClientSize = new Size(1765, 1055);
            Controls.Add(pnlNotificationsMenu);
            Controls.Add(pnlProfileMenu);
            Controls.Add(pnlMainArea);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Name = "main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SmartHome";
            WindowState = FormWindowState.Maximized;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            pnlProfileMenu.ResumeLayout(false);
            pnlProfileMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlNotificationsMenu.ResumeLayout(false);
            pnlNotificationsMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlContent;
        private Button btnenergy;
        private Button btnautomation;
        private Button btnsecurity;
        private Button btnDevices;
        private Button btnRooms;
        private Button btnHome;
        private PictureBox picLogo;
        private Label lblAppName;
        private Panel pnlHeader;
        private Label lblAppSubtitle;
        private PictureBox picProfile;
        private Button btnNotifications;
        private Label lblConnection;
        private Panel pnlMainArea;
        private Panel pnlProfileMenu;
        private Label lblUserRole;
        private Label lblUserName;
        private Button btnLogout;
        private Button btnAccountSettings;
        private Button btnMyProfile;
        private PictureBox pictureBox1;
        private Button btnOpenLogin;
        private Panel pnlNotificationsMenu;
        private Button btnViewAllNotifications;
        private Label lblAlertDesc2;
        private Label lblAlertDesc1;
        private Label lblAlert2;
        private Label lblAlert1;
        private Label lblNotificationsTitle;
        private Panel panel1;
        private Panel panel2;
        private Button btnlight;
    }
}
