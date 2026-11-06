using Smarthome_net9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smarthome_.net9
{
    public partial class dashboard : UserControl
    {
        public dashboard()
        {
            InitializeComponent();
        }
        private bool floorLampOn = true;

        private void lblwelcome_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void piclivingroom_Click(object sender, EventArgs e)
        {

        }

        private void lblRooms_Click(object sender, EventArgs e)
        {

        }



        private void lblPower_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void lbllamp_Click(object sender, EventArgs e)
        {

        }

        private void pnlDeviceOverview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblindoorclimate_Click(object sender, EventArgs e)
        {

        }

        private void btnon2_Click(object sender, EventArgs e)
        {

        }

        private void lblquick_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbperiod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label2_Click_3(object sender, EventArgs e)
        {

        }



       

        private void btnon1_Click_1(object sender, EventArgs e)
        {
            using (var popup = new DevicePopup("Floor lamp", "Living Room", floorLampOn))
            {
                if (popup.ShowDialog(this.FindForm()) == DialogResult.OK)
                {
                    floorLampOn = popup.IsOn;
                   btnon1.Text = floorLampOn ? "ON" : "OFF";
                }
            }
        }
    }
}

