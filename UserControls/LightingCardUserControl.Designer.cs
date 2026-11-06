namespace WinFormsApp2.UserControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LightingCardUserControl));
            pnlCard = new WinFormsApp2.Controls.RoundedPanel();
            lblOnline = new Label();
            lblFavorite = new Label();
            picRoom = new PictureBox();
            lblRoomIcon = new Label();
            lblRoomName = new Label();
            lblRoomSubtitle = new Label();
            lblBulbIcon = new Label();
            lblLightStatus = new Label();
            lblSunIcon = new Label();
            lblBrightness = new Label();
            lblBrightnessValue = new Label();
            trackBrightness = new TrackBar();
            btnToggle = new Button();
            btnSettings = new Button();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBrightness).BeginInit();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.Transparent;
            pnlCard.BorderColor = Color.FromArgb(56, 43, 99);
            pnlCard.BorderRadius = 16;
            pnlCard.BorderThickness = 1F;
            pnlCard.Controls.Add(lblOnline);
            pnlCard.Controls.Add(lblFavorite);
            pnlCard.Controls.Add(picRoom);
            pnlCard.Controls.Add(lblRoomIcon);
            pnlCard.Controls.Add(lblRoomName);
            pnlCard.Controls.Add(lblRoomSubtitle);
            pnlCard.Controls.Add(lblBulbIcon);
            pnlCard.Controls.Add(lblLightStatus);
            pnlCard.Controls.Add(lblSunIcon);
            pnlCard.Controls.Add(lblBrightness);
            pnlCard.Controls.Add(lblBrightnessValue);
            pnlCard.Controls.Add(trackBrightness);
            pnlCard.Controls.Add(btnToggle);
            pnlCard.Controls.Add(btnSettings);
            pnlCard.Dock = DockStyle.Fill;
            pnlCard.FillColor = Color.FromArgb(27, 21, 56);
            pnlCard.Location = new Point(0, 0);
            pnlCard.Margin = new Padding(3, 4, 3, 4);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(304, 488);
            pnlCard.TabIndex = 0;
            // 
            // lblOnline
            // 
            lblOnline.AutoSize = true;
            lblOnline.BackColor = Color.FromArgb(21, 17, 46);
            lblOnline.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblOnline.ForeColor = Color.FromArgb(34, 230, 168);
            lblOnline.Location = new Point(14, 16);
            lblOnline.Name = "lblOnline";
            lblOnline.Size = new Size(67, 20);
            lblOnline.TabIndex = 0;
            lblOnline.Text = "● Online";
            lblOnline.UseMnemonic = false;
            // 
            // lblFavorite
            // 
            lblFavorite.AutoSize = true;
            lblFavorite.BackColor = Color.Transparent;
            lblFavorite.Cursor = Cursors.Hand;
            lblFavorite.Font = new Font("Segoe MDL2 Assets", 13F);
            lblFavorite.ForeColor = Color.FromArgb(250, 204, 21);
            lblFavorite.Location = new Point(265, 16);
            lblFavorite.Name = "lblFavorite";
            lblFavorite.Size = new Size(32, 22);
            lblFavorite.TabIndex = 1;
            lblFavorite.Text = "";
            lblFavorite.UseMnemonic = false;
            lblFavorite.Click += lblFavorite_Click;
            // 
            // picRoom
            // 
            picRoom.BackColor = Color.FromArgb(21, 17, 46);
            picRoom.Image = (Image)resources.GetObject("picRoom.Image");
            picRoom.Location = new Point(1, 1);
            picRoom.Margin = new Padding(3, 4, 3, 4);
            picRoom.Name = "picRoom";
            picRoom.Size = new Size(302, 200);
            picRoom.SizeMode = PictureBoxSizeMode.StretchImage;
            picRoom.TabIndex = 2;
            picRoom.TabStop = false;
            // 
            // lblRoomIcon
            // 
            lblRoomIcon.AutoSize = true;
            lblRoomIcon.BackColor = Color.Transparent;
            lblRoomIcon.Font = new Font("Segoe MDL2 Assets", 15F);
            lblRoomIcon.ForeColor = Color.FromArgb(192, 132, 252);
            lblRoomIcon.Location = new Point(18, 221);
            lblRoomIcon.Name = "lblRoomIcon";
            lblRoomIcon.Size = new Size(37, 25);
            lblRoomIcon.TabIndex = 3;
            lblRoomIcon.Text = "";
            lblRoomIcon.UseMnemonic = false;
            // 
            // lblRoomName
            // 
            lblRoomName.AutoSize = true;
            lblRoomName.BackColor = Color.Transparent;
            lblRoomName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblRoomName.ForeColor = Color.FromArgb(248, 250, 252);
            lblRoomName.Location = new Point(53, 213);
            lblRoomName.Name = "lblRoomName";
            lblRoomName.Size = new Size(140, 30);
            lblRoomName.TabIndex = 4;
            lblRoomName.Text = "Living Room";
            lblRoomName.UseMnemonic = false;
            // 
            // lblRoomSubtitle
            // 
            lblRoomSubtitle.AutoSize = true;
            lblRoomSubtitle.BackColor = Color.Transparent;
            lblRoomSubtitle.Font = new Font("Segoe UI", 9F);
            lblRoomSubtitle.ForeColor = Color.FromArgb(165, 161, 194);
            lblRoomSubtitle.Location = new Point(54, 248);
            lblRoomSubtitle.Name = "lblRoomSubtitle";
            lblRoomSubtitle.Size = new Size(101, 20);
            lblRoomSubtitle.TabIndex = 5;
            lblRoomSubtitle.Text = "Relax & Enjoy";
            lblRoomSubtitle.UseMnemonic = false;
            // 
            // lblBulbIcon
            // 
            lblBulbIcon.AutoSize = true;
            lblBulbIcon.BackColor = Color.Transparent;
            lblBulbIcon.Font = new Font("Segoe MDL2 Assets", 11F);
            lblBulbIcon.ForeColor = Color.FromArgb(168, 85, 247);
            lblBulbIcon.Location = new Point(19, 292);
            lblBulbIcon.Name = "lblBulbIcon";
            lblBulbIcon.Size = new Size(28, 19);
            lblBulbIcon.TabIndex = 6;
            lblBulbIcon.Text = "";
            lblBulbIcon.UseMnemonic = false;
            // 
            // lblLightStatus
            // 
            lblLightStatus.AutoSize = true;
            lblLightStatus.BackColor = Color.Transparent;
            lblLightStatus.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblLightStatus.ForeColor = Color.FromArgb(168, 85, 247);
            lblLightStatus.Location = new Point(46, 287);
            lblLightStatus.Name = "lblLightStatus";
            lblLightStatus.Size = new Size(93, 25);
            lblLightStatus.TabIndex = 7;
            lblLightStatus.Text = "Lights On";
            lblLightStatus.UseMnemonic = false;
            // 
            // lblSunIcon
            // 
            lblSunIcon.AutoSize = true;
            lblSunIcon.BackColor = Color.Transparent;
            lblSunIcon.Font = new Font("Segoe MDL2 Assets", 10F);
            lblSunIcon.ForeColor = Color.FromArgb(165, 161, 194);
            lblSunIcon.Location = new Point(19, 329);
            lblSunIcon.Name = "lblSunIcon";
            lblSunIcon.Size = new Size(25, 17);
            lblSunIcon.TabIndex = 8;
            lblSunIcon.Text = "";
            lblSunIcon.UseMnemonic = false;
            // 
            // lblBrightness
            // 
            lblBrightness.AutoSize = true;
            lblBrightness.BackColor = Color.Transparent;
            lblBrightness.Font = new Font("Segoe UI", 9.5F);
            lblBrightness.ForeColor = Color.FromArgb(165, 161, 194);
            lblBrightness.Location = new Point(46, 325);
            lblBrightness.Name = "lblBrightness";
            lblBrightness.Size = new Size(83, 21);
            lblBrightness.TabIndex = 9;
            lblBrightness.Text = "Brightness";
            lblBrightness.UseMnemonic = false;
            // 
            // lblBrightnessValue
            // 
            lblBrightnessValue.BackColor = Color.Transparent;
            lblBrightnessValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBrightnessValue.ForeColor = Color.FromArgb(248, 250, 252);
            lblBrightnessValue.Location = new Point(219, 323);
            lblBrightnessValue.Name = "lblBrightnessValue";
            lblBrightnessValue.Size = new Size(66, 29);
            lblBrightnessValue.TabIndex = 10;
            lblBrightnessValue.Text = "75%";
            lblBrightnessValue.TextAlign = ContentAlignment.MiddleRight;
            lblBrightnessValue.UseMnemonic = false;
            // 
            // trackBrightness
            // 
            trackBrightness.AutoSize = false;
            trackBrightness.BackColor = Color.FromArgb(27, 21, 56);
            trackBrightness.Cursor = Cursors.Hand;
            trackBrightness.Location = new Point(11, 360);
            trackBrightness.Margin = new Padding(3, 4, 3, 4);
            trackBrightness.Maximum = 100;
            trackBrightness.Name = "trackBrightness";
            trackBrightness.Size = new Size(281, 40);
            trackBrightness.TabIndex = 11;
            trackBrightness.TickFrequency = 10;
            trackBrightness.TickStyle = TickStyle.None;
            trackBrightness.Value = 75;
            trackBrightness.Scroll += trackBrightness_Scroll;
            // 
            // btnToggle
            // 
            btnToggle.BackColor = Color.FromArgb(124, 58, 237);
            btnToggle.Cursor = Cursors.Hand;
            btnToggle.FlatAppearance.BorderColor = Color.FromArgb(124, 58, 237);
            btnToggle.FlatAppearance.BorderSize = 0;
            btnToggle.FlatAppearance.MouseDownBackColor = Color.FromArgb(109, 40, 217);
            btnToggle.FlatAppearance.MouseOverBackColor = Color.FromArgb(139, 92, 246);
            btnToggle.FlatStyle = FlatStyle.Flat;
            btnToggle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnToggle.ForeColor = Color.FromArgb(248, 250, 252);
            btnToggle.Location = new Point(18, 413);
            btnToggle.Margin = new Padding(3, 4, 3, 4);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(130, 51);
            btnToggle.TabIndex = 12;
            btnToggle.Text = "Turn Off";
            btnToggle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnToggle.UseVisualStyleBackColor = false;
            btnToggle.Click += btnToggle_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(21, 17, 46);
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderColor = Color.FromArgb(56, 43, 99);
            btnSettings.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 33, 86);
            btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 27, 69);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSettings.ForeColor = Color.FromArgb(216, 204, 255);
            btnSettings.Location = new Point(158, 413);
            btnSettings.Margin = new Padding(3, 4, 3, 4);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(128, 51);
            btnSettings.TabIndex = 13;
            btnSettings.Text = "Settings";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // LightingCardUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 8, 23);
            Controls.Add(pnlCard);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LightingCardUserControl";
            Size = new Size(304, 488);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBrightness).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private WinFormsApp2.Controls.RoundedPanel pnlCard;
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
