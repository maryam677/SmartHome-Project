namespace WinFormsApp2.UserControls
{
    partial class RoomRowUserControl
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
            this.pnlRow = new WinFormsApp2.Controls.RoundedPanel();
            this.picRoom = new System.Windows.Forms.PictureBox();
            this.lblRoomIcon = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblRoomSubtitle = new System.Windows.Forms.Label();
            this.lblOnline = new System.Windows.Forms.Label();
            this.lblLightStatusTitle = new System.Windows.Forms.Label();
            this.lblBulbIcon = new System.Windows.Forms.Label();
            this.lblLightStatus = new System.Windows.Forms.Label();
            this.lblBrightnessTitle = new System.Windows.Forms.Label();
            this.lblBrightnessValue = new System.Windows.Forms.Label();
            this.trackBrightness = new System.Windows.Forms.TrackBar();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRow
            // 
            this.pnlRow.Controls.Add(this.picRoom);
            this.pnlRow.Controls.Add(this.lblRoomIcon);
            this.pnlRow.Controls.Add(this.lblRoomName);
            this.pnlRow.Controls.Add(this.lblRoomSubtitle);
            this.pnlRow.Controls.Add(this.lblOnline);
            this.pnlRow.Controls.Add(this.lblLightStatusTitle);
            this.pnlRow.Controls.Add(this.lblBulbIcon);
            this.pnlRow.Controls.Add(this.lblLightStatus);
            this.pnlRow.Controls.Add(this.lblBrightnessTitle);
            this.pnlRow.Controls.Add(this.lblBrightnessValue);
            this.pnlRow.Controls.Add(this.trackBrightness);
            this.pnlRow.Controls.Add(this.btnToggle);
            this.pnlRow.Controls.Add(this.btnSettings);
            this.pnlRow.BackColor = System.Drawing.Color.Transparent;
            this.pnlRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.pnlRow.BorderRadius = 16;
            this.pnlRow.BorderThickness = 1F;
            this.pnlRow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(21)))), ((int)(((byte)(56)))));
            this.pnlRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRow.Location = new System.Drawing.Point(0, 0);
            this.pnlRow.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlRow.Size = new System.Drawing.Size(1122, 136);
            this.pnlRow.Name = "pnlRow";
            this.pnlRow.TabIndex = 0;
            // 
            // picRoom
            // 
            this.picRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(46)))));
            this.picRoom.Image = global::WinFormsApp2.Properties.Resources.living_room;
            this.picRoom.Location = new System.Drawing.Point(12, 12);
            this.picRoom.Size = new System.Drawing.Size(200, 112);
            this.picRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRoom.TabStop = false;
            this.picRoom.Name = "picRoom";
            this.picRoom.TabIndex = 0;
            // 
            // lblRoomIcon
            // 
            this.lblRoomIcon.AutoSize = true;
            this.lblRoomIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRoomIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.lblRoomIcon.Location = new System.Drawing.Point(232, 20);
            this.lblRoomIcon.Size = new System.Drawing.Size(28, 32);
            this.lblRoomIcon.Text = "\uE7F4";
            this.lblRoomIcon.UseMnemonic = false;
            this.lblRoomIcon.Name = "lblRoomIcon";
            this.lblRoomIcon.TabIndex = 1;
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoomName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblRoomName.Location = new System.Drawing.Point(262, 14);
            this.lblRoomName.Size = new System.Drawing.Size(126, 30);
            this.lblRoomName.Text = "Living Room";
            this.lblRoomName.UseMnemonic = false;
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.TabIndex = 2;
            // 
            // lblRoomSubtitle
            // 
            this.lblRoomSubtitle.AutoSize = true;
            this.lblRoomSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRoomSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblRoomSubtitle.Location = new System.Drawing.Point(264, 44);
            this.lblRoomSubtitle.Size = new System.Drawing.Size(87, 21);
            this.lblRoomSubtitle.Text = "Relax & Enjoy";
            this.lblRoomSubtitle.UseMnemonic = false;
            this.lblRoomSubtitle.Name = "lblRoomSubtitle";
            this.lblRoomSubtitle.TabIndex = 3;
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.BackColor = System.Drawing.Color.Transparent;
            this.lblOnline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOnline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(230)))), ((int)(((byte)(168)))));
            this.lblOnline.Location = new System.Drawing.Point(264, 82);
            this.lblOnline.Size = new System.Drawing.Size(62, 21);
            this.lblOnline.Text = "\u25CF Online";
            this.lblOnline.UseMnemonic = false;
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.TabIndex = 4;
            // 
            // lblLightStatusTitle
            // 
            this.lblLightStatusTitle.AutoSize = true;
            this.lblLightStatusTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblLightStatusTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLightStatusTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblLightStatusTitle.Location = new System.Drawing.Point(470, 30);
            this.lblLightStatusTitle.Size = new System.Drawing.Size(81, 21);
            this.lblLightStatusTitle.Text = "Light Status";
            this.lblLightStatusTitle.UseMnemonic = false;
            this.lblLightStatusTitle.Name = "lblLightStatusTitle";
            this.lblLightStatusTitle.TabIndex = 5;
            // 
            // lblBulbIcon
            // 
            this.lblBulbIcon.AutoSize = true;
            this.lblBulbIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblBulbIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBulbIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.lblBulbIcon.Location = new System.Drawing.Point(470, 58);
            this.lblBulbIcon.Size = new System.Drawing.Size(22, 26);
            this.lblBulbIcon.Text = "\uEA80";
            this.lblBulbIcon.UseMnemonic = false;
            this.lblBulbIcon.Name = "lblBulbIcon";
            this.lblBulbIcon.TabIndex = 6;
            // 
            // lblLightStatus
            // 
            this.lblLightStatus.AutoSize = true;
            this.lblLightStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblLightStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLightStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.lblLightStatus.Location = new System.Drawing.Point(494, 54);
            this.lblLightStatus.Size = new System.Drawing.Size(90, 26);
            this.lblLightStatus.Text = "Lights On";
            this.lblLightStatus.UseMnemonic = false;
            this.lblLightStatus.Name = "lblLightStatus";
            this.lblLightStatus.TabIndex = 7;
            // 
            // lblBrightnessTitle
            // 
            this.lblBrightnessTitle.AutoSize = true;
            this.lblBrightnessTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBrightnessTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBrightnessTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblBrightnessTitle.Location = new System.Drawing.Point(640, 30);
            this.lblBrightnessTitle.Size = new System.Drawing.Size(68, 21);
            this.lblBrightnessTitle.Text = "Brightness";
            this.lblBrightnessTitle.UseMnemonic = false;
            this.lblBrightnessTitle.Name = "lblBrightnessTitle";
            this.lblBrightnessTitle.TabIndex = 8;
            // 
            // lblBrightnessValue
            // 
            this.lblBrightnessValue.AutoSize = false;
            this.lblBrightnessValue.BackColor = System.Drawing.Color.Transparent;
            this.lblBrightnessValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrightnessValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblBrightnessValue.Location = new System.Drawing.Point(830, 26);
            this.lblBrightnessValue.Size = new System.Drawing.Size(60, 24);
            this.lblBrightnessValue.Text = "75%";
            this.lblBrightnessValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBrightnessValue.UseMnemonic = false;
            this.lblBrightnessValue.Name = "lblBrightnessValue";
            this.lblBrightnessValue.TabIndex = 9;
            // 
            // trackBrightness
            // 
            this.trackBrightness.AutoSize = false;
            this.trackBrightness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(21)))), ((int)(((byte)(56)))));
            this.trackBrightness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBrightness.Location = new System.Drawing.Point(632, 62);
            this.trackBrightness.Maximum = 100;
            this.trackBrightness.Size = new System.Drawing.Size(262, 30);
            this.trackBrightness.TickFrequency = 10;
            this.trackBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBrightness.Value = 75;
            this.trackBrightness.Name = "trackBrightness";
            this.trackBrightness.TabIndex = 10;
            this.trackBrightness.Scroll += new System.EventHandler(this.trackBrightness_Scroll);
            // 
            // btnToggle
            // 
            this.btnToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnToggle.FlatAppearance.BorderSize = 0;
            this.btnToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(40)))), ((int)(((byte)(217)))));
            this.btnToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnToggle.Image = global::WinFormsApp2.Properties.Resources.btn_power;
            this.btnToggle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnToggle.Location = new System.Drawing.Point(924, 24);
            this.btnToggle.Size = new System.Drawing.Size(180, 40);
            this.btnToggle.Text = "Turn Off";
            this.btnToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnToggle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.TabIndex = 11;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(46)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.btnSettings.FlatAppearance.BorderSize = 1;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(27)))), ((int)(((byte)(69)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnSettings.Image = global::WinFormsApp2.Properties.Resources.btn_settings;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSettings.Location = new System.Drawing.Point(924, 72);
            this.btnSettings.Size = new System.Drawing.Size(180, 40);
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.TabIndex = 12;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // RoomRowUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.pnlRow);
            this.Size = new System.Drawing.Size(1122, 136);
            this.Name = "RoomRowUserControl";
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrightness)).EndInit();
            this.pnlRow.ResumeLayout(false);
            this.pnlRow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WinFormsApp2.Controls.RoundedPanel pnlRow;
        private System.Windows.Forms.PictureBox picRoom;
        private System.Windows.Forms.Label lblRoomIcon;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblRoomSubtitle;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Label lblLightStatusTitle;
        private System.Windows.Forms.Label lblBulbIcon;
        private System.Windows.Forms.Label lblLightStatus;
        private System.Windows.Forms.Label lblBrightnessTitle;
        private System.Windows.Forms.Label lblBrightnessValue;
        private System.Windows.Forms.TrackBar trackBrightness;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Button btnSettings;
    }
}
