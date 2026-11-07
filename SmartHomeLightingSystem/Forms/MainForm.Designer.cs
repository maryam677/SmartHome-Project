namespace SmartHomeLightingSystem.Forms
{
    partial class MainForm
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
            pnlContent = new Panel();
            lightingDashboard = new SmartHomeLightingSystem.UserControls.LightingDashboardUserControl();
            roomsPage = new SmartHomeLightingSystem.UserControls.RoomsUserControl();
            overviewPage = new SmartHomeLightingSystem.UserControls.OverviewUserControl();
            settingsPage = new SmartHomeLightingSystem.UserControls.SettingsUserControl();
            securityPage = new SmartHomeLightingSystem.UserControls.SecurityUserControl();
            energyPage = new SmartHomeLightingSystem.UserControls.EnergyUserControl();
            pnlSidebar = new Panel();
            navigationControl = new SmartHomeLightingSystem.UserControls.NavigationUserControl();
            pnlUserProfile = new Panel();
            pnlProfileLine = new Panel();
            pnlAvatar = new SmartHomeLightingSystem.Controls.RoundedPanel();
            lblAvatarIcon = new Label();
            lblUserName = new Label();
            lblUserRole = new Label();
            lblUserMenu = new Label();
            headerControl = new SmartHomeLightingSystem.UserControls.HeaderUserControl();
            pnlContent.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlUserProfile.SuspendLayout();
            pnlAvatar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(9, 8, 23);
            pnlContent.Controls.Add(lightingDashboard);
            pnlContent.Controls.Add(roomsPage);
            pnlContent.Controls.Add(overviewPage);
            pnlContent.Controls.Add(settingsPage);
            pnlContent.Controls.Add(securityPage);
            pnlContent.Controls.Add(energyPage);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(263, 93);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1337, 1000);
            pnlContent.TabIndex = 0;
            // 
            // lightingDashboard
            // 
            lightingDashboard.BackColor = Color.FromArgb(9, 8, 23);
            lightingDashboard.Dock = DockStyle.Fill;
            lightingDashboard.Location = new Point(0, 0);
            lightingDashboard.Margin = new Padding(3, 5, 3, 5);
            lightingDashboard.Name = "lightingDashboard";
            lightingDashboard.Size = new Size(1337, 1000);
            lightingDashboard.TabIndex = 0;
            // 
            // roomsPage
            // 
            roomsPage.BackColor = Color.FromArgb(9, 8, 23);
            roomsPage.Dock = DockStyle.Fill;
            roomsPage.Location = new Point(0, 0);
            roomsPage.Margin = new Padding(3, 5, 3, 5);
            roomsPage.Name = "roomsPage";
            roomsPage.Size = new Size(1337, 1000);
            roomsPage.TabIndex = 1;
            roomsPage.Visible = false;
            // 
            // overviewPage
            // 
            overviewPage.BackColor = Color.FromArgb(9, 8, 23);
            overviewPage.Dock = DockStyle.Fill;
            overviewPage.Location = new Point(0, 0);
            overviewPage.Margin = new Padding(3, 5, 3, 5);
            overviewPage.Name = "overviewPage";
            overviewPage.Size = new Size(1337, 1000);
            overviewPage.TabIndex = 2;
            overviewPage.Visible = false;
            // 
            // settingsPage
            // 
            settingsPage.BackColor = Color.FromArgb(9, 8, 23);
            settingsPage.Dock = DockStyle.Fill;
            settingsPage.Location = new Point(0, 0);
            settingsPage.Margin = new Padding(3, 5, 3, 5);
            settingsPage.Name = "settingsPage";
            settingsPage.Size = new Size(1337, 1000);
            settingsPage.TabIndex = 3;
            settingsPage.Visible = false;
            // 
            // securityPage
            // 
            securityPage.BackColor = Color.FromArgb(9, 8, 23);
            securityPage.Dock = DockStyle.Fill;
            securityPage.Location = new Point(0, 0);
            securityPage.Margin = new Padding(3, 5, 3, 5);
            securityPage.Name = "securityPage";
            securityPage.Size = new Size(1337, 1000);
            securityPage.TabIndex = 4;
            securityPage.Visible = false;
            // 
            // energyPage
            // 
            energyPage.BackColor = Color.FromArgb(9, 8, 23);
            energyPage.Dock = DockStyle.Fill;
            energyPage.Location = new Point(0, 0);
            energyPage.Margin = new Padding(3, 5, 3, 5);
            energyPage.Name = "energyPage";
            energyPage.Size = new Size(1337, 1000);
            energyPage.TabIndex = 5;
            energyPage.Visible = false;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(16, 13, 38);
            pnlSidebar.Controls.Add(navigationControl);
            pnlSidebar.Controls.Add(pnlUserProfile);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 93);
            pnlSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(263, 1000);
            pnlSidebar.TabIndex = 1;
            // 
            // navigationControl
            // 
            navigationControl.BackColor = Color.FromArgb(16, 13, 38);
            navigationControl.Dock = DockStyle.Fill;
            navigationControl.Location = new Point(0, 0);
            navigationControl.Margin = new Padding(3, 5, 3, 5);
            navigationControl.Name = "navigationControl";
            navigationControl.Size = new Size(263, 899);
            navigationControl.TabIndex = 0;
            navigationControl.Load += navigationControl_Load;
            // 
            // pnlUserProfile
            // 
            pnlUserProfile.BackColor = Color.FromArgb(16, 13, 38);
            pnlUserProfile.Controls.Add(pnlProfileLine);
            pnlUserProfile.Controls.Add(pnlAvatar);
            pnlUserProfile.Controls.Add(lblUserName);
            pnlUserProfile.Controls.Add(lblUserRole);
            pnlUserProfile.Controls.Add(lblUserMenu);
            pnlUserProfile.Dock = DockStyle.Bottom;
            pnlUserProfile.Location = new Point(0, 899);
            pnlUserProfile.Margin = new Padding(3, 4, 3, 4);
            pnlUserProfile.Name = "pnlUserProfile";
            pnlUserProfile.Size = new Size(263, 101);
            pnlUserProfile.TabIndex = 1;
            // 
            // pnlProfileLine
            // 
            pnlProfileLine.BackColor = Color.FromArgb(56, 43, 99);
            pnlProfileLine.Dock = DockStyle.Top;
            pnlProfileLine.Location = new Point(0, 0);
            pnlProfileLine.Margin = new Padding(3, 4, 3, 4);
            pnlProfileLine.Name = "pnlProfileLine";
            pnlProfileLine.Size = new Size(263, 1);
            pnlProfileLine.TabIndex = 0;
            // 
            // pnlAvatar
            // 
            pnlAvatar.BackColor = Color.Transparent;
            pnlAvatar.BorderColor = Color.FromArgb(168, 85, 247);
            pnlAvatar.BorderRadius = 22;
            pnlAvatar.BorderThickness = 1F;
            pnlAvatar.Controls.Add(lblAvatarIcon);
            pnlAvatar.FillColor = Color.FromArgb(124, 58, 237);
            pnlAvatar.Location = new Point(21, 21);
            pnlAvatar.Margin = new Padding(3, 4, 3, 4);
            pnlAvatar.Name = "pnlAvatar";
            pnlAvatar.Size = new Size(50, 59);
            pnlAvatar.TabIndex = 1;
            // 
            // lblAvatarIcon
            // 
            lblAvatarIcon.AutoSize = true;
            lblAvatarIcon.BackColor = Color.Transparent;
            lblAvatarIcon.Font = new Font("Segoe MDL2 Assets", 15F);
            lblAvatarIcon.ForeColor = Color.FromArgb(248, 250, 252);
            lblAvatarIcon.Location = new Point(13, 15);
            lblAvatarIcon.Name = "lblAvatarIcon";
            lblAvatarIcon.Size = new Size(37, 25);
            lblAvatarIcon.TabIndex = 0;
            lblAvatarIcon.Text = "";
            lblAvatarIcon.UseMnemonic = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUserName.ForeColor = Color.FromArgb(248, 250, 252);
            lblUserName.Location = new Point(82, 24);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(114, 23);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "Student User";
            lblUserName.UseMnemonic = false;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.BackColor = Color.Transparent;
            lblUserRole.Font = new Font("Segoe UI", 8.5F);
            lblUserRole.ForeColor = Color.FromArgb(165, 161, 194);
            lblUserRole.Location = new Point(83, 53);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(103, 20);
            lblUserRole.TabIndex = 3;
            lblUserRole.Text = "System Owner";
            lblUserRole.UseMnemonic = false;
            // 
            // lblUserMenu
            // 
            lblUserMenu.AutoSize = true;
            lblUserMenu.BackColor = Color.Transparent;
            lblUserMenu.Font = new Font("Segoe MDL2 Assets", 9F);
            lblUserMenu.ForeColor = Color.FromArgb(165, 161, 194);
            lblUserMenu.Location = new Point(226, 40);
            lblUserMenu.Name = "lblUserMenu";
            lblUserMenu.Size = new Size(22, 15);
            lblUserMenu.TabIndex = 4;
            lblUserMenu.Text = "";
            lblUserMenu.UseMnemonic = false;
            // 
            // headerControl
            // 
            headerControl.BackColor = Color.FromArgb(9, 8, 23);
            headerControl.Dock = DockStyle.Top;
            headerControl.Location = new Point(0, 0);
            headerControl.Margin = new Padding(3, 5, 3, 5);
            headerControl.Name = "headerControl";
            headerControl.Size = new Size(1600, 93);
            headerControl.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 8, 23);
            ClientSize = new Size(1600, 1093);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(headerControl);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1600, 1018);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SmartHome Lighting System";
            pnlContent.ResumeLayout(false);
            pnlSidebar.ResumeLayout(false);
            pnlUserProfile.ResumeLayout(false);
            pnlUserProfile.PerformLayout();
            pnlAvatar.ResumeLayout(false);
            pnlAvatar.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private SmartHomeLightingSystem.UserControls.LightingDashboardUserControl lightingDashboard;
        private SmartHomeLightingSystem.UserControls.RoomsUserControl roomsPage;
        private SmartHomeLightingSystem.UserControls.OverviewUserControl overviewPage;
        private SmartHomeLightingSystem.UserControls.SettingsUserControl settingsPage;
        private SmartHomeLightingSystem.UserControls.SecurityUserControl securityPage;
        private SmartHomeLightingSystem.UserControls.EnergyUserControl energyPage;
        private System.Windows.Forms.Panel pnlSidebar;
        private SmartHomeLightingSystem.UserControls.NavigationUserControl navigationControl;
        private System.Windows.Forms.Panel pnlUserProfile;
        private System.Windows.Forms.Panel pnlProfileLine;
        private SmartHomeLightingSystem.Controls.RoundedPanel pnlAvatar;
        private System.Windows.Forms.Label lblAvatarIcon;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblUserMenu;
        private SmartHomeLightingSystem.UserControls.HeaderUserControl headerControl;
    }
}
