using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.Popups
{
    public partial class DeviceDetailsForm : Form
    {
        public DeviceDetailsForm()
        {
            InitializeComponent();
        }



        public void SetDevice(string name, string room, string type, string status)
        {
            lblDeviceName.Text = name;
            lblRoom.Text = room;
            lblType.Text = type;
            lblDeviceStatus.Text = "● " + status;
            lblConnection.Text = "Wi-Fi";

            lblDeviceStatus.ForeColor = status == "Online"
                ? Color.FromArgb(90, 220, 150)
                : Color.FromArgb(240, 120, 120);
        }

    }
}
