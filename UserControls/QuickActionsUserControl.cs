using System;
using System.Windows.Forms;
using WinFormsApp2.Data;

namespace WinFormsApp2.UserControls
{
    // Four buttons that change all rooms with one click.
    public partial class QuickActionsUserControl : UserControl
    {
        public QuickActionsUserControl()
        {
            InitializeComponent();
        }

        private void btnAllOn_Click(object sender, EventArgs e)
        {
            AppData.AllLightsOn();
        }

        private void btnAllOff_Click(object sender, EventArgs e)
        {
            AppData.AllLightsOff();
        }

        private void btnNightMode_Click(object sender, EventArgs e)
        {
            AppData.NightMode();
        }

        private void btnRelaxMode_Click(object sender, EventArgs e)
        {
            AppData.RelaxMode();
        }
    }
}
