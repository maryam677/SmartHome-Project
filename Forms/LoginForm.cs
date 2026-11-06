using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Forms;
namespace WinFormsApp2.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (main dashboard = new main())
            {
                dashboard.ShowDialog();
            }

            this.Show();

        }

        private void btnGoRegister_Click(object sender, EventArgs e)
        {
            using (RegesterForm register = new RegesterForm())
            {
                register.ShowDialog(this);
            }

        }
    }
}
