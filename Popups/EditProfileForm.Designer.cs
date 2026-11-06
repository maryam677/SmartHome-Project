namespace WinFormsApp2.Popups
{
    partial class EditProfileForm
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
            lblTitle = new Label();
            picProfile = new PictureBox();
            btnChangePicture = new Button();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            lblSubtitle = new Label();
            lblFullName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            btnCancel = new Button();
            btnsave = new Button();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(25, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(176, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Edit Profile";
            // 
            // picProfile
            // 
            picProfile.BackColor = Color.FromArgb(48, 54, 93);
            picProfile.Image = Properties.Resources.user_solid;
            picProfile.Location = new Point(190, 90);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(70, 70);
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picProfile.TabIndex = 1;
            picProfile.TabStop = false;
            // 
            // btnChangePicture
            // 
            btnChangePicture.BackColor = Color.FromArgb(48, 54, 93);
            btnChangePicture.FlatStyle = FlatStyle.Flat;
            btnChangePicture.Location = new Point(160, 165);
            btnChangePicture.Name = "btnChangePicture";
            btnChangePicture.Size = new Size(134, 33);
            btnChangePicture.TabIndex = 2;
            btnChangePicture.Text = "Change Picture";
            btnChangePicture.UseVisualStyleBackColor = false;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.FromArgb(48, 54, 93);
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Location = new Point(25, 230);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(400, 30);
            txtFullName.TabIndex = 3;
            txtFullName.Text = "Student User";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(48, 54, 93);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(25, 305);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(400, 30);
            txtEmail.TabIndex = 4;
            txtEmail.Text = "student@smarthome.com";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(48, 54, 93);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(25, 381);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(400, 30);
            txtPhone.TabIndex = 5;
            txtPhone.Text = "+20 XXX XXX XXXX";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.LightGray;
            lblSubtitle.Location = new Point(25, 55);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(269, 23);
            lblSubtitle.TabIndex = 6;
            lblSubtitle.Text = "Update your personal information";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(25, 205);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(87, 23);
            lblFullName.TabIndex = 7;
            lblFullName.Text = "Full Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(25, 280);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(116, 23);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email Address";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(25, 355);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(127, 23);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Phone Number";
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(91, 436);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 38);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.DarkSlateBlue;
            btnsave.Cursor = Cursors.Hand;
            btnsave.FlatAppearance.BorderSize = 0;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(231, 436);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(160, 38);
            btnsave.TabIndex = 18;
            btnsave.Text = "Save Changes";
            btnsave.UseVisualStyleBackColor = false;
            // 
            // EditProfileForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 32, 70);
            ClientSize = new Size(456, 496);
            Controls.Add(btnCancel);
            Controls.Add(btnsave);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblFullName);
            Controls.Add(lblSubtitle);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(btnChangePicture);
            Controls.Add(picProfile);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Profile";
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox picProfile;
        private Button btnChangePicture;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label lblSubtitle;
        private Label lblFullName;
        private Label lblEmail;
        private Label lblPhone;
        private Button btnCancel;
        private Button btnsave;
    }
}