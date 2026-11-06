using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.UserControls
{
    public partial class NotificationsControl : UserControl
    {
        public NotificationsControl()
        {
            InitializeComponent();
            RefreshNotifications();
        }


        private bool notification1Read = false;
        private bool notification2Read = false;
        private bool notification3Read = true;
        private bool notification4Read = true;

        private bool showUnreadOnly = false;

        private void RefreshNotifications()
        {
            pnlNotification1.Visible = !showUnreadOnly || !notification1Read;
            pnlNotification2.Visible = !showUnreadOnly || !notification2Read;
            pnlNotification3.Visible = !showUnreadOnly || !notification3Read;
            pnlNotification4.Visible = !showUnreadOnly || !notification4Read;

            pnlNotification1.BackColor = notification1Read
                ? Color.FromArgb(32, 38, 77)
                : Color.FromArgb(41, 46, 92);

            pnlNotification2.BackColor = notification2Read
                ? Color.FromArgb(32, 38, 77)
                : Color.FromArgb(41, 46, 92);

            pnlNotification3.BackColor = notification3Read
                ? Color.FromArgb(32, 38, 77)
                : Color.FromArgb(41, 46, 92);

            pnlNotification4.BackColor = notification4Read
                ? Color.FromArgb(32, 38, 77)
                : Color.FromArgb(41, 46, 92);

            int unreadCount = 0;

            if (!notification1Read) unreadCount++;
            if (!notification2Read) unreadCount++;
            if (!notification3Read) unreadCount++;
            if (!notification4Read) unreadCount++;

            btnUnread.Text = $"Unread ({unreadCount})";

            btnAll.BackColor = showUnreadOnly
                ? Color.FromArgb(48, 54, 93)
                : Color.FromArgb(112, 72, 220);

            btnUnread.BackColor = showUnreadOnly
                ? Color.FromArgb(112, 72, 220)
                : Color.FromArgb(48, 54, 93);

            btnMarkAllRead.Enabled = unreadCount > 0;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            showUnreadOnly = false;
            RefreshNotifications();
        }

        private void btnUnread_Click(object sender, EventArgs e)
        {
            showUnreadOnly = true;
            RefreshNotifications();
        }

        private void btnMarkAllRead_Click(object sender, EventArgs e)
        {
            notification1Read = true;
            notification2Read = true;
            notification3Read = true;
            notification4Read = true;

            showUnreadOnly = false;
            RefreshNotifications();
        }

    }
}
