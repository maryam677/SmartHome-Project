using System;
using System.Drawing;
using System.Windows.Forms;
using SmartHomeLightingSystem.Data;

namespace SmartHomeLightingSystem.UserControls
{
    // The navigation menu on the left side.
    // Every button has its page name in the Tag property (Lighting, Rooms, ...).
    public partial class NavigationUserControl : UserControl
    {
        // MainForm listens to this event to switch the page
        public event Action<string> PageSelected;

        public NavigationUserControl()
        {
            InitializeComponent();
        }

        private void NavigationButton_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            SelectButton(clicked);

            if (PageSelected != null)
            {
                PageSelected(clicked.Tag.ToString());
            }
        }

        // Shows the purple "active" style on the selected button only
        private void SelectButton(Button selected)
        {
            Button[] buttons = { btnLighting, btnRooms, btnOverview, btnSettings, btnSecurity, btnEnergy };

            foreach (Button button in buttons)
            {
                if (button == selected)
                {
                    button.BackColor = AppColors.PrimaryPurple;
                    button.ForeColor = AppColors.PrimaryText;
                    button.FlatAppearance.MouseOverBackColor = AppColors.PrimaryPurple;
                    button.Font = new Font(button.Font, FontStyle.Bold);
                }
                else
                {
                    button.BackColor = AppColors.NavigationBackground;
                    button.ForeColor = AppColors.SecondaryText;
                    button.FlatAppearance.MouseOverBackColor = AppColors.HoverBackground;
                    button.Font = new Font(button.Font, FontStyle.Regular);
                }
            }
        }
    }
}
