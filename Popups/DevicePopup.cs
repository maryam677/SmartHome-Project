using System;
using System.Drawing;
using System.Windows.Forms;

namespace Smarthome_net9
{
    public partial class DevicePopup : Form
    {
        public bool IsOn { get; private set; }

        public DevicePopup()
        {
            InitializeComponent();

            this.Paint += (s, e) =>
                e.Graphics.DrawRectangle(Pens.MediumPurple, 0, 0, Width - 1, Height - 1);
        }

        public DevicePopup(string deviceName, string room, bool currentState) : this()
        {
            lblname.Text = deviceName;
            lblroom.Text = room;
            IsOn = currentState;
            UpdateButtons();

        }

        private void UpdateButtons()
        {
            btnon.BackColor = IsOn ? Color.MediumPurple : Color.Transparent;
            btnoff.BackColor = !IsOn ? Color.MediumPurple : Color.Transparent;
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            IsOn = true;
            DialogResult = DialogResult.OK;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            IsOn = false;
            DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

       
    }
}
