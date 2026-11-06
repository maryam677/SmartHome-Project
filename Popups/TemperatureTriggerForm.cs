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
    public partial class TriggerDetailsForm : Form
    {
        public TriggerDetailsForm()
        {
            InitializeComponent();
        }


        public void SetTriggerType(string triggerType)
        {
            lblTitle.Text = triggerType + " Trigger";
            cmbTriggerType.SelectedItem = triggerType;
        }

    }
}
