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

namespace WinFormsApp2.UserControls
{
    public partial class DevicesControl : UserControl
    {
        public DevicesControl()
        {
            InitializeComponent();
        }



        private void btnViewDevice_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string device = button.Tag?.ToString() ?? "";

            using (DeviceDetailsForm form = new DeviceDetailsForm())
            {
                switch (device)
                {
                    case "Camera":
                        form.SetDevice("Front Door Camera", "Entrance", "Security Camera", "Online");
                        break;

                    case "Lock":
                        form.SetDevice("Smart Door Lock", "Entrance", "Smart Lock", "Online");
                        break;

                    case "Garage":
                        form.SetDevice("Garage Door", "Garage", "Garage Controller", "Online");
                        break;

                    case "Curtains":
                        form.SetDevice("Smart Curtains", "Living Room", "Curtain Controller", "Online");
                        break;

                    case "Plug":
                        form.SetDevice("Smart Plug", "Bedroom", "Smart Plug", "Online");
                        break;

                    case "Backyard":
                        form.SetDevice("Backyard Camera", "Garden", "Security Camera", "Offline");
                        break;
                }

                form.ShowDialog(this);
            }
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            using (AddDeviceForm form = new AddDeviceForm())
            {
                form.ShowDialog(this);
            }
        }

        private void lblCameraStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblenterence2_Click(object sender, EventArgs e)
        {

        }

        private void lblGarage_Click(object sender, EventArgs e)
        {

        }
    }
}
