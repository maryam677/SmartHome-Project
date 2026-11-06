using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Popups;

namespace WinFormsApp2.UserControls
{
    public partial class AccountSettingsControl : UserControl
    {
        public AccountSettingsControl()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            using (ChangePasswordForm form = new ChangePasswordForm())
            {
                form.ShowDialog(this);
            }

        }
    }
}
