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
using WinFormsApp2.Popups;
using WinFormsApp2.Controls;

namespace WinFormsApp2.UserControls
{
    public partial class DevicesControl : UserControl
    {
        public DevicesControl()
        {
            InitializeComponent();
            DoubleBuffered = true;
            ApplyDeviceStyling();
            UpdateDeviceCounters();
        }

        private void ApplyDeviceStyling()
        {
            foreach (Panel card in DeviceCards)
            {
                StylePanel(card, 20);
                foreach (Button button in card.Controls.OfType<Button>())
                    RoundControl(button, 9);
            }

            foreach (Panel summary in new[] { pnlTotalDevices, pnlOnlineDevices, pnlOfflineDevices })
                StylePanel(summary, 16);

            RoundControl(btnAddDevice, 11);
            foreach (Label status in new[] { lblCameraStatus, lblonline, lblonline3, lblonline4, lblonline5, lblOffline })
            {
                status.BackColor = status == lblOffline
                    ? Color.FromArgb(69, 38, 54)
                    : Color.FromArgb(25, 61, 55);
                RoundControl(status, 5);
            }
        }

        private static void StylePanel(Panel panel, int radius)
        {
            Color start = panel.BackColor;
            Color end = Color.FromArgb(start.R + 4, start.G - 6, start.B + 5);
            panel.BackColor = Color.Transparent;
            panel.SizeChanged += (_, _) => panel.Invalidate();
            panel.Paint += (_, e) =>
            {
                Rectangle bounds = Rectangle.Inflate(panel.ClientRectangle, -1, -1);
                if (bounds.Width <= 0 || bounds.Height <= 0)
                    return;

                var state = e.Graphics.Save();
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using GraphicsPath path = RoundedPanel.GetRoundedRectPath(bounds, radius);
                using var fill = new LinearGradientBrush(bounds, start, end, LinearGradientMode.ForwardDiagonal);
                using var border = new Pen(Color.FromArgb(84, 68, 132));
                e.Graphics.FillPath(fill, path);
                e.Graphics.DrawPath(border, path);
                e.Graphics.Restore(state);
            };
        }

        private static void RoundControl(Control control, int radius)
        {
            void UpdateRegion()
            {
                Rectangle bounds = control.ClientRectangle;
                if (bounds.Width <= 0 || bounds.Height <= 0)
                    return;

                using GraphicsPath path = RoundedPanel.GetRoundedRectPath(bounds, radius);
                control.Region = new Region(path);
            }

            control.SizeChanged += (_, _) => UpdateRegion();
            UpdateRegion();
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
