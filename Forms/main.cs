using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Popups;
using WinFormsApp2.UserControls;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp2
{
    public partial class main : Form
    {
        private readonly SmartHomeSecurity.SecurityService securityService =
            new SmartHomeSecurity.SecurityService(new SmartHomeSecurity.JsonSecurityRepository());

        public main()
        {
            InitializeComponent();
            pnlProfileMenu.Visible = false;
            pnlNotificationsMenu.Visible = false;

            Smarthome_.net9.dashboard home = new Smarthome_.net9.dashboard();

            home.Dock = DockStyle.Fill;
            pnlMainArea.Controls.Add(home);

        }


        private void button5_Click(object sender, EventArgs e)
        {
            auth page = new auth();
            pnlMainArea.Controls.Clear();
            page.Dock = DockStyle.None;
            page.Location = new Point(0, 0);
            pnlMainArea.Controls.Add(page);
        }





        private void picProfile_Click(object sender, EventArgs e)
        {


            if (pnlProfileMenu.Visible)
            {
                pnlProfileMenu.Visible = false;
                return;
            }

            Point position = this.PointToClient(
                picProfile.PointToScreen(Point.Empty)
            );

            int x = position.X + picProfile.Width - pnlProfileMenu.Width;
            int y = position.Y + picProfile.Height + 5;

            pnlProfileMenu.Location = new Point(
                Math.Max(0, Math.Min(x, ClientSize.Width - pnlProfileMenu.Width)),
                y
            );

            pnlProfileMenu.BringToFront();
            pnlProfileMenu.Visible = true;
        }




        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            ProfileControl page = new ProfileControl();

            pnlMainArea.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlMainArea.Controls.Add(page);

            pnlProfileMenu.Visible = false;
        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            AccountSettingsControl page = new AccountSettingsControl();

            pnlMainArea.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlMainArea.Controls.Add(page);

            pnlProfileMenu.Visible = false;
            pnlProfileMenu.BringToFront();
        }

        private void btnOpenLogin_Click(object sender, EventArgs e)
        {
            using (WinFormsApp2.Forms.LoginForm login = new WinFormsApp2.Forms.LoginForm())
            {
                login.ShowDialog(this);
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            using (LogoutConfirmForm confirm = new LogoutConfirmForm())
            {
                if (confirm.ShowDialog(this) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }


        private void btnNotifications_Click(object sender, EventArgs e)
        {
            pnlNotificationsMenu.Visible = !pnlNotificationsMenu.Visible;

            if (pnlNotificationsMenu.Visible)
            {
                pnlProfileMenu.Visible = false;

                Control bell = (Control)sender;

                Point position = this.PointToClient(
                    bell.PointToScreen(Point.Empty)
                );

                int x = position.X + bell.Width - pnlNotificationsMenu.Width;
                int y = position.Y + bell.Height + 5;

                pnlNotificationsMenu.Location = new Point(
                    Math.Max(0, Math.Min(x, ClientSize.Width - pnlNotificationsMenu.Width)),
                    y
                );

                pnlNotificationsMenu.BringToFront();
            }
        }

        private void btnViewAllNotifications_Click(object sender, EventArgs e)
        {
            NotificationsControl page = new NotificationsControl();

            pnlMainArea.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlMainArea.Controls.Add(page);

            pnlNotificationsMenu.Visible = false;
            pnlProfileMenu.Visible = false;

        }


        private void btnRooms_Click(object sender, EventArgs e)
        {
            RoomsOverviewControl page = new RoomsOverviewControl();

            pnlMainArea.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlMainArea.Controls.Add(page);

            pnlProfileMenu.Visible = false;
            pnlNotificationsMenu.Visible = false;
        }

        private void btnsecurity_Click(object sender, EventArgs e)
        {
            SecurityUserControl page = new SecurityUserControl(securityService);

            pnlMainArea.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlMainArea.Controls.Add(page);

            pnlProfileMenu.Visible = false;
            pnlNotificationsMenu.Visible = false;
        }

        private void btnDevices_Click(object sender, EventArgs e)
        {
            DevicesControl page = new DevicesControl();

            pnlMainArea.Controls.Clear();

            page.Dock = DockStyle.Fill;
            pnlMainArea.Controls.Add(page);

            pnlProfileMenu.Visible = false;
            pnlNotificationsMenu.Visible = false;
        }

        private void btnenergy_Click(object sender, EventArgs e)
        {
            SmartHome.Energycontrol page = new SmartHome.Energycontrol();

            pnlMainArea.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlMainArea.Controls.Add(page);

            pnlProfileMenu.Visible = false;
            pnlNotificationsMenu.Visible = false;
        }



        private void btnHome_Click(object sender, EventArgs e)
        {
            Smarthome_.net9.dashboard page = new Smarthome_.net9.dashboard();

            pnlMainArea.Controls.Clear();

            page.Dock = DockStyle.Fill;
            pnlMainArea.Controls.Add(page);

            pnlProfileMenu.Visible = false;
            pnlNotificationsMenu.Visible = false;
        }

        private void btnlight_Click(object sender, EventArgs e)
        {
            LightingDashboardUserControl page = new LightingDashboardUserControl();

            pnlMainArea.Controls.Clear();

            page.Dock = DockStyle.Fill;
            pnlMainArea.Controls.Add(page);

            pnlProfileMenu.Visible = false;
            pnlNotificationsMenu.Visible = false;
        }
    }
}
