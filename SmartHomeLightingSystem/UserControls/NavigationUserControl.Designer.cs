namespace SmartHomeLightingSystem.UserControls
{
    partial class NavigationUserControl
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnLighting = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnOverview = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSecurity = new System.Windows.Forms.Button();
            this.btnEnergy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(102)))), ((int)(((byte)(144)))));
            this.lblMenu.Location = new System.Drawing.Point(26, 14);
            this.lblMenu.Size = new System.Drawing.Size(62, 19);
            this.lblMenu.Text = "MAIN MENU";
            this.lblMenu.UseMnemonic = false;
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.TabIndex = 0;
            // 
            // btnLighting
            // 
            this.btnLighting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnLighting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLighting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnLighting.FlatAppearance.BorderSize = 0;
            this.btnLighting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.btnLighting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnLighting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLighting.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLighting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnLighting.Image = global::SmartHomeLightingSystem.Properties.Resources.nav_lighting;
            this.btnLighting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLighting.Location = new System.Drawing.Point(16, 40);
            this.btnLighting.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnLighting.Size = new System.Drawing.Size(198, 48);
            this.btnLighting.Text = "   Lighting";
            this.btnLighting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLighting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLighting.UseVisualStyleBackColor = false;
            this.btnLighting.Tag = "Lighting";
            this.btnLighting.Name = "btnLighting";
            this.btnLighting.TabIndex = 1;
            this.btnLighting.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRooms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnRooms.FlatAppearance.BorderSize = 0;
            this.btnRooms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.btnRooms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(27)))), ((int)(((byte)(69)))));
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.btnRooms.Image = global::SmartHomeLightingSystem.Properties.Resources.nav_rooms;
            this.btnRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRooms.Location = new System.Drawing.Point(16, 98);
            this.btnRooms.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnRooms.Size = new System.Drawing.Size(198, 48);
            this.btnRooms.Text = "   Rooms";
            this.btnRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRooms.UseVisualStyleBackColor = false;
            this.btnRooms.Tag = "Rooms";
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.TabIndex = 2;
            this.btnRooms.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // btnOverview
            // 
            this.btnOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnOverview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOverview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnOverview.FlatAppearance.BorderSize = 0;
            this.btnOverview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.btnOverview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(27)))), ((int)(((byte)(69)))));
            this.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOverview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.btnOverview.Image = global::SmartHomeLightingSystem.Properties.Resources.nav_overview;
            this.btnOverview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverview.Location = new System.Drawing.Point(16, 156);
            this.btnOverview.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnOverview.Size = new System.Drawing.Size(198, 48);
            this.btnOverview.Text = "   Overview";
            this.btnOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOverview.UseVisualStyleBackColor = false;
            this.btnOverview.Tag = "Overview";
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.TabIndex = 3;
            this.btnOverview.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(27)))), ((int)(((byte)(69)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.btnSettings.Image = global::SmartHomeLightingSystem.Properties.Resources.nav_settings;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(16, 214);
            this.btnSettings.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(198, 48);
            this.btnSettings.Text = "   Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Tag = "Settings";
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // btnSecurity
            // 
            this.btnSecurity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnSecurity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecurity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnSecurity.FlatAppearance.BorderSize = 0;
            this.btnSecurity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.btnSecurity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(27)))), ((int)(((byte)(69)))));
            this.btnSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecurity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSecurity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.btnSecurity.Image = global::SmartHomeLightingSystem.Properties.Resources.nav_security;
            this.btnSecurity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecurity.Location = new System.Drawing.Point(16, 272);
            this.btnSecurity.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnSecurity.Size = new System.Drawing.Size(198, 48);
            this.btnSecurity.Text = "   Security";
            this.btnSecurity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecurity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSecurity.UseVisualStyleBackColor = false;
            this.btnSecurity.Tag = "Security";
            this.btnSecurity.Name = "btnSecurity";
            this.btnSecurity.TabIndex = 5;
            this.btnSecurity.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // btnEnergy
            // 
            this.btnEnergy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnEnergy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnergy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnEnergy.FlatAppearance.BorderSize = 0;
            this.btnEnergy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.btnEnergy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(27)))), ((int)(((byte)(69)))));
            this.btnEnergy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnergy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnergy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.btnEnergy.Image = global::SmartHomeLightingSystem.Properties.Resources.nav_energy;
            this.btnEnergy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnergy.Location = new System.Drawing.Point(16, 330);
            this.btnEnergy.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnEnergy.Size = new System.Drawing.Size(198, 48);
            this.btnEnergy.Text = "   Energy";
            this.btnEnergy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnergy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnergy.UseVisualStyleBackColor = false;
            this.btnEnergy.Tag = "Energy";
            this.btnEnergy.Name = "btnEnergy";
            this.btnEnergy.TabIndex = 6;
            this.btnEnergy.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // NavigationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnLighting);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnOverview);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnSecurity);
            this.Controls.Add(this.btnEnergy);
            this.Size = new System.Drawing.Size(230, 680);
            this.Name = "NavigationUserControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnLighting;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSecurity;
        private System.Windows.Forms.Button btnEnergy;
    }
}
