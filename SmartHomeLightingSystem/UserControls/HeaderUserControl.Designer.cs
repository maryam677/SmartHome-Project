namespace SmartHomeLightingSystem.UserControls
{
    partial class HeaderUserControl
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
            this.lblNotificationDot = new System.Windows.Forms.Label();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlLogo = new SmartHomeLightingSystem.Controls.RoundedPanel();
            this.lblLogoIcon = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblAppSubtitle = new System.Windows.Forms.Label();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNotificationDot
            // 
            this.lblNotificationDot.AutoSize = true;
            this.lblNotificationDot.BackColor = System.Drawing.Color.Transparent;
            this.lblNotificationDot.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNotificationDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(72)))), ((int)(((byte)(153)))));
            this.lblNotificationDot.Location = new System.Drawing.Point(1244, 15);
            this.lblNotificationDot.Size = new System.Drawing.Size(10, 17);
            this.lblNotificationDot.Text = "\u25CF";
            this.lblNotificationDot.UseMnemonic = false;
            this.lblNotificationDot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotificationDot.Name = "lblNotificationDot";
            this.lblNotificationDot.TabIndex = 0;
            // 
            // btnNotifications
            // 
            this.btnNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.btnNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotifications.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.btnNotifications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(27)))), ((int)(((byte)(69)))));
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNotifications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.btnNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotifications.Location = new System.Drawing.Point(1222, 16);
            this.btnNotifications.Size = new System.Drawing.Size(40, 38);
            this.btnNotifications.Text = "\uEA8F";
            this.btnNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNotifications.UseVisualStyleBackColor = false;
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.TabIndex = 1;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(27)))), ((int)(((byte)(69)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Location = new System.Drawing.Point(1268, 16);
            this.btnMinimize.Size = new System.Drawing.Size(40, 38);
            this.btnMinimize.Text = "\uE921";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(27)))), ((int)(((byte)(69)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Location = new System.Drawing.Point(1310, 16);
            this.btnMaximize.Size = new System.Drawing.Size(40, 38);
            this.btnMaximize.Text = "\uE922";
            this.btnMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1352, 16);
            this.btnClose.Size = new System.Drawing.Size(40, 38);
            this.btnClose.Text = "\uE8BB";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.TabIndex = 4;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblLogoIcon);
            this.pnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.pnlLogo.BorderRadius = 12;
            this.pnlLogo.BorderThickness = 1F;
            this.pnlLogo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.pnlLogo.Location = new System.Drawing.Point(20, 12);
            this.pnlLogo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlLogo.Size = new System.Drawing.Size(46, 46);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.TabIndex = 5;
            // 
            // lblLogoIcon
            // 
            this.lblLogoIcon.AutoSize = true;
            this.lblLogoIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblLogoIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogoIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblLogoIcon.Location = new System.Drawing.Point(10, 10);
            this.lblLogoIcon.Size = new System.Drawing.Size(32, 36);
            this.lblLogoIcon.Text = "\uE80F";
            this.lblLogoIcon.UseMnemonic = false;
            this.lblLogoIcon.Name = "lblLogoIcon";
            this.lblLogoIcon.TabIndex = 0;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAppTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblAppTitle.Location = new System.Drawing.Point(74, 10);
            this.lblAppTitle.Size = new System.Drawing.Size(111, 32);
            this.lblAppTitle.Text = "SmartHome";
            this.lblAppTitle.UseMnemonic = false;
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.TabIndex = 6;
            this.lblAppTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.lblAppTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.lblAppTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // lblAppSubtitle
            // 
            this.lblAppSubtitle.AutoSize = true;
            this.lblAppSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAppSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAppSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblAppSubtitle.Location = new System.Drawing.Point(76, 40);
            this.lblAppSubtitle.Size = new System.Drawing.Size(100, 21);
            this.lblAppSubtitle.Text = "Lighting System";
            this.lblAppSubtitle.UseMnemonic = false;
            this.lblAppSubtitle.Name = "lblAppSubtitle";
            this.lblAppSubtitle.TabIndex = 7;
            this.lblAppSubtitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.lblAppSubtitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.lblAppSubtitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // HeaderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.lblNotificationDot);
            this.Controls.Add(this.btnNotifications);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.lblAppTitle);
            this.Controls.Add(this.lblAppSubtitle);
            this.Size = new System.Drawing.Size(1400, 70);
            this.Name = "HeaderUserControl";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotificationDot;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private SmartHomeLightingSystem.Controls.RoundedPanel pnlLogo;
        private System.Windows.Forms.Label lblLogoIcon;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblAppSubtitle;
    }
}
