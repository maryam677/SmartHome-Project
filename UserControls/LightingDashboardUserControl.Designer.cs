namespace WinFormsApp2.UserControls
{
    partial class LightingDashboardUserControl
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LightingDashboardUserControl));
            pnlTitleIcon = new WinFormsApp2.Controls.RoundedPanel();
            lblTitleIcon = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlSystemOnline = new WinFormsApp2.Controls.RoundedPanel();
            lblOnlineDot = new Label();
            lblSystemOnline = new Label();
            lblSystemOnlineSub = new Label();
            pnlTime = new WinFormsApp2.Controls.RoundedPanel();
            lblClockIcon = new Label();
            lblTime = new Label();
            lblDate = new Label();
            pnlConnected = new WinFormsApp2.Controls.RoundedPanel();
            lblHomeIcon = new Label();
            lblSmartHome = new Label();
            lblConnected = new Label();
            cardLivingRoom = new LightingCardUserControl();
            cardBedroom = new LightingCardUserControl();
            cardKitchen = new LightingCardUserControl();
            cardBathroom = new LightingCardUserControl();
            colorControl = new ColorControlUserControl();
            quickActions = new QuickActionsUserControl();
            systemOverview = new SystemOverviewUserControl();
            timerClock = new System.Windows.Forms.Timer(components);
            pnlTitleIcon.SuspendLayout();
            pnlSystemOnline.SuspendLayout();
            pnlTime.SuspendLayout();
            pnlConnected.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitleIcon
            // 
            pnlTitleIcon.BackColor = Color.Transparent;
            pnlTitleIcon.BorderColor = Color.FromArgb(168, 85, 247);
            pnlTitleIcon.BorderRadius = 14;
            pnlTitleIcon.BorderThickness = 1F;
            pnlTitleIcon.Controls.Add(lblTitleIcon);
            pnlTitleIcon.FillColor = Color.FromArgb(27, 21, 56);
            pnlTitleIcon.Location = new Point(27, 24);
            pnlTitleIcon.Margin = new Padding(3, 4, 3, 4);
            pnlTitleIcon.Name = "pnlTitleIcon";
            pnlTitleIcon.Padding = new Padding(12);
            pnlTitleIcon.Size = new Size(66, 77);
            pnlTitleIcon.TabIndex = 0;
            // 
            // lblTitleIcon
            // 
            lblTitleIcon.AutoSize = true;
            lblTitleIcon.BackColor = Color.Transparent;
            lblTitleIcon.Font = new Font("Segoe MDL2 Assets", 22F);
            lblTitleIcon.ForeColor = Color.FromArgb(192, 132, 252);
            lblTitleIcon.Location = new Point(14, 17);
            lblTitleIcon.Name = "lblTitleIcon";
            lblTitleIcon.Size = new Size(54, 37);
            lblTitleIcon.TabIndex = 0;
            lblTitleIcon.Text = "";
            lblTitleIcon.UseMnemonic = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(248, 250, 252);
            lblTitle.Location = new Point(107, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(275, 46);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Lighting System";
            lblTitle.UseMnemonic = false;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(165, 161, 194);
            lblSubtitle.Location = new Point(111, 72);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(294, 23);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Control your home lighting with ease";
            lblSubtitle.UseMnemonic = false;
            // 
            // pnlSystemOnline
            // 
            pnlSystemOnline.BackColor = Color.Transparent;
            pnlSystemOnline.BorderColor = Color.FromArgb(56, 43, 99);
            pnlSystemOnline.BorderRadius = 14;
            pnlSystemOnline.BorderThickness = 1F;
            pnlSystemOnline.Controls.Add(lblOnlineDot);
            pnlSystemOnline.Controls.Add(lblSystemOnline);
            pnlSystemOnline.Controls.Add(lblSystemOnlineSub);
            pnlSystemOnline.FillColor = Color.FromArgb(27, 21, 56);
            pnlSystemOnline.Location = new Point(688, 27);
            pnlSystemOnline.Margin = new Padding(3, 4, 3, 4);
            pnlSystemOnline.Name = "pnlSystemOnline";
            pnlSystemOnline.Padding = new Padding(12);
            pnlSystemOnline.Size = new Size(194, 75);
            pnlSystemOnline.TabIndex = 3;
            // 
            // lblOnlineDot
            // 
            lblOnlineDot.AutoSize = true;
            lblOnlineDot.BackColor = Color.Transparent;
            lblOnlineDot.Font = new Font("Segoe UI", 10F);
            lblOnlineDot.ForeColor = Color.FromArgb(34, 230, 168);
            lblOnlineDot.Location = new Point(14, 23);
            lblOnlineDot.Name = "lblOnlineDot";
            lblOnlineDot.Size = new Size(20, 23);
            lblOnlineDot.TabIndex = 0;
            lblOnlineDot.Text = "●";
            lblOnlineDot.UseMnemonic = false;
            // 
            // lblSystemOnline
            // 
            lblSystemOnline.AutoSize = true;
            lblSystemOnline.BackColor = Color.Transparent;
            lblSystemOnline.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSystemOnline.ForeColor = Color.FromArgb(248, 250, 252);
            lblSystemOnline.Location = new Point(37, 11);
            lblSystemOnline.Name = "lblSystemOnline";
            lblSystemOnline.Size = new Size(125, 23);
            lblSystemOnline.TabIndex = 1;
            lblSystemOnline.Text = "System Online";
            lblSystemOnline.UseMnemonic = false;
            // 
            // lblSystemOnlineSub
            // 
            lblSystemOnlineSub.AutoSize = true;
            lblSystemOnlineSub.BackColor = Color.Transparent;
            lblSystemOnlineSub.Font = new Font("Segoe UI", 8.5F);
            lblSystemOnlineSub.ForeColor = Color.FromArgb(165, 161, 194);
            lblSystemOnlineSub.Location = new Point(38, 40);
            lblSystemOnlineSub.Name = "lblSystemOnlineSub";
            lblSystemOnlineSub.Size = new Size(125, 20);
            lblSystemOnlineSub.TabIndex = 2;
            lblSystemOnlineSub.Text = "All systems active";
            lblSystemOnlineSub.UseMnemonic = false;
            // 
            // pnlTime
            // 
            pnlTime.BackColor = Color.Transparent;
            pnlTime.BorderColor = Color.FromArgb(56, 43, 99);
            pnlTime.BorderRadius = 14;
            pnlTime.BorderThickness = 1F;
            pnlTime.Controls.Add(lblClockIcon);
            pnlTime.Controls.Add(lblTime);
            pnlTime.Controls.Add(lblDate);
            pnlTime.FillColor = Color.FromArgb(27, 21, 56);
            pnlTime.Location = new Point(896, 27);
            pnlTime.Margin = new Padding(3, 4, 3, 4);
            pnlTime.Name = "pnlTime";
            pnlTime.Padding = new Padding(12);
            pnlTime.Size = new Size(194, 75);
            pnlTime.TabIndex = 4;
            // 
            // lblClockIcon
            // 
            lblClockIcon.AutoSize = true;
            lblClockIcon.BackColor = Color.Transparent;
            lblClockIcon.Font = new Font("Segoe MDL2 Assets", 16F);
            lblClockIcon.ForeColor = Color.FromArgb(192, 132, 252);
            lblClockIcon.Location = new Point(14, 21);
            lblClockIcon.Name = "lblClockIcon";
            lblClockIcon.Size = new Size(39, 27);
            lblClockIcon.TabIndex = 0;
            lblClockIcon.Text = "";
            lblClockIcon.UseMnemonic = false;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTime.ForeColor = Color.FromArgb(248, 250, 252);
            lblTime.Location = new Point(50, 9);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(85, 25);
            lblTime.TabIndex = 1;
            lblTime.Text = "4:36 PM";
            lblTime.UseMnemonic = false;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe UI", 8.5F);
            lblDate.ForeColor = Color.FromArgb(165, 161, 194);
            lblDate.Location = new Point(51, 41);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(87, 20);
            lblDate.TabIndex = 2;
            lblDate.Text = "Nov 4, 2026";
            lblDate.UseMnemonic = false;
            // 
            // pnlConnected
            // 
            pnlConnected.BackColor = Color.Transparent;
            pnlConnected.BorderColor = Color.FromArgb(56, 43, 99);
            pnlConnected.BorderRadius = 14;
            pnlConnected.BorderThickness = 1F;
            pnlConnected.Controls.Add(lblHomeIcon);
            pnlConnected.Controls.Add(lblSmartHome);
            pnlConnected.Controls.Add(lblConnected);
            pnlConnected.FillColor = Color.FromArgb(27, 21, 56);
            pnlConnected.Location = new Point(1104, 27);
            pnlConnected.Margin = new Padding(3, 4, 3, 4);
            pnlConnected.Name = "pnlConnected";
            pnlConnected.Padding = new Padding(12);
            pnlConnected.Size = new Size(206, 75);
            pnlConnected.TabIndex = 5;
            // 
            // lblHomeIcon
            // 
            lblHomeIcon.AutoSize = true;
            lblHomeIcon.BackColor = Color.Transparent;
            lblHomeIcon.Font = new Font("Segoe MDL2 Assets", 16F);
            lblHomeIcon.ForeColor = Color.FromArgb(192, 132, 252);
            lblHomeIcon.Location = new Point(14, 21);
            lblHomeIcon.Name = "lblHomeIcon";
            lblHomeIcon.Size = new Size(39, 27);
            lblHomeIcon.TabIndex = 0;
            lblHomeIcon.Text = "";
            lblHomeIcon.UseMnemonic = false;
            // 
            // lblSmartHome
            // 
            lblSmartHome.AutoSize = true;
            lblSmartHome.BackColor = Color.Transparent;
            lblSmartHome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSmartHome.ForeColor = Color.FromArgb(248, 250, 252);
            lblSmartHome.Location = new Point(50, 11);
            lblSmartHome.Name = "lblSmartHome";
            lblSmartHome.Size = new Size(112, 23);
            lblSmartHome.TabIndex = 1;
            lblSmartHome.Text = "Smart Home";
            lblSmartHome.UseMnemonic = false;
            // 
            // lblConnected
            // 
            lblConnected.AutoSize = true;
            lblConnected.BackColor = Color.Transparent;
            lblConnected.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConnected.ForeColor = Color.FromArgb(34, 230, 168);
            lblConnected.Location = new Point(51, 40);
            lblConnected.Name = "lblConnected";
            lblConnected.Size = new Size(83, 20);
            lblConnected.TabIndex = 2;
            lblConnected.Text = "Connected";
            lblConnected.UseMnemonic = false;
            // 
            // cardLivingRoom
            // 
            cardLivingRoom.BackColor = Color.FromArgb(9, 8, 23);
            cardLivingRoom.Brightness = 75;
            cardLivingRoom.IsFavorite = true;
            cardLivingRoom.LightsOn = true;
            cardLivingRoom.Location = new Point(27, 128);
            cardLivingRoom.Margin = new Padding(3, 5, 3, 5);
            cardLivingRoom.Name = "cardLivingRoom";
            cardLivingRoom.Room = null;
            cardLivingRoom.RoomIcon = "";
            cardLivingRoom.RoomImage = (Image)resources.GetObject("cardLivingRoom.RoomImage");
            cardLivingRoom.RoomName = "Living Room";
            cardLivingRoom.RoomSubtitle = "Relax & Enjoy";
            cardLivingRoom.Size = new Size(304, 488);
            cardLivingRoom.TabIndex = 6;
            // 
            // cardBedroom
            // 
            cardBedroom.BackColor = Color.FromArgb(9, 8, 23);
            cardBedroom.Brightness = 60;
            cardBedroom.IsFavorite = true;
            cardBedroom.LightsOn = true;
            cardBedroom.Location = new Point(352, 128);
            cardBedroom.Margin = new Padding(3, 5, 3, 5);
            cardBedroom.Name = "cardBedroom";
            cardBedroom.Room = null;
            cardBedroom.RoomIcon = "";
            cardBedroom.RoomImage = (Image)resources.GetObject("cardBedroom.RoomImage");
            cardBedroom.RoomName = "Bedroom";
            cardBedroom.RoomSubtitle = "Sleep in Comfort";
            cardBedroom.Size = new Size(304, 488);
            cardBedroom.TabIndex = 7;
            // 
            // cardKitchen
            // 
            cardKitchen.BackColor = Color.FromArgb(9, 8, 23);
            cardKitchen.Brightness = 80;
            cardKitchen.IsFavorite = true;
            cardKitchen.LightsOn = true;
            cardKitchen.Location = new Point(677, 128);
            cardKitchen.Margin = new Padding(3, 5, 3, 5);
            cardKitchen.Name = "cardKitchen";
            cardKitchen.Room = null;
            cardKitchen.RoomIcon = "";
            cardKitchen.RoomImage = (Image)resources.GetObject("cardKitchen.RoomImage");
            cardKitchen.RoomName = "Kitchen";
            cardKitchen.RoomSubtitle = "Cook with Clarity";
            cardKitchen.Size = new Size(304, 488);
            cardKitchen.TabIndex = 8;
            // 
            // cardBathroom
            // 
            cardBathroom.BackColor = Color.FromArgb(9, 8, 23);
            cardBathroom.Brightness = 0;
            cardBathroom.IsFavorite = false;
            cardBathroom.LightsOn = false;
            cardBathroom.Location = new Point(1001, 128);
            cardBathroom.Margin = new Padding(3, 5, 3, 5);
            cardBathroom.Name = "cardBathroom";
            cardBathroom.Room = null;
            cardBathroom.RoomIcon = "";
            cardBathroom.RoomImage = (Image)resources.GetObject("cardBathroom.RoomImage");
            cardBathroom.RoomName = "Bathroom";
            cardBathroom.RoomSubtitle = "Fresh & Bright";
            cardBathroom.Size = new Size(304, 488);
            cardBathroom.TabIndex = 9;
            // 
            // colorControl
            // 
            colorControl.BackColor = Color.FromArgb(9, 8, 23);
            colorControl.Location = new Point(27, 640);
            colorControl.Margin = new Padding(3, 5, 3, 5);
            colorControl.Name = "colorControl";
            colorControl.Size = new Size(395, 280);
            colorControl.TabIndex = 10;
            // 
            // quickActions
            // 
            quickActions.BackColor = Color.FromArgb(9, 8, 23);
            quickActions.Location = new Point(443, 640);
            quickActions.Margin = new Padding(3, 5, 3, 5);
            quickActions.Name = "quickActions";
            quickActions.Size = new Size(466, 280);
            quickActions.TabIndex = 11;
            // 
            // systemOverview
            // 
            systemOverview.BackColor = Color.FromArgb(9, 8, 23);
            systemOverview.Location = new Point(930, 640);
            systemOverview.Margin = new Padding(3, 5, 3, 5);
            systemOverview.Name = "systemOverview";
            systemOverview.Size = new Size(379, 280);
            systemOverview.TabIndex = 12;
            // 
            // timerClock
            // 
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // LightingDashboardUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 8, 23);
            Controls.Add(pnlTitleIcon);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(pnlSystemOnline);
            Controls.Add(pnlTime);
            Controls.Add(pnlConnected);
            Controls.Add(cardLivingRoom);
            Controls.Add(cardBedroom);
            Controls.Add(cardKitchen);
            Controls.Add(cardBathroom);
            Controls.Add(colorControl);
            Controls.Add(quickActions);
            Controls.Add(systemOverview);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LightingDashboardUserControl";
            Size = new Size(1603, 1056);
            pnlTitleIcon.ResumeLayout(false);
            pnlTitleIcon.PerformLayout();
            pnlSystemOnline.ResumeLayout(false);
            pnlSystemOnline.PerformLayout();
            pnlTime.ResumeLayout(false);
            pnlTime.PerformLayout();
            pnlConnected.ResumeLayout(false);
            pnlConnected.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private WinFormsApp2.Controls.RoundedPanel pnlTitleIcon;
        private System.Windows.Forms.Label lblTitleIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private WinFormsApp2.Controls.RoundedPanel pnlSystemOnline;
        private System.Windows.Forms.Label lblOnlineDot;
        private System.Windows.Forms.Label lblSystemOnline;
        private System.Windows.Forms.Label lblSystemOnlineSub;
        private WinFormsApp2.Controls.RoundedPanel pnlTime;
        private System.Windows.Forms.Label lblClockIcon;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private WinFormsApp2.Controls.RoundedPanel pnlConnected;
        private System.Windows.Forms.Label lblHomeIcon;
        private System.Windows.Forms.Label lblSmartHome;
        private System.Windows.Forms.Label lblConnected;
        private WinFormsApp2.UserControls.LightingCardUserControl cardLivingRoom;
        private WinFormsApp2.UserControls.LightingCardUserControl cardBedroom;
        private WinFormsApp2.UserControls.LightingCardUserControl cardKitchen;
        private WinFormsApp2.UserControls.LightingCardUserControl cardBathroom;
        private WinFormsApp2.UserControls.ColorControlUserControl colorControl;
        private WinFormsApp2.UserControls.QuickActionsUserControl quickActions;
        private WinFormsApp2.UserControls.SystemOverviewUserControl systemOverview;
        private System.Windows.Forms.Timer timerClock;
    }
}
