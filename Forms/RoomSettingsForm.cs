using System;
using System.Drawing;
using System.Windows.Forms;
using WinFormsApp2.Controls;
using WinFormsApp2.Data;

namespace WinFormsApp2.Forms
{
    // Dialog that lets the user change the settings of one room.
    public partial class RoomSettingsForm : Form
    {
        private RoomData room;
        private Color selectedColor = AppColors.PrimaryPurple;

        public RoomSettingsForm()
        {
            InitializeComponent();
        }

        // Fill the form with the values of the room
        public void LoadRoom(RoomData roomToEdit)
        {
            room = roomToEdit;

            txtRoomName.Text = room.Name;
            trackBrightness.Value = room.Brightness;
            lblBrightnessValue.Text = room.Brightness + "%";
            chkAutoOff.Checked = room.AutoOffEnabled;
            numAutoOffMinutes.Value = room.AutoOffMinutes;

            selectedColor = room.LightColor;
            ColorSwatchButton[] swatches = GetSwatches();
            foreach (ColorSwatchButton swatch in swatches)
            {
                swatch.Selected = swatch.SwatchColor.ToArgb() == selectedColor.ToArgb();
            }
        }

        private ColorSwatchButton[] GetSwatches()
        {
            return new ColorSwatchButton[]
            {
                swatchPurple, swatchBlue, swatchCyan, swatchGreen, swatchYellow, swatchOrange, swatchPink
            };
        }

        private void trackBrightness_Scroll(object sender, EventArgs e)
        {
            lblBrightnessValue.Text = trackBrightness.Value + "%";
        }

        private void Swatch_Click(object sender, EventArgs e)
        {
            ColorSwatchButton clicked = (ColorSwatchButton)sender;
            selectedColor = clicked.SwatchColor;

            foreach (ColorSwatchButton swatch in GetSwatches())
            {
                swatch.Selected = (swatch == clicked);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (room != null)
            {
                if (txtRoomName.Text.Trim() != "")
                {
                    room.Name = txtRoomName.Text.Trim();
                }
                room.SetBrightness(trackBrightness.Value);
                room.LightColor = selectedColor;
                room.AutoOffEnabled = chkAutoOff.Checked;
                room.AutoOffMinutes = (int)numAutoOffMinutes.Value;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
