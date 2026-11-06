using System.Windows.Forms;
using WinFormsApp2.Data;

namespace WinFormsApp2.UserControls
{
    // Small summary card: overall brightness and how many rooms are on / off.
    public partial class SystemOverviewUserControl : UserControl
    {
        public SystemOverviewUserControl()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            int average = AppData.GetAverageBrightness();

            gaugeBrightness.Value = average;
            lblOverallValue.Text = average + "%";
            lblOnRoomsValue.Text = AppData.GetOnRoomsCount().ToString();
            lblOffRoomsValue.Text = AppData.GetOffRoomsCount().ToString();
            lblTotalRoomsValue.Text = AppData.Rooms.Count.ToString();
        }
    }
}
