using System.Windows.Forms;
using WinFormsApp2.Data;

namespace WinFormsApp2.UserControls
{
    // The Rooms page: one row for every room.
    public partial class RoomsUserControl : UserControl
    {
        public RoomsUserControl()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            rowLivingRoom.Room = AppData.Rooms[0];
            rowBedroom.Room = AppData.Rooms[1];
            rowKitchen.Room = AppData.Rooms[2];
            rowBathroom.Room = AppData.Rooms[3];
            RefreshData();
        }

        public void RefreshData()
        {
            rowLivingRoom.RefreshFromRoom();
            rowBedroom.RefreshFromRoom();
            rowKitchen.RefreshFromRoom();
            rowBathroom.RefreshFromRoom();

            lblRoomsSummary.Text = AppData.Rooms.Count + " Rooms  •  " + AppData.GetOnRoomsCount() + " Lights On";
        }
    }
}
