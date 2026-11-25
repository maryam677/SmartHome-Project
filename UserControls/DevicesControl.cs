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
            UpdateDeviceCounters();
        }



        private IEnumerable<Panel> DeviceCards =>
            new[] { pnlCamera, pnlSmartLock, pnlGarage, pnlCurtains, pnlSmartPlug, pnlBackyardCamera }.Where(card => card.Parent == this);

        private void DeleteDevice_Click(object? sender, EventArgs e)
        {
            if (sender is not Button { Parent: Panel card }) return;
            if (MessageBox.Show(this, "Delete this device?", "Delete Device",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            Controls.Remove(card);
            card.Dispose();
            SuspendLayout();
            int index = 0;
            foreach (var remaining in DeviceCards)
            {
                remaining.Location = new Point(25 + index % 2 * 525, 263 + index / 2 * 174);
                index++;
            }
            ResumeLayout(true);
            UpdateDeviceCounters();
        }

        private void UpdateDeviceCounters()
        {
            int total = DeviceCards.Count();
            int offline = DeviceCards.Count(card => card == pnlBackyardCamera);
            lblTotalCount.Text = total.ToString();
            lblOnlineCount.Text = (total - offline).ToString();
            lblOfflineCount.Text = offline.ToString();
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

    
    }
}
