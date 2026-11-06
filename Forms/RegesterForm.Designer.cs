namespace WinFormsApp2.Forms
{
    partial class RegesterForm
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
            lblName = new Label();
            txtFullName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirm = new Label();
            txtConfirmPassword = new TextBox();
            chkTerms = new CheckBox();
            btnRegister = new Button();
            btnGoLogin = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(100, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(157, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create Account";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(76, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(30, 105);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(360, 27);
            txtFullName.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 155);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(103, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email Address";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(30, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(360, 27);
            txtEmail.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(30, 230);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(30, 255);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(360, 27);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new Point(30, 305);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(127, 20);
            lblConfirm.TabIndex = 7;
            lblConfirm.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(30, 330);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(360, 27);
            txtConfirmPassword.TabIndex = 8;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // chkTerms
            // 
            chkTerms.AutoSize = true;
            chkTerms.Location = new Point(30, 390);
            chkTerms.Name = "chkTerms";
            chkTerms.Size = new Size(163, 24);
            chkTerms.TabIndex = 9;
            chkTerms.Text = "I agree to the Terms";
            chkTerms.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Location = new Point(30, 440);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Create Account";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnGoLogin
            // 
            btnGoLogin.FlatAppearance.BorderSize = 0;
            btnGoLogin.FlatStyle = FlatStyle.Flat;
            btnGoLogin.Location = new Point(270, 510);
            btnGoLogin.Name = "btnGoLogin";
            btnGoLogin.Size = new Size(94, 29);
            btnGoLogin.TabIndex = 11;
            btnGoLogin.Text = "Sign In";
            btnGoLogin.UseVisualStyleBackColor = true;
            // 
            // RegesterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 15, 38);
            ClientSize = new Size(502, 673);
            Controls.Add(btnGoLogin);
            Controls.Add(btnRegister);
            Controls.Add(chkTerms);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirm);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtFullName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegesterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Smart Home - Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private TextBox txtFullName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirm;
        private TextBox txtConfirmPassword;
        private CheckBox chkTerms;
        private Button btnRegister;
        private Button btnGoLogin;
    }
}