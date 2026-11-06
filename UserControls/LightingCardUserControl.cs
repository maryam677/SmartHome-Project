using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WinFormsApp2.Data;
using WinFormsApp2.Forms;


namespace WinFormsApp2.UserControls
{
    // One room card on the Lighting dashboard.
    // The properties below (RoomName, RoomImage, Brightness, ...) can be changed
    // in the Properties window when the card is selected in the Designer.
    public partial class LightingCardUserControl : UserControl
    {
        private string roomName = "Living Room";
        private string roomSubtitle = "Relax & Enjoy";
        private string roomIcon = "\uE7F4";
        private bool isFavorite = true;
        private bool lightsOn = true;
        private int brightness = 75;
        private Color lightColor = AppColors.AccentPurple;

        public LightingCardUserControl()
        {
            InitializeComponent();
        }

        // The room that this card controls (set by the dashboard at runtime)
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public RoomData Room { get; set; }

        [Category("SmartHome")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string RoomName
        {
            get { return roomName; }
            set { roomName = value; UpdateView(); }
        }

        [Category("SmartHome")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string RoomSubtitle
        {
            get { return roomSubtitle; }
            set { roomSubtitle = value; UpdateView(); }
        }

        [Category("SmartHome")]
        [Description("Icon character from the 'Segoe MDL2 Assets' font")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string RoomIcon
        {
            get { return roomIcon; }
            set { roomIcon = value; UpdateView(); }
        }

        [Category("SmartHome")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image RoomImage
        {
            get { return picRoom.Image; }
            set { picRoom.Image = value; }
        }

        [Category("SmartHome")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool IsFavorite
        {
            get { return isFavorite; }
            set { isFavorite = value; UpdateView(); }
        }

        [Category("SmartHome")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool LightsOn
        {
            get { return lightsOn; }
            set { lightsOn = value; UpdateView(); }
        }

        [Category("SmartHome")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Brightness
        {
            get { return brightness; }
            set { brightness = Math.Max(0, Math.Min(100, value)); UpdateView(); }
        }

        // Copies the values of the Room object into the card
        public void RefreshFromRoom()
        {
            if (Room == null) return;

            roomName = Room.Name;
            roomSubtitle = Room.Subtitle;
            isFavorite = Room.IsFavorite;
            lightsOn = Room.IsOn;
            brightness = Room.Brightness;
            lightColor = Room.LightColor;
            UpdateView();
        }

        // Updates all labels, the track bar and the buttons
        private void UpdateView()
        {
            lblRoomName.Text = roomName;
            lblRoomSubtitle.Text = roomSubtitle;
            lblRoomIcon.Text = roomIcon;

            lblFavorite.Text = isFavorite ? "\uE735" : "\uE734";   // filled / empty star
            lblFavorite.ForeColor = isFavorite ? AppColors.FavoriteYellow : AppColors.SecondaryText;

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

        private void lblFavorite_Click(object sender, EventArgs e)
        {
            if (Room != null)
            {
                Room.IsFavorite = !Room.IsFavorite;
            }
            IsFavorite = !IsFavorite;
        }
    }
}
