namespace WinFormsApp2.UserControls
{
    partial class NotificationsControl
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
            lblTitle = new Label();
            lblSubtitle = new Label();
            btnMarkAllRead = new Button();
            btnAll = new Button();
            btnUnread = new Button();
            pnlNotification1 = new Panel();
            lblTime = new Label();
            lblDescription = new Label();
            lblTitlelab = new Label();
            pnlNotification2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pnlNotification4 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            pnlNotification3 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pnlNotification1.SuspendLayout();
            pnlNotification2.SuspendLayout();
            pnlNotification4.SuspendLayout();
            pnlNotification3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(281, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "All Notifications";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(25, 66);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(305, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Manage your smart home alerts and updates";
            // 
            // btnMarkAllRead
            // 
            btnMarkAllRead.FlatAppearance.BorderSize = 0;
            btnMarkAllRead.FlatStyle = FlatStyle.Flat;
            btnMarkAllRead.Location = new Point(850, 25);
            btnMarkAllRead.Name = "btnMarkAllRead";
            btnMarkAllRead.Size = new Size(170, 38);
            btnMarkAllRead.TabIndex = 2;
            btnMarkAllRead.Text = "Mark All as Read";
            btnMarkAllRead.UseVisualStyleBackColor = true;
            btnMarkAllRead.Click += btnMarkAllRead_Click;
            // 
            // btnAll
            // 
            btnAll.BackColor = Color.FromArgb(128, 128, 255);
            btnAll.FlatAppearance.BorderSize = 0;
            btnAll.FlatStyle = FlatStyle.Flat;
            btnAll.Location = new Point(25, 110);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(90, 35);
            btnAll.TabIndex = 3;
            btnAll.Text = "All";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // btnUnread
            // 
            btnUnread.FlatAppearance.BorderSize = 0;
            btnUnread.FlatStyle = FlatStyle.Popup;
            btnUnread.Location = new Point(125, 110);
            btnUnread.Name = "btnUnread";
            btnUnread.Size = new Size(120, 35);
            btnUnread.TabIndex = 4;
            btnUnread.Text = "Unread (2)";
            btnUnread.UseVisualStyleBackColor = true;
            btnUnread.Click += btnUnread_Click;
            // 
            // pnlNotification1
            // 
            pnlNotification1.BackColor = Color.FromArgb(41, 46, 92);
            pnlNotification1.Controls.Add(lblTime);
            pnlNotification1.Controls.Add(lblDescription);
            pnlNotification1.Controls.Add(lblTitlelab);
            pnlNotification1.Location = new Point(25, 165);
            pnlNotification1.Name = "pnlNotification1";
            pnlNotification1.Size = new Size(1025, 105);
            pnlNotification1.TabIndex = 5;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(25, 75);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(42, 20);
            lblTime.TabIndex = 2;
            lblTime.Text = "Time";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(25, 43);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(96, 23);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Description";
            // 
            // lblTitlelab
            // 
            lblTitlelab.AutoSize = true;
            lblTitlelab.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitlelab.Location = new Point(25, 12);
            lblTitlelab.Name = "lblTitlelab";
            lblTitlelab.Size = new Size(55, 28);
            lblTitlelab.TabIndex = 0;
            lblTitlelab.Text = "Title";
            // 
            // pnlNotification2
            // 
            pnlNotification2.BackColor = Color.FromArgb(41, 46, 92);
            pnlNotification2.Controls.Add(label1);
            pnlNotification2.Controls.Add(label2);
            pnlNotification2.Controls.Add(label3);
            pnlNotification2.Location = new Point(25, 298);
            pnlNotification2.Name = "pnlNotification2";
            pnlNotification2.Size = new Size(1025, 105);
            pnlNotification2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 76);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 5;
            label1.Text = "Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 44);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 4;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 13);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 3;
            label3.Text = "Title";
            // 
            // pnlNotification4
            // 
            pnlNotification4.BackColor = Color.FromArgb(32, 38, 77);
            pnlNotification4.Controls.Add(label7);
            pnlNotification4.Controls.Add(label8);
            pnlNotification4.Controls.Add(label9);
            pnlNotification4.Location = new Point(25, 564);
            pnlNotification4.Name = "pnlNotification4";
            pnlNotification4.Size = new Size(1025, 105);
            pnlNotification4.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 74);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 5;
            label7.Text = "Time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(25, 42);
            label8.Name = "label8";
            label8.Size = new Size(96, 23);
            label8.TabIndex = 4;
            label8.Text = "Description";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 11);
            label9.Name = "label9";
            label9.Size = new Size(55, 28);
            label9.TabIndex = 3;
            label9.Text = "Title";
            // 
            // pnlNotification3
            // 
            pnlNotification3.BackColor = Color.FromArgb(32, 38, 77);
            pnlNotification3.Controls.Add(label4);
            pnlNotification3.Controls.Add(label5);
            pnlNotification3.Controls.Add(label6);
            pnlNotification3.Location = new Point(25, 431);
            pnlNotification3.Name = "pnlNotification3";
            pnlNotification3.Size = new Size(1025, 105);
            pnlNotification3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 74);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 5;
            label4.Text = "Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 42);
            label5.Name = "label5";
            label5.Size = new Size(96, 23);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 11);
            label6.Name = "label6";
            label6.Size = new Size(55, 28);
            label6.TabIndex = 3;
            label6.Text = "Title";
            // 
            // NotificationsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(10, 15, 38);
            Controls.Add(pnlNotification3);
            Controls.Add(pnlNotification4);
            Controls.Add(pnlNotification2);
            Controls.Add(pnlNotification1);
            Controls.Add(btnUnread);
            Controls.Add(btnAll);
            Controls.Add(btnMarkAllRead);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            ForeColor = Color.White;
            Name = "NotificationsControl";
            Size = new Size(1100, 750);
            pnlNotification1.ResumeLayout(false);
            pnlNotification1.PerformLayout();
            pnlNotification2.ResumeLayout(false);
            pnlNotification2.PerformLayout();
            pnlNotification4.ResumeLayout(false);
            pnlNotification4.PerformLayout();
            pnlNotification3.ResumeLayout(false);
            pnlNotification3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnMarkAllRead;
        private Button btnAll;
        private Button btnUnread;
        private Panel pnlNotification1;
        private Panel pnlNotification2;
        private Panel pnlNotification4;
        private Panel pnlNotification3;
        private Label lblTime;
        private Label lblDescription;
        private Label lblTitlelab;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
