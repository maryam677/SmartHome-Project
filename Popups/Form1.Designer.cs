namespace WinFormsApp2.Popups
{
    partial class lightiningsystem
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
            pnllighting = new Panel();
            btncancel = new Button();
            btnsave = new Button();
            trackbarlightinig = new TrackBar();
            label1 = new Label();
            lblbrightness = new Label();
            btnturnoff = new Button();
            lbllightson = new Label();
            lbllivingroom = new Label();
            lbllighting = new Label();
            pnllighting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackbarlightinig).BeginInit();
            SuspendLayout();
            // 
            // pnllighting
            // 
            pnllighting.AutoScroll = true;
            pnllighting.BackColor = Color.FromArgb(27, 21, 56);
            pnllighting.Controls.Add(btncancel);
            pnllighting.Controls.Add(btnsave);
            pnllighting.Controls.Add(trackbarlightinig);
            pnllighting.Controls.Add(label1);
            pnllighting.Controls.Add(lblbrightness);
            pnllighting.Controls.Add(btnturnoff);
            pnllighting.Controls.Add(lbllightson);
            pnllighting.Controls.Add(lbllivingroom);
            pnllighting.Controls.Add(lbllighting);
            pnllighting.Location = new Point(20, 20);
            pnllighting.Name = "pnllighting";
            pnllighting.Size = new Size(323, 341);
            pnllighting.TabIndex = 0;
            // 
            // btncancel
            // 
            btncancel.DialogResult = DialogResult.OK;
            btncancel.FlatStyle = FlatStyle.Flat;
            btncancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncancel.ForeColor = Color.White;
            btncancel.Location = new Point(180, 278);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(94, 44);
            btncancel.TabIndex = 8;
            btncancel.Text = "cancel";
            btncancel.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            btnsave.DialogResult = DialogResult.OK;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(22, 278);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(124, 44);
            btnsave.TabIndex = 7;
            btnsave.Text = "save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // trackbarlightinig
            // 
            trackbarlightinig.Location = new Point(144, 153);
            trackbarlightinig.Maximum = 100;
            trackbarlightinig.Name = "trackbarlightinig";
            trackbarlightinig.Size = new Size(130, 56);
            trackbarlightinig.TabIndex = 6;
            trackbarlightinig.TickStyle = TickStyle.None;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(168, 223);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 5;
            label1.Text = "percentage";
            // 
            // lblbrightness
            // 
            lblbrightness.AutoSize = true;
            lblbrightness.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbrightness.ForeColor = Color.FromArgb(170, 165, 200);
            lblbrightness.Location = new Point(23, 234);
            lblbrightness.Name = "lblbrightness";
            lblbrightness.Size = new Size(102, 25);
            lblbrightness.TabIndex = 4;
            lblbrightness.Text = "Brightness";
            // 
            // btnturnoff
            // 
            btnturnoff.BackColor = Color.FromArgb(124, 58, 237);
            btnturnoff.FlatAppearance.BorderSize = 0;
            btnturnoff.FlatStyle = FlatStyle.Flat;
            btnturnoff.ForeColor = Color.White;
            btnturnoff.Location = new Point(23, 192);
            btnturnoff.Name = "btnturnoff";
            btnturnoff.Size = new Size(94, 29);
            btnturnoff.TabIndex = 3;
            btnturnoff.Text = "Turn Off";
            btnturnoff.UseVisualStyleBackColor = false;
            // 
            // lbllightson
            // 
            lbllightson.AutoSize = true;
            lbllightson.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllightson.ForeColor = Color.FromArgb(167, 139, 250);
            lbllightson.Location = new Point(22, 142);
            lbllightson.Name = "lbllightson";
            lbllightson.Size = new Size(95, 28);
            lbllightson.TabIndex = 2;
            lbllightson.Text = "lights on";
            // 
            // lbllivingroom
            // 
            lbllivingroom.AutoSize = true;
            lbllivingroom.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllivingroom.ForeColor = Color.FromArgb(170, 165, 200);
            lbllivingroom.Location = new Point(22, 85);
            lbllivingroom.Name = "lbllivingroom";
            lbllivingroom.Size = new Size(169, 38);
            lbllivingroom.TabIndex = 1;
            lbllivingroom.Text = "living room";
            // 
            // lbllighting
            // 
            lbllighting.AutoSize = true;
            lbllighting.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllighting.ForeColor = Color.White;
            lbllighting.Location = new Point(22, 30);
            lbllighting.Name = "lbllighting";
            lbllighting.Size = new Size(177, 38);
            lbllighting.TabIndex = 0;
            lbllighting.Text = "light setting";
            // 
            // lightiningsystem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 8, 23);
            ClientSize = new Size(382, 373);
            Controls.Add(pnllighting);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "lightiningsystem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            pnllighting.ResumeLayout(false);
            pnllighting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackbarlightinig).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnllighting;
        private Label lbllighting;
        private Button btnturnoff;
        private Label lbllightson;
        private Label lbllivingroom;
        private Label label1;
        private Label lblbrightness;
        private Button btncancel;
        private Button btnsave;
        private TrackBar trackbarlightinig;
    }
}