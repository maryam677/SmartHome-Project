using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SmartHomeLightingSystem.Data;
using SmartHomeLightingSystem.Forms;

namespace SmartHomeLightingSystem.UserControls
{
    // One wide room row on the Rooms page.
    // Works the same way as LightingCardUserControl, only the layout is different.
    public partial class RoomRowUserControl : UserControl
    {
        private string roomName = "Living Room";
        private string roomSubtitle = "Relax & Enjoy";
        private string roomIcon = "\uE7F4";
        private bool lightsOn = true;
        private int brightness = 75;
        private Color lightColor = AppColors.AccentPurple;

        public RoomRowUserControl()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public RoomData Room { get; set; }

        [Category("SmartHome")]
        public string RoomName
        {
            get { return roomName; }
            set { roomName = value; UpdateView(); }
        }

        [Category("SmartHome")]
        public string RoomSubtitle
        {
            get { return roomSubtitle; }
            set { roomSubtitle = value; UpdateView(); }
        }

        [Category("SmartHome")]
        [Description("Icon character from the 'Segoe MDL2 Assets' font")]
        public string RoomIcon
        {
            get { return roomIcon; }
            set { roomIcon = value; UpdateView(); }
        }

        [Category("SmartHome")]
        public Image RoomImage
        {
            get { return picRoom.Image; }
            set { picRoom.Image = value; }
        }

        [Category("SmartHome")]
        public bool LightsOn
        {
            get { return lightsOn; }
            set { lightsOn = value; UpdateView(); }
        }

        [Category("SmartHome")]
        public int Brightness
        {
            get { return brightness; }
            set { brightness = Math.Max(0, Math.Min(100, value)); UpdateView(); }
        }

        public void RefreshFromRoom()
        {
            if (Room == null) return;

            roomName = Room.Name;
            roomSubtitle = Room.Subtitle;
            lightsOn = Room.IsOn;
            brightness = Room.Brightness;
            lightColor = Room.LightColor;
            UpdateView();
        }

        private void UpdateView()
        {
            lblRoomName.Text = roomName;
            lblRoomSubtitle.Text = roomSubtitle;
            lblRoomIcon.Text = roomIcon;

            trackBrightness.Value = brightness;
            lblBrightnessValue.Text = brightness + "%";

            if (lightsOn)
            {
                lblLightStatus.Text = "Lights On";
                lblLightStatus.ForeColor = lightColor;
                lblBulbIcon.ForeColor = lightColor;
                btnToggle.Text = "Turn Off";
                btnToggle.BackColor = AppColors.PrimaryPurple;
                btnToggle.FlatAppearance.BorderColor = AppColors.PrimaryPurple;
            }
            else
            {
                lblLightStatus.Text = "Lights Off";
                lblLightStatus.ForeColor = AppColors.SecondaryText;
                lblBulbIcon.ForeColor = AppColors.SecondaryText;
                btnToggle.Text = "Turn On";
                btnToggle.BackColor = AppColors.SecondaryBackground;
                btnToggle.FlatAppearance.BorderColor = AppColors.Border;
            }
        }

        private void trackBrightness_Scroll(object sender, EventArgs e)
        {
            if (Room != null)
            {
                Room.SetBrightness(trackBrightness.Value);
                AppData.NotifyDataChanged();
            }
            else
            {
                brightness = trackBrightness.Value;
                lightsOn = brightness > 0;
                UpdateView();
            }
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (Room == null) return;

            if (Room.IsOn)
            {
                Room.TurnOff();
            }
            else
            {
                Room.TurnOn();
            }
            AppData.NotifyDataChanged();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (Room == null) return;

            using (RoomSettingsForm settingsForm = new RoomSettingsForm())
            {
                settingsForm.LoadRoom(Room);
                if (settingsForm.ShowDialog(FindForm()) == DialogResult.OK)
                {
                    AppData.NotifyDataChanged();
                }
            }
        }
    }
}
