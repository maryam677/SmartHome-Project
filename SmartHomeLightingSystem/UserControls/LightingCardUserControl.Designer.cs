namespace SmartHomeLightingSystem.UserControls
{
    partial class LightingCardUserControl
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
            this.pnlCard = new SmartHomeLightingSystem.Controls.RoundedPanel();
            this.lblOnline = new System.Windows.Forms.Label();
            this.lblFavorite = new System.Windows.Forms.Label();
            this.picRoom = new System.Windows.Forms.PictureBox();
            this.lblRoomIcon = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblRoomSubtitle = new System.Windows.Forms.Label();
            this.lblBulbIcon = new System.Windows.Forms.Label();
            this.lblLightStatus = new System.Windows.Forms.Label();
            this.lblSunIcon = new System.Windows.Forms.Label();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.lblBrightnessValue = new System.Windows.Forms.Label();
            this.trackBrightness = new System.Windows.Forms.TrackBar();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.Controls.Add(this.lblOnline);
            this.pnlCard.Controls.Add(this.lblFavorite);
            this.pnlCard.Controls.Add(this.picRoom);
            this.pnlCard.Controls.Add(this.lblRoomIcon);
            this.pnlCard.Controls.Add(this.lblRoomName);
            this.pnlCard.Controls.Add(this.lblRoomSubtitle);
            this.pnlCard.Controls.Add(this.lblBulbIcon);
            this.pnlCard.Controls.Add(this.lblLightStatus);
            this.pnlCard.Controls.Add(this.lblSunIcon);
            this.pnlCard.Controls.Add(this.lblBrightness);
            this.pnlCard.Controls.Add(this.lblBrightnessValue);
            this.pnlCard.Controls.Add(this.trackBrightness);
            this.pnlCard.Controls.Add(this.btnToggle);
            this.pnlCard.Controls.Add(this.btnSettings);
            this.pnlCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.pnlCard.BorderRadius = 16;
            this.pnlCard.BorderThickness = 1F;
            this.pnlCard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(21)))), ((int)(((byte)(56)))));
            this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard.Location = new System.Drawing.Point(0, 0);
            this.pnlCard.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlCard.Size = new System.Drawing.Size(266, 366);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.TabIndex = 0;
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(46)))));
            this.lblOnline.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOnline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(230)))), ((int)(((byte)(168)))));
            this.lblOnline.Location = new System.Drawing.Point(12, 12);
            this.lblOnline.Size = new System.Drawing.Size(59, 20);
            this.lblOnline.Text = "\u25CF Online";
            this.lblOnline.UseMnemonic = false;
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.TabIndex = 0;
            // 
            // lblFavorite
            // 
            this.lblFavorite.AutoSize = true;
            this.lblFavorite.BackColor = System.Drawing.Color.Transparent;
            this.lblFavorite.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFavorite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(21)))));
            this.lblFavorite.Location = new System.Drawing.Point(232, 12);
            this.lblFavorite.Size = new System.Drawing.Size(24, 28);
            this.lblFavorite.Text = "\uE735";
            this.lblFavorite.UseMnemonic = false;
            this.lblFavorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFavorite.Name = "lblFavorite";
            this.lblFavorite.TabIndex = 1;
            this.lblFavorite.Click += new System.EventHandler(this.lblFavorite_Click);
            // 
            // picRoom
            // 
            this.picRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(46)))));
            this.picRoom.Image = global::SmartHomeLightingSystem.Properties.Resources.living_room;
            this.picRoom.Location = new System.Drawing.Point(1, 1);
            this.picRoom.Size = new System.Drawing.Size(264, 150);
            this.picRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRoom.TabStop = false;
            this.picRoom.Name = "picRoom";
            this.picRoom.TabIndex = 2;
            // 
            // lblRoomIcon
            // 
            this.lblRoomIcon.AutoSize = true;
            this.lblRoomIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRoomIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.lblRoomIcon.Location = new System.Drawing.Point(16, 166);
            this.lblRoomIcon.Size = new System.Drawing.Size(28, 32);
            this.lblRoomIcon.Text = "\uE7F4";
            this.lblRoomIcon.UseMnemonic = false;
            this.lblRoomIcon.Name = "lblRoomIcon";
            this.lblRoomIcon.TabIndex = 3;
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoomName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblRoomName.Location = new System.Drawing.Point(46, 160);
            this.lblRoomName.Size = new System.Drawing.Size(117, 28);
            this.lblRoomName.Text = "Living Room";
            this.lblRoomName.UseMnemonic = false;
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.TabIndex = 4;
            // 
            // lblRoomSubtitle
            // 
            this.lblRoomSubtitle.AutoSize = true;
            this.lblRoomSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRoomSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblRoomSubtitle.Location = new System.Drawing.Point(47, 186);
            this.lblRoomSubtitle.Size = new System.Drawing.Size(87, 21);
            this.lblRoomSubtitle.Text = "Relax & Enjoy";
            this.lblRoomSubtitle.UseMnemonic = false;
            this.lblRoomSubtitle.Name = "lblRoomSubtitle";
            this.lblRoomSubtitle.TabIndex = 5;
            // 
            // lblBulbIcon
            // 
            this.lblBulbIcon.AutoSize = true;
            this.lblBulbIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblBulbIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBulbIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.lblBulbIcon.Location = new System.Drawing.Point(17, 219);
            this.lblBulbIcon.Size = new System.Drawing.Size(20, 24);
            this.lblBulbIcon.Text = "\uEA80";
            this.lblBulbIcon.UseMnemonic = false;
            this.lblBulbIcon.Name = "lblBulbIcon";
            this.lblBulbIcon.TabIndex = 6;
            // 
            // lblLightStatus
            // 
            this.lblLightStatus.AutoSize = true;
            this.lblLightStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblLightStatus.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLightStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.lblLightStatus.Location = new System.Drawing.Point(40, 215);
            this.lblLightStatus.Size = new System.Drawing.Size(79, 23);
            this.lblLightStatus.Text = "Lights On";
            this.lblLightStatus.UseMnemonic = false;
            this.lblLightStatus.Name = "lblLightStatus";
            this.lblLightStatus.TabIndex = 7;
            // 
            // lblSunIcon
            // 
            this.lblSunIcon.AutoSize = true;
            this.lblSunIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblSunIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSunIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblSunIcon.Location = new System.Drawing.Point(17, 247);
            this.lblSunIcon.Size = new System.Drawing.Size(19, 23);
            this.lblSunIcon.Text = "\uE706";
            this.lblSunIcon.UseMnemonic = false;
            this.lblSunIcon.Name = "lblSunIcon";
            this.lblSunIcon.TabIndex = 8;
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.BackColor = System.Drawing.Color.Transparent;
            this.lblBrightness.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBrightness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblBrightness.Location = new System.Drawing.Point(40, 244);
            this.lblBrightness.Size = new System.Drawing.Size(72, 22);
            this.lblBrightness.Text = "Brightness";
            this.lblBrightness.UseMnemonic = false;
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.TabIndex = 9;
            // 
            // lblBrightnessValue
            // 
            this.lblBrightnessValue.AutoSize = false;
            this.lblBrightnessValue.BackColor = System.Drawing.Color.Transparent;
            this.lblBrightnessValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrightnessValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblBrightnessValue.Location = new System.Drawing.Point(192, 242);
            this.lblBrightnessValue.Size = new System.Drawing.Size(58, 22);
            this.lblBrightnessValue.Text = "75%";
            this.lblBrightnessValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBrightnessValue.UseMnemonic = false;
            this.lblBrightnessValue.Name = "lblBrightnessValue";
            this.lblBrightnessValue.TabIndex = 10;
            // 
            // trackBrightness
            // 
            this.trackBrightness.AutoSize = false;
            this.trackBrightness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(21)))), ((int)(((byte)(56)))));
            this.trackBrightness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBrightness.Location = new System.Drawing.Point(10, 270);
            this.trackBrightness.Maximum = 100;
            this.trackBrightness.Size = new System.Drawing.Size(246, 30);
            this.trackBrightness.TickFrequency = 10;
            this.trackBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBrightness.Value = 75;
            this.trackBrightness.Name = "trackBrightness";
            this.trackBrightness.TabIndex = 11;
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
            this.btnToggle.Image = global::SmartHomeLightingSystem.Properties.Resources.btn_power;
            this.btnToggle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnToggle.Location = new System.Drawing.Point(16, 310);
            this.btnToggle.Size = new System.Drawing.Size(114, 38);
            this.btnToggle.Text = "Turn Off";
            this.btnToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnToggle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.TabIndex = 12;
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
            this.btnSettings.Image = global::SmartHomeLightingSystem.Properties.Resources.btn_settings;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSettings.Location = new System.Drawing.Point(138, 310);
            this.btnSettings.Size = new System.Drawing.Size(112, 38);
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.TabIndex = 13;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // LightingCardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.pnlCard);
            this.Size = new System.Drawing.Size(266, 366);
            this.Name = "LightingCardUserControl";
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrightness)).EndInit();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SmartHomeLightingSystem.Controls.RoundedPanel pnlCard;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Label lblFavorite;
        private System.Windows.Forms.PictureBox picRoom;
        private System.Windows.Forms.Label lblRoomIcon;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblRoomSubtitle;
        private System.Windows.Forms.Label lblBulbIcon;
        private System.Windows.Forms.Label lblLightStatus;
        private System.Windows.Forms.Label lblSunIcon;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.Label lblBrightnessValue;
        private System.Windows.Forms.TrackBar trackBrightness;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Button btnSettings;
    }
}
