using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartHomeLightingSystem.UserControls
{
    // Top bar with the logo, the notification bell and the window buttons.
    public partial class HeaderUserControl : UserControl
    {
        // Variables used to move the window with the mouse
        private bool isDragging = false;
        private Point dragCursorStart;
        private Point dragFormStart;

        public HeaderUserControl()
        {
            InitializeComponent();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All systems are working. There are no new alerts.",
                "SmartHome Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            FindForm().WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            Form form = FindForm();

            if (form.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Normal;
                btnMaximize.Text = "\uE922";   // maximize icon
            }
            else
            {
                form.WindowState = FormWindowState.Maximized;
                btnMaximize.Text = "\uE923";   // restore icon
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FindForm().Close();
        }

        // ----- Move the window by dragging the header -----

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            Form form = FindForm();
            if (e.Button == MouseButtons.Left && form.WindowState == FormWindowState.Normal)
            {
                isDragging = true;
                dragCursorStart = Cursor.Position;
                dragFormStart = form.Location;
            }
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point cursor = Cursor.Position;
                FindForm().Location = new Point(
                    dragFormStart.X + cursor.X - dragCursorStart.X,
                    dragFormStart.Y + cursor.Y - dragCursorStart.Y);
            }
        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
