namespace WinFormsApp2.UserControls
{
    partial class RoomsUserControl
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
            this.pnlRoomsSummary = new WinFormsApp2.Controls.RoundedPanel();
            this.lblSummaryIcon = new System.Windows.Forms.Label();
            this.lblRoomsSummary = new System.Windows.Forms.Label();
            this.rowLivingRoom = new WinFormsApp2.UserControls.RoomRowUserControl();
            this.rowBedroom = new WinFormsApp2.UserControls.RoomRowUserControl();
            this.rowKitchen = new WinFormsApp2.UserControls.RoomRowUserControl();
            this.rowBathroom = new WinFormsApp2.UserControls.RoomRowUserControl();
            this.pnlTitleIcon.SuspendLayout();
            this.pnlRoomsSummary.SuspendLayout();
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
            this.lblTitleIcon.Text = "\uF0E2";
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
            this.lblTitle.Size = new System.Drawing.Size(84, 42);
            this.lblTitle.Text = "Rooms";
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
            this.lblSubtitle.Size = new System.Drawing.Size(223, 23);
            this.lblSubtitle.Text = "Manage the lights of every room";
            this.lblSubtitle.UseMnemonic = false;
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.TabIndex = 2;
            // 
            // pnlRoomsSummary
            // 
            this.pnlRoomsSummary.Controls.Add(this.lblSummaryIcon);
            this.pnlRoomsSummary.Controls.Add(this.lblRoomsSummary);
            this.pnlRoomsSummary.BackColor = System.Drawing.Color.Transparent;
            this.pnlRoomsSummary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.pnlRoomsSummary.BorderRadius = 14;
            this.pnlRoomsSummary.BorderThickness = 1F;
            this.pnlRoomsSummary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(21)))), ((int)(((byte)(56)))));
            this.pnlRoomsSummary.Location = new System.Drawing.Point(896, 20);
            this.pnlRoomsSummary.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlRoomsSummary.Size = new System.Drawing.Size(250, 56);
            this.pnlRoomsSummary.Name = "pnlRoomsSummary";
            this.pnlRoomsSummary.TabIndex = 3;
            // 
            // lblSummaryIcon
            // 
            this.lblSummaryIcon.AutoSize = true;
            this.lblSummaryIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblSummaryIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSummaryIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.lblSummaryIcon.Location = new System.Drawing.Point(14, 16);
            this.lblSummaryIcon.Size = new System.Drawing.Size(30, 34);
            this.lblSummaryIcon.Text = "\uE80F";
            this.lblSummaryIcon.UseMnemonic = false;
            this.lblSummaryIcon.Name = "lblSummaryIcon";
            this.lblSummaryIcon.TabIndex = 0;
            // 
            // lblRoomsSummary
            // 
            this.lblRoomsSummary.AutoSize = true;
            this.lblRoomsSummary.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomsSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoomsSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblRoomsSummary.Location = new System.Drawing.Point(44, 17);
            this.lblRoomsSummary.Size = new System.Drawing.Size(185, 23);
            this.lblRoomsSummary.Text = "4 Rooms  \u2022  3 Lights On";
            this.lblRoomsSummary.UseMnemonic = false;
            this.lblRoomsSummary.Name = "lblRoomsSummary";
            this.lblRoomsSummary.TabIndex = 1;
            // 
            // rowLivingRoom
            // 
            this.rowLivingRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.rowLivingRoom.Brightness = 75;
            this.rowLivingRoom.LightsOn = true;
            this.rowLivingRoom.Location = new System.Drawing.Point(24, 100);
            this.rowLivingRoom.RoomIcon = "\uE7F4";
            this.rowLivingRoom.RoomImage = global::WinFormsApp2.Properties.Resources.living_room;
            this.rowLivingRoom.RoomName = "Living Room";
            this.rowLivingRoom.RoomSubtitle = "Relax & Enjoy";
            this.rowLivingRoom.Size = new System.Drawing.Size(1122, 136);
            this.rowLivingRoom.Name = "rowLivingRoom";
            this.rowLivingRoom.TabIndex = 4;
            // 
            // rowBedroom
            // 
            this.rowBedroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.rowBedroom.Brightness = 60;
            this.rowBedroom.LightsOn = true;
            this.rowBedroom.Location = new System.Drawing.Point(24, 250);
            this.rowBedroom.RoomIcon = "\uE708";
            this.rowBedroom.RoomImage = global::WinFormsApp2.Properties.Resources.bedroom;
            this.rowBedroom.RoomName = "Bedroom";
            this.rowBedroom.RoomSubtitle = "Sleep in Comfort";
            this.rowBedroom.Size = new System.Drawing.Size(1122, 136);
            this.rowBedroom.Name = "rowBedroom";
            this.rowBedroom.TabIndex = 5;
            // 
            // rowKitchen
            // 
            this.rowKitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.rowKitchen.Brightness = 80;
            this.rowKitchen.LightsOn = true;
            this.rowKitchen.Location = new System.Drawing.Point(24, 400);
            this.rowKitchen.RoomIcon = "\uED56";
            this.rowKitchen.RoomImage = global::WinFormsApp2.Properties.Resources.kitchen;
            this.rowKitchen.RoomName = "Kitchen";
            this.rowKitchen.RoomSubtitle = "Cook with Clarity";
            this.rowKitchen.Size = new System.Drawing.Size(1122, 136);
            this.rowKitchen.Name = "rowKitchen";
            this.rowKitchen.TabIndex = 6;
            // 
            // rowBathroom
            // 
            this.rowBathroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.rowBathroom.Brightness = 0;
            this.rowBathroom.LightsOn = false;
            this.rowBathroom.Location = new System.Drawing.Point(24, 550);
            this.rowBathroom.RoomIcon = "\uEB42";
            this.rowBathroom.RoomImage = global::WinFormsApp2.Properties.Resources.bathroom;
            this.rowBathroom.RoomName = "Bathroom";
            this.rowBathroom.RoomSubtitle = "Fresh & Bright";
            this.rowBathroom.Size = new System.Drawing.Size(1122, 136);
            this.rowBathroom.Name = "rowBathroom";
            this.rowBathroom.TabIndex = 7;
            // 
            // RoomsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.pnlTitleIcon);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.pnlRoomsSummary);
            this.Controls.Add(this.rowLivingRoom);
            this.Controls.Add(this.rowBedroom);
            this.Controls.Add(this.rowKitchen);
            this.Controls.Add(this.rowBathroom);
            this.Size = new System.Drawing.Size(1170, 750);
            this.Name = "RoomsUserControl";
            this.pnlTitleIcon.ResumeLayout(false);
            this.pnlTitleIcon.PerformLayout();
            this.pnlRoomsSummary.ResumeLayout(false);
            this.pnlRoomsSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinFormsApp2.Controls.RoundedPanel pnlTitleIcon;
        private System.Windows.Forms.Label lblTitleIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private WinFormsApp2.Controls.RoundedPanel pnlRoomsSummary;
        private System.Windows.Forms.Label lblSummaryIcon;
        private System.Windows.Forms.Label lblRoomsSummary;
        private WinFormsApp2.UserControls.RoomRowUserControl rowLivingRoom;
        private WinFormsApp2.UserControls.RoomRowUserControl rowBedroom;
        private WinFormsApp2.UserControls.RoomRowUserControl rowKitchen;
        private WinFormsApp2.UserControls.RoomRowUserControl rowBathroom;
    }
}
