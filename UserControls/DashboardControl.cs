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
using WinFormsApp2.Data;

namespace Smarthome_.net9
{
    public partial class dashboard : UserControl
    {
        public dashboard()
        {
            InitializeComponent();
            ApplyLiveRoomStats();
        }
        private bool floorLampOn = true;

        private void ApplyLiveRoomStats()
        {
            lblnodevices.Text = RoomCatalog.DeviceCount + " Devices";
            lblCLOCK.Text = RoomCatalog.LiveKwh.ToString("0.0") + " Kwh";

            int lampsOn = RoomCatalog.CountOn(RoomDeviceGlyph.Bulb);
            int coolingOn = RoomCatalog.CountOn(RoomDeviceGlyph.Snowflake);
            int screensOn = RoomCatalog.CountOn(RoomDeviceGlyph.Screen);
            lblonn.Text = lampsOn == 0 ? "Off" : lampsOn + " On";
            lblonn2.Text = coolingOn == 0 ? "Off" : coolingOn + " On";
            lblonn3.Text = screensOn == 0 ? "Off" : screensOn + " On";

            RoomDevice? livingLamp = RoomCatalog.Rooms
                .FirstOrDefault(room => room.Name == "Living Room")
                ?.Devices.FirstOrDefault(device => device.Glyph == RoomDeviceGlyph.Bulb);
            floorLampOn = livingLamp?.IsOn ?? false;
            btnon1.Text = floorLampOn ? "ON" : "OFF";
        }

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
                    if (sender == btnon1)
                    {
                        RoomDevice? livingLamp = RoomCatalog.Rooms
                            .FirstOrDefault(room => room.Name == "Living Room")
                            ?.Devices.FirstOrDefault(device => device.Glyph == RoomDeviceGlyph.Bulb);
                        if (livingLamp != null)
                        {
                            livingLamp.IsOn = floorLampOn;
                            RoomCatalog.Save();
                            ApplyLiveRoomStats();
                        }
                    }
                }
            }
        }
    }
}

