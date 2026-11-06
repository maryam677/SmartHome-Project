namespace WinFormsApp2.UserControls
{
    partial class QuickActionsUserControl
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
            this.pnlQuick = new WinFormsApp2.Controls.RoundedPanel();
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnAllOn = new System.Windows.Forms.Button();
            this.btnAllOff = new System.Windows.Forms.Button();
            this.btnNightMode = new System.Windows.Forms.Button();
            this.btnRelaxMode = new System.Windows.Forms.Button();
            this.pnlQuick.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlQuick
            // 
            this.pnlQuick.Controls.Add(this.lblIcon);
            this.pnlQuick.Controls.Add(this.lblTitle);
            this.pnlQuick.Controls.Add(this.lblSubtitle);
            this.pnlQuick.Controls.Add(this.btnAllOn);
            this.pnlQuick.Controls.Add(this.btnAllOff);
            this.pnlQuick.Controls.Add(this.btnNightMode);
            this.pnlQuick.Controls.Add(this.btnRelaxMode);
            this.pnlQuick.BackColor = System.Drawing.Color.Transparent;
            this.pnlQuick.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.pnlQuick.BorderRadius = 16;
            this.pnlQuick.BorderThickness = 1F;
            this.pnlQuick.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(21)))), ((int)(((byte)(56)))));
            this.pnlQuick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuick.Location = new System.Drawing.Point(0, 0);
            this.pnlQuick.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlQuick.Size = new System.Drawing.Size(408, 210);
            this.pnlQuick.Name = "pnlQuick";
            this.pnlQuick.TabIndex = 0;
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.lblIcon.Location = new System.Drawing.Point(18, 18);
            this.lblIcon.Size = new System.Drawing.Size(30, 34);
            this.lblIcon.Text = "\uE945";
            this.lblIcon.UseMnemonic = false;
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblTitle.Location = new System.Drawing.Point(46, 12);
            this.lblTitle.Size = new System.Drawing.Size(127, 26);
            this.lblTitle.Text = "Quick Actions";
            this.lblTitle.UseMnemonic = false;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 1;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblSubtitle.Location = new System.Drawing.Point(47, 37);
            this.lblSubtitle.Size = new System.Drawing.Size(144, 21);
            this.lblSubtitle.Text = "Control with one click";
            this.lblSubtitle.UseMnemonic = false;
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.TabIndex = 2;
            // 
            // btnAllOn
            // 
            this.btnAllOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(46)))));
            this.btnAllOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllOn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.btnAllOn.FlatAppearance.BorderSize = 1;
            this.btnAllOn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.btnAllOn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(27)))), ((int)(((byte)(69)))));
            this.btnAllOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllOn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAllOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnAllOn.Image = global::WinFormsApp2.Properties.Resources.qa_all_on;
            this.btnAllOn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAllOn.Location = new System.Drawing.Point(18, 70);
            this.btnAllOn.Padding = new System.Windows.Forms.Padding(0, 12, 0, 8);
            this.btnAllOn.Size = new System.Drawing.Size(86, 118);
            this.btnAllOn.Text = "All\r\nLights ON";
            this.btnAllOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAllOn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAllOn.UseVisualStyleBackColor = false;
            this.btnAllOn.Name = "btnAllOn";
            this.btnAllOn.TabIndex = 3;
            this.btnAllOn.Click += new System.EventHandler(this.btnAllOn_Click);
            // 
            // btnAllOff
            // 
            this.btnAllOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(46)))));
            this.btnAllOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllOff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.btnAllOff.FlatAppearance.BorderSize = 1;
            this.btnAllOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.btnAllOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(27)))), ((int)(((byte)(69)))));
            this.btnAllOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllOff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAllOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnAllOff.Image = null;
            this.btnAllOff.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAllOff.Location = new System.Drawing.Point(112, 70);
            this.btnAllOff.Padding = new System.Windows.Forms.Padding(0, 12, 0, 8);
            this.btnAllOff.Size = new System.Drawing.Size(86, 118);
            this.btnAllOff.Text = "All\r\nLights OFF";
            this.btnAllOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAllOff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAllOff.UseVisualStyleBackColor = false;
            this.btnAllOff.Name = "btnAllOff";
            this.btnAllOff.TabIndex = 4;
            this.btnAllOff.Click += new System.EventHandler(this.btnAllOff_Click);
            // 
            // btnNightMode
            // 
            this.btnNightMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(46)))));
            this.btnNightMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNightMode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.btnNightMode.FlatAppearance.BorderSize = 1;
            this.btnNightMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.btnNightMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(27)))), ((int)(((byte)(69)))));
            this.btnNightMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNightMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNightMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnNightMode.Image = null;
            this.btnNightMode.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNightMode.Location = new System.Drawing.Point(206, 70);
            this.btnNightMode.Padding = new System.Windows.Forms.Padding(0, 12, 0, 8);
            this.btnNightMode.Size = new System.Drawing.Size(86, 118);
            this.btnNightMode.Text = "Night\r\nMode";
            this.btnNightMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNightMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNightMode.UseVisualStyleBackColor = false;
            this.btnNightMode.Name = "btnNightMode";
            this.btnNightMode.TabIndex = 5;
            this.btnNightMode.Click += new System.EventHandler(this.btnNightMode_Click);
            // 
            // btnRelaxMode
            // 
            this.btnRelaxMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(46)))));
            this.btnRelaxMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelaxMode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.btnRelaxMode.FlatAppearance.BorderSize = 1;
            this.btnRelaxMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.btnRelaxMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(27)))), ((int)(((byte)(69)))));
            this.btnRelaxMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelaxMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRelaxMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnRelaxMode.Image = null;
            this.btnRelaxMode.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRelaxMode.Location = new System.Drawing.Point(300, 70);
            this.btnRelaxMode.Padding = new System.Windows.Forms.Padding(0, 12, 0, 8);
            this.btnRelaxMode.Size = new System.Drawing.Size(86, 118);
            this.btnRelaxMode.Text = "Relax\r\nMode";
            this.btnRelaxMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRelaxMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRelaxMode.UseVisualStyleBackColor = false;
            this.btnRelaxMode.Name = "btnRelaxMode";
            this.btnRelaxMode.TabIndex = 6;
            this.btnRelaxMode.Click += new System.EventHandler(this.btnRelaxMode_Click);
            // 
            // QuickActionsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.pnlQuick);
            this.Size = new System.Drawing.Size(408, 210);
            this.Name = "QuickActionsUserControl";
            this.pnlQuick.ResumeLayout(false);
            this.pnlQuick.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WinFormsApp2.Controls.RoundedPanel pnlQuick;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnAllOn;
        private System.Windows.Forms.Button btnAllOff;
        private System.Windows.Forms.Button btnNightMode;
        private System.Windows.Forms.Button btnRelaxMode;
    }
}
