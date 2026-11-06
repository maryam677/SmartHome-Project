namespace WinFormsApp2.UserControls
{
    partial class ColorControlUserControl
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
            this.components = new System.ComponentModel.Container();
            this.pnlColor = new WinFormsApp2.Controls.RoundedPanel();
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.swatchPurple = new WinFormsApp2.Controls.ColorSwatchButton();
            this.swatchBlue = new WinFormsApp2.Controls.ColorSwatchButton();
            this.swatchCyan = new WinFormsApp2.Controls.ColorSwatchButton();
            this.swatchGreen = new WinFormsApp2.Controls.ColorSwatchButton();
            this.swatchYellow = new WinFormsApp2.Controls.ColorSwatchButton();
            this.swatchOrange = new WinFormsApp2.Controls.ColorSwatchButton();
            this.swatchPink = new WinFormsApp2.Controls.ColorSwatchButton();
            this.gradientBar = new WinFormsApp2.Controls.GradientBar();
            this.lblSelectedText = new System.Windows.Forms.Label();
            this.pnlSelectedColor = new WinFormsApp2.Controls.RoundedPanel();
            this.lblSelectedColorName = new System.Windows.Forms.Label();
            this.btnCustomColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.pnlColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlColor
            // 
            this.pnlColor.Controls.Add(this.lblIcon);
            this.pnlColor.Controls.Add(this.lblTitle);
            this.pnlColor.Controls.Add(this.lblSubtitle);
            this.pnlColor.Controls.Add(this.swatchPurple);
            this.pnlColor.Controls.Add(this.swatchBlue);
            this.pnlColor.Controls.Add(this.swatchCyan);
            this.pnlColor.Controls.Add(this.swatchGreen);
            this.pnlColor.Controls.Add(this.swatchYellow);
            this.pnlColor.Controls.Add(this.swatchOrange);
            this.pnlColor.Controls.Add(this.swatchPink);
            this.pnlColor.Controls.Add(this.gradientBar);
            this.pnlColor.Controls.Add(this.lblSelectedText);
            this.pnlColor.Controls.Add(this.pnlSelectedColor);
            this.pnlColor.Controls.Add(this.lblSelectedColorName);
            this.pnlColor.Controls.Add(this.btnCustomColor);
            this.pnlColor.BackColor = System.Drawing.Color.Transparent;
            this.pnlColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.pnlColor.BorderRadius = 16;
            this.pnlColor.BorderThickness = 1F;
            this.pnlColor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(21)))), ((int)(((byte)(56)))));
            this.pnlColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColor.Location = new System.Drawing.Point(0, 0);
            this.pnlColor.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlColor.Size = new System.Drawing.Size(346, 210);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.TabIndex = 0;
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.lblIcon.Location = new System.Drawing.Point(18, 18);
            this.lblIcon.Size = new System.Drawing.Size(30, 34);
            this.lblIcon.Text = "\uE790";
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
            this.lblTitle.Text = "Color Control";
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
            this.lblSubtitle.Size = new System.Drawing.Size(176, 21);
            this.lblSubtitle.Text = "Choose your preferred color";
            this.lblSubtitle.UseMnemonic = false;
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.TabIndex = 2;
            // 
            // swatchPurple
            // 
            this.swatchPurple.BackColor = System.Drawing.Color.Transparent;
            this.swatchPurple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swatchPurple.Location = new System.Drawing.Point(18, 66);
            this.swatchPurple.Selected = true;
            this.swatchPurple.Size = new System.Drawing.Size(34, 34);
            this.swatchPurple.SwatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.swatchPurple.Tag = "Purple";
            this.swatchPurple.Name = "swatchPurple";
            this.swatchPurple.TabIndex = 3;
            this.swatchPurple.Click += new System.EventHandler(this.Swatch_Click);
            // 
            // swatchBlue
            // 
            this.swatchBlue.BackColor = System.Drawing.Color.Transparent;
            this.swatchBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swatchBlue.Location = new System.Drawing.Point(62, 66);
            this.swatchBlue.Selected = false;
            this.swatchBlue.Size = new System.Drawing.Size(34, 34);
            this.swatchBlue.SwatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.swatchBlue.Tag = "Blue";
            this.swatchBlue.Name = "swatchBlue";
            this.swatchBlue.TabIndex = 4;
            this.swatchBlue.Click += new System.EventHandler(this.Swatch_Click);
            // 
            // swatchCyan
            // 
            this.swatchCyan.BackColor = System.Drawing.Color.Transparent;
            this.swatchCyan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swatchCyan.Location = new System.Drawing.Point(106, 66);
            this.swatchCyan.Selected = false;
            this.swatchCyan.Size = new System.Drawing.Size(34, 34);
            this.swatchCyan.SwatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.swatchCyan.Tag = "Cyan";
            this.swatchCyan.Name = "swatchCyan";
            this.swatchCyan.TabIndex = 5;
            this.swatchCyan.Click += new System.EventHandler(this.Swatch_Click);
            // 
            // swatchGreen
            // 
            this.swatchGreen.BackColor = System.Drawing.Color.Transparent;
            this.swatchGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swatchGreen.Location = new System.Drawing.Point(150, 66);
            this.swatchGreen.Selected = false;
            this.swatchGreen.Size = new System.Drawing.Size(34, 34);
            this.swatchGreen.SwatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.swatchGreen.Tag = "Green";
            this.swatchGreen.Name = "swatchGreen";
            this.swatchGreen.TabIndex = 6;
            this.swatchGreen.Click += new System.EventHandler(this.Swatch_Click);
            // 
            // swatchYellow
            // 
            this.swatchYellow.BackColor = System.Drawing.Color.Transparent;
            this.swatchYellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swatchYellow.Location = new System.Drawing.Point(194, 66);
            this.swatchYellow.Selected = false;
            this.swatchYellow.Size = new System.Drawing.Size(34, 34);
            this.swatchYellow.SwatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.swatchYellow.Tag = "Yellow";
            this.swatchYellow.Name = "swatchYellow";
            this.swatchYellow.TabIndex = 7;
            this.swatchYellow.Click += new System.EventHandler(this.Swatch_Click);
            // 
            // swatchOrange
            // 
            this.swatchOrange.BackColor = System.Drawing.Color.Transparent;
            this.swatchOrange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swatchOrange.Location = new System.Drawing.Point(238, 66);
            this.swatchOrange.Selected = false;
            this.swatchOrange.Size = new System.Drawing.Size(34, 34);
            this.swatchOrange.SwatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.swatchOrange.Tag = "Orange";
            this.swatchOrange.Name = "swatchOrange";
            this.swatchOrange.TabIndex = 8;
            this.swatchOrange.Click += new System.EventHandler(this.Swatch_Click);
            // 
            // swatchPink
            // 
            this.swatchPink.BackColor = System.Drawing.Color.Transparent;
            this.swatchPink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swatchPink.Location = new System.Drawing.Point(282, 66);
            this.swatchPink.Selected = false;
            this.swatchPink.Size = new System.Drawing.Size(34, 34);
            this.swatchPink.SwatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(72)))), ((int)(((byte)(153)))));
            this.swatchPink.Tag = "Pink";
            this.swatchPink.Name = "swatchPink";
            this.swatchPink.TabIndex = 9;
            this.swatchPink.Click += new System.EventHandler(this.Swatch_Click);
            // 
            // gradientBar
            // 
            this.gradientBar.BackColor = System.Drawing.Color.Transparent;
            this.gradientBar.Location = new System.Drawing.Point(18, 114);
            this.gradientBar.MarkerPosition = 0F;
            this.gradientBar.Size = new System.Drawing.Size(310, 24);
            this.gradientBar.Name = "gradientBar";
            this.gradientBar.TabIndex = 10;
            this.gradientBar.ColorPicked += new System.EventHandler(this.gradientBar_ColorPicked);
            // 
            // lblSelectedText
            // 
            this.lblSelectedText.AutoSize = true;
            this.lblSelectedText.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.lblSelectedText.Location = new System.Drawing.Point(18, 162);
            this.lblSelectedText.Size = new System.Drawing.Size(62, 21);
            this.lblSelectedText.Text = "Selected:";
            this.lblSelectedText.UseMnemonic = false;
            this.lblSelectedText.Name = "lblSelectedText";
            this.lblSelectedText.TabIndex = 11;
            // 
            // pnlSelectedColor
            // 
            this.pnlSelectedColor.BackColor = System.Drawing.Color.Transparent;
            this.pnlSelectedColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlSelectedColor.BorderRadius = 11;
            this.pnlSelectedColor.BorderThickness = 1F;
            this.pnlSelectedColor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.pnlSelectedColor.Location = new System.Drawing.Point(82, 160);
            this.pnlSelectedColor.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlSelectedColor.Size = new System.Drawing.Size(22, 22);
            this.pnlSelectedColor.Name = "pnlSelectedColor";
            this.pnlSelectedColor.TabIndex = 12;
            // 
            // lblSelectedColorName
            // 
            this.lblSelectedColorName.AutoSize = true;
            this.lblSelectedColorName.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedColorName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedColorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblSelectedColorName.Location = new System.Drawing.Point(110, 161);
            this.lblSelectedColorName.Size = new System.Drawing.Size(50, 22);
            this.lblSelectedColorName.Text = "Purple";
            this.lblSelectedColorName.UseMnemonic = false;
            this.lblSelectedColorName.Name = "lblSelectedColorName";
            this.lblSelectedColorName.TabIndex = 13;
            // 
            // btnCustomColor
            // 
            this.btnCustomColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(46)))));
            this.btnCustomColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.btnCustomColor.FlatAppearance.BorderSize = 1;
            this.btnCustomColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.btnCustomColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(27)))), ((int)(((byte)(69)))));
            this.btnCustomColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomColor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCustomColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnCustomColor.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCustomColor.Location = new System.Drawing.Point(214, 154);
            this.btnCustomColor.Size = new System.Drawing.Size(114, 36);
            this.btnCustomColor.Text = "Custom";
            this.btnCustomColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCustomColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomColor.UseVisualStyleBackColor = false;
            this.btnCustomColor.Name = "btnCustomColor";
            this.btnCustomColor.TabIndex = 14;
            this.btnCustomColor.Click += new System.EventHandler(this.btnCustomColor_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.FullOpen = true;
            // 
            // ColorControlUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.pnlColor);
            this.Size = new System.Drawing.Size(346, 210);
            this.Name = "ColorControlUserControl";
            this.pnlColor.ResumeLayout(false);
            this.pnlColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WinFormsApp2.Controls.RoundedPanel pnlColor;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private WinFormsApp2.Controls.ColorSwatchButton swatchPurple;
        private WinFormsApp2.Controls.ColorSwatchButton swatchBlue;
        private WinFormsApp2.Controls.ColorSwatchButton swatchCyan;
        private WinFormsApp2.Controls.ColorSwatchButton swatchGreen;
        private WinFormsApp2.Controls.ColorSwatchButton swatchYellow;
        private WinFormsApp2.Controls.ColorSwatchButton swatchOrange;
        private WinFormsApp2.Controls.ColorSwatchButton swatchPink;
        private WinFormsApp2.Controls.GradientBar gradientBar;
        private System.Windows.Forms.Label lblSelectedText;
        private WinFormsApp2.Controls.RoundedPanel pnlSelectedColor;
        private System.Windows.Forms.Label lblSelectedColorName;
        private System.Windows.Forms.Button btnCustomColor;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}
