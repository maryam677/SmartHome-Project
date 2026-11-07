namespace SmartHomeLightingSystem.UserControls
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
            this.components = new System.ComponentModel.Container();
            this.pnlTitleIcon = new SmartHomeLightingSystem.Controls.RoundedPanel();
            this.lblTitleIcon = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlSystemOnline = new SmartHomeLightingSystem.Controls.RoundedPanel();
            this.lblOnlineDot = new System.Windows.Forms.Label();
            this.lblSystemOnline = new System.Windows.Forms.Label();
            this.lblSystemOnlineSub = new System.Windows.Forms.Label();
            this.pnlTime = new SmartHomeLightingSystem.Controls.RoundedPanel();
            this.lblClockIcon = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlConnected = new SmartHomeLightingSystem.Controls.RoundedPanel();
            this.lblHomeIcon = new System.Windows.Forms.Label();
            this.lblSmartHome = new System.Windows.Forms.Label();
            this.lblConnected = new System.Windows.Forms.Label();
            this.cardLivingRoom = new SmartHomeLightingSystem.UserControls.LightingCardUserControl();
            this.cardBedroom = new SmartHomeLightingSystem.UserControls.LightingCardUserControl();
            this.cardKitchen = new SmartHomeLightingSystem.UserControls.LightingCardUserControl();
            this.cardBathroom = new SmartHomeLightingSystem.UserControls.LightingCardUserControl();
            this.colorControl = new SmartHomeLightingSystem.UserControls.ColorControlUserControl();
            this.quickActions = new SmartHomeLightingSystem.UserControls.QuickActionsUserControl();
            this.systemOverview = new SmartHomeLightingSystem.UserControls.SystemOverviewUserControl();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.pnlTitleIcon.SuspendLayout();
            this.pnlSystemOnline.SuspendLayout();
            this.pnlTime.SuspendLayout();
            this.pnlConnected.SuspendLayout();
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
            this.lblTitleIcon.Text = "\uEA80";
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
            this.lblTitle.Size = new System.Drawing.Size(240, 42);
            this.lblTitle.Text = "Lighting System";
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
            this.lblSubtitle.Size = new System.Drawing.Size(257, 23);
            this.lblSubtitle.Text = "Control your home lighting with ease";
            this.lblSubtitle.UseMnemonic = false;
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.TabIndex = 2;
            // 
            // pnlSystemOnline
            // 
            this.pnlSystemOnline.Controls.Add(this.lblOnlineDot);
            this.pnlSystemOnline.Controls.Add(this.lblSystemOnline);
            this.pnlSystemOnline.Controls.Add(this.lblSystemOnlineSub);
            this.pnlSystemOnline.BackColor = System.Drawing.Color.Transparent;
            this.pnlSystemOnline.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.pnlSystemOnline.BorderRadius = 14;
            this.pnlSystemOnline.BorderThickness = 1F;
            this.pnlSystemOnline.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(21)))), ((int)(((byte)(56)))));
            this.pnlSystemOnline.Location = new System.Drawing.Point(602, 20);
            this.pnlSystemOnline.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlSystemOnline.Size = new System.Drawing.Size(170, 56);
            this.pnlSystemOnline.Name = "pnlSystemOnline";
            this.pnlSystemOnline.TabIndex = 3;
            // 
            // lblOnlineDot
            // 
            this.lblOnlineDot.AutoSize = true;
            this.lblOnlineDot.BackColor = System.Drawing.Color.Transparent;
            this.lblOnlineDot.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOnlineDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(230)))), ((int)(((byte)(168)))));
            this.lblOnlineDot.Location = new System.Drawing.Point(12, 17);
            this.lblOnlineDot.Size = new System.Drawing.Size(13, 23);
            this.lblOnlineDot.Text = "\u25CF";
            this.lblOnlineDot.UseMnemonic = false;
            this.lblOnlineDot.Name = "lblOnlineDot";
            this.lblOnlineDot.TabIndex = 0;
            // 
            // lblSystemOnline
            // 
            this.lblSystemOnline.AutoSize = true;
            this.lblSystemOnline.BackColor = System.Drawing.Color.Transparent;
            this.lblSystemOnline.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSystemOnline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblSystemOnline.Location = new System.Drawing.Point(32, 8);
            this.lblSystemOnline.Size = new System.Drawing.Size(107, 23);
            this.lblSystemOnline.Text = "System Online";
            this.lblSystemOnline.UseMnemonic = false;
            this.lblSystemOnline.Name = "lblSystemOnline";
            this.lblSystemOnline.TabIndex = 1;
            // 
            // lblSystemOnlineSub
            // 
            this.lblSystemOnlineSub.AutoSize = true;
            this.lblSystemOnlineSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSystemOnlineSub.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSystemOnlineSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblSystemOnlineSub.Location = new System.Drawing.Point(33, 30);
            this.lblSystemOnlineSub.Size = new System.Drawing.Size(113, 20);
            this.lblSystemOnlineSub.Text = "All systems active";
            this.lblSystemOnlineSub.UseMnemonic = false;
            this.lblSystemOnlineSub.Name = "lblSystemOnlineSub";
            this.lblSystemOnlineSub.TabIndex = 2;
            // 
            // pnlTime
            // 
            this.pnlTime.Controls.Add(this.lblClockIcon);
            this.pnlTime.Controls.Add(this.lblTime);
            this.pnlTime.Controls.Add(this.lblDate);
            this.pnlTime.BackColor = System.Drawing.Color.Transparent;
            this.pnlTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.pnlTime.BorderRadius = 14;
            this.pnlTime.BorderThickness = 1F;
            this.pnlTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(21)))), ((int)(((byte)(56)))));
            this.pnlTime.Location = new System.Drawing.Point(784, 20);
            this.pnlTime.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlTime.Size = new System.Drawing.Size(170, 56);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.TabIndex = 4;
            // 
            // lblClockIcon
            // 
            this.lblClockIcon.AutoSize = true;
            this.lblClockIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblClockIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClockIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.lblClockIcon.Location = new System.Drawing.Point(12, 16);
            this.lblClockIcon.Size = new System.Drawing.Size(30, 34);
            this.lblClockIcon.Text = "\uE823";
            this.lblClockIcon.UseMnemonic = false;
            this.lblClockIcon.Name = "lblClockIcon";
            this.lblClockIcon.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblTime.Location = new System.Drawing.Point(44, 7);
            this.lblTime.Size = new System.Drawing.Size(66, 24);
            this.lblTime.Text = "4:36 PM";
            this.lblTime.UseMnemonic = false;
            this.lblTime.Name = "lblTime";
            this.lblTime.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblDate.Location = new System.Drawing.Point(45, 31);
            this.lblDate.Size = new System.Drawing.Size(71, 20);
            this.lblDate.Text = "Nov 4, 2026";
            this.lblDate.UseMnemonic = false;
            this.lblDate.Name = "lblDate";
            this.lblDate.TabIndex = 2;
            // 
            // pnlConnected
            // 
            this.pnlConnected.Controls.Add(this.lblHomeIcon);
            this.pnlConnected.Controls.Add(this.lblSmartHome);
            this.pnlConnected.Controls.Add(this.lblConnected);
            this.pnlConnected.BackColor = System.Drawing.Color.Transparent;
            this.pnlConnected.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.pnlConnected.BorderRadius = 14;
            this.pnlConnected.BorderThickness = 1F;
            this.pnlConnected.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(21)))), ((int)(((byte)(56)))));
            this.pnlConnected.Location = new System.Drawing.Point(966, 20);
            this.pnlConnected.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlConnected.Size = new System.Drawing.Size(180, 56);
            this.pnlConnected.Name = "pnlConnected";
            this.pnlConnected.TabIndex = 5;
            // 
            // lblHomeIcon
            // 
            this.lblHomeIcon.AutoSize = true;
            this.lblHomeIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblHomeIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHomeIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.lblHomeIcon.Location = new System.Drawing.Point(12, 16);
            this.lblHomeIcon.Size = new System.Drawing.Size(30, 34);
            this.lblHomeIcon.Text = "\uE80F";
            this.lblHomeIcon.UseMnemonic = false;
            this.lblHomeIcon.Name = "lblHomeIcon";
            this.lblHomeIcon.TabIndex = 0;
            // 
            // lblSmartHome
            // 
            this.lblSmartHome.AutoSize = true;
            this.lblSmartHome.BackColor = System.Drawing.Color.Transparent;
            this.lblSmartHome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSmartHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblSmartHome.Location = new System.Drawing.Point(44, 8);
            this.lblSmartHome.Size = new System.Drawing.Size(84, 23);
            this.lblSmartHome.Text = "Smart Home";
            this.lblSmartHome.UseMnemonic = false;
            this.lblSmartHome.Name = "lblSmartHome";
            this.lblSmartHome.TabIndex = 1;
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.BackColor = System.Drawing.Color.Transparent;
            this.lblConnected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConnected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(230)))), ((int)(((byte)(168)))));
            this.lblConnected.Location = new System.Drawing.Point(45, 30);
            this.lblConnected.Size = new System.Drawing.Size(69, 21);
            this.lblConnected.Text = "Connected";
            this.lblConnected.UseMnemonic = false;
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.TabIndex = 2;
            // 
            // cardLivingRoom
            // 
            this.cardLivingRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.cardLivingRoom.Brightness = 75;
            this.cardLivingRoom.IsFavorite = true;
            this.cardLivingRoom.LightsOn = true;
            this.cardLivingRoom.Location = new System.Drawing.Point(24, 96);
            this.cardLivingRoom.RoomIcon = "\uE7F4";
            this.cardLivingRoom.RoomImage = global::SmartHomeLightingSystem.Properties.Resources.living_room;
            this.cardLivingRoom.RoomName = "Living Room";
            this.cardLivingRoom.RoomSubtitle = "Relax & Enjoy";
            this.cardLivingRoom.Size = new System.Drawing.Size(266, 366);
            this.cardLivingRoom.Name = "cardLivingRoom";
            this.cardLivingRoom.TabIndex = 6;
            // 
            // cardBedroom
            // 
            this.cardBedroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.cardBedroom.Brightness = 60;
            this.cardBedroom.IsFavorite = true;
            this.cardBedroom.LightsOn = true;
            this.cardBedroom.Location = new System.Drawing.Point(308, 96);
            this.cardBedroom.RoomIcon = "\uE708";
            this.cardBedroom.RoomImage = global::SmartHomeLightingSystem.Properties.Resources.bedroom;
            this.cardBedroom.RoomName = "Bedroom";
            this.cardBedroom.RoomSubtitle = "Sleep in Comfort";
            this.cardBedroom.Size = new System.Drawing.Size(266, 366);
            this.cardBedroom.Name = "cardBedroom";
            this.cardBedroom.TabIndex = 7;
            // 
            // cardKitchen
            // 
            this.cardKitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.cardKitchen.Brightness = 80;
            this.cardKitchen.IsFavorite = true;
            this.cardKitchen.LightsOn = true;
            this.cardKitchen.Location = new System.Drawing.Point(592, 96);
            this.cardKitchen.RoomIcon = "\uED56";
            this.cardKitchen.RoomImage = global::SmartHomeLightingSystem.Properties.Resources.kitchen;
            this.cardKitchen.RoomName = "Kitchen";
            this.cardKitchen.RoomSubtitle = "Cook with Clarity";
            this.cardKitchen.Size = new System.Drawing.Size(266, 366);
            this.cardKitchen.Name = "cardKitchen";
            this.cardKitchen.TabIndex = 8;
            // 
            // cardBathroom
            // 
            this.cardBathroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.cardBathroom.Brightness = 0;
            this.cardBathroom.IsFavorite = false;
            this.cardBathroom.LightsOn = false;
            this.cardBathroom.Location = new System.Drawing.Point(876, 96);
            this.cardBathroom.RoomIcon = "\uEB42";
            this.cardBathroom.RoomImage = global::SmartHomeLightingSystem.Properties.Resources.bathroom;
            this.cardBathroom.RoomName = "Bathroom";
            this.cardBathroom.RoomSubtitle = "Fresh & Bright";
            this.cardBathroom.Size = new System.Drawing.Size(266, 366);
            this.cardBathroom.Name = "cardBathroom";
            this.cardBathroom.TabIndex = 9;
            // 
            // colorControl
            // 
            this.colorControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.colorControl.Location = new System.Drawing.Point(24, 480);
            this.colorControl.Size = new System.Drawing.Size(346, 210);
            this.colorControl.Name = "colorControl";
            this.colorControl.TabIndex = 10;
            // 
            // quickActions
            // 
            this.quickActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.quickActions.Location = new System.Drawing.Point(388, 480);
            this.quickActions.Size = new System.Drawing.Size(408, 210);
            this.quickActions.Name = "quickActions";
            this.quickActions.TabIndex = 11;
            // 
            // systemOverview
            // 
            this.systemOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.systemOverview.Location = new System.Drawing.Point(814, 480);
            this.systemOverview.Size = new System.Drawing.Size(332, 210);
            this.systemOverview.Name = "systemOverview";
            this.systemOverview.TabIndex = 12;
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // LightingDashboardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.pnlTitleIcon);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.pnlSystemOnline);
            this.Controls.Add(this.pnlTime);
            this.Controls.Add(this.pnlConnected);
            this.Controls.Add(this.cardLivingRoom);
            this.Controls.Add(this.cardBedroom);
            this.Controls.Add(this.cardKitchen);
            this.Controls.Add(this.cardBathroom);
            this.Controls.Add(this.colorControl);
            this.Controls.Add(this.quickActions);
            this.Controls.Add(this.systemOverview);
            this.Size = new System.Drawing.Size(1170, 750);
            this.Name = "LightingDashboardUserControl";
            this.pnlTitleIcon.ResumeLayout(false);
            this.pnlTitleIcon.PerformLayout();
            this.pnlSystemOnline.ResumeLayout(false);
            this.pnlSystemOnline.PerformLayout();
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            this.pnlConnected.ResumeLayout(false);
            this.pnlConnected.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SmartHomeLightingSystem.Controls.RoundedPanel pnlTitleIcon;
        private System.Windows.Forms.Label lblTitleIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private SmartHomeLightingSystem.Controls.RoundedPanel pnlSystemOnline;
        private System.Windows.Forms.Label lblOnlineDot;
        private System.Windows.Forms.Label lblSystemOnline;
        private System.Windows.Forms.Label lblSystemOnlineSub;
        private SmartHomeLightingSystem.Controls.RoundedPanel pnlTime;
        private System.Windows.Forms.Label lblClockIcon;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private SmartHomeLightingSystem.Controls.RoundedPanel pnlConnected;
        private System.Windows.Forms.Label lblHomeIcon;
        private System.Windows.Forms.Label lblSmartHome;
        private System.Windows.Forms.Label lblConnected;
        private SmartHomeLightingSystem.UserControls.LightingCardUserControl cardLivingRoom;
        private SmartHomeLightingSystem.UserControls.LightingCardUserControl cardBedroom;
        private SmartHomeLightingSystem.UserControls.LightingCardUserControl cardKitchen;
        private SmartHomeLightingSystem.UserControls.LightingCardUserControl cardBathroom;
        private SmartHomeLightingSystem.UserControls.ColorControlUserControl colorControl;
        private SmartHomeLightingSystem.UserControls.QuickActionsUserControl quickActions;
        private SmartHomeLightingSystem.UserControls.SystemOverviewUserControl systemOverview;
        private System.Windows.Forms.Timer timerClock;
    }
}
