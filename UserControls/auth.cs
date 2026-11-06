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


namespace WinFormsApp2
{
    public partial class auth : UserControl
    {
        public auth()
        {
            InitializeComponent();
        }

        

       


        private void btnCreateRoutine_Click_1(object sender, EventArgs e)
        {
            using (var form = new CreateRoutineForm())
            {
                form.ShowDialog(this);
            }
        }



        private void btnCreateRule_Click(object sender, EventArgs e)
        {
            using (CreateRuleForm form = new CreateRuleForm())
            {
                form.ShowDialog(this);
            }
        }



        private void btnSchedule_Click(object sender, EventArgs e)
        {
            using (ScheduleForm form = new ScheduleForm())
            {
                form.ShowDialog(this);
            }
        }



        private void btnplay1_Click_3(object sender, EventArgs e)
        {
            using (RoutineDetailsForm form = new RoutineDetailsForm())
            {
                form.ShowDialog(this);
            }
        }


        private void btnAwayPlay_Click(object sender, EventArgs e)
        {
            using (RoutineDetailsForm form = new RoutineDetailsForm())
            {
                form.ShowDialog(this);
            }
        }

        private void btnNightPlay_Click(object sender, EventArgs e)
        {
            using (RoutineDetailsForm form = new RoutineDetailsForm())
            {
                form.ShowDialog(this);
            }
        }

        private void btnVacationPlay_Click(object sender, EventArgs e)
        {
            using (RoutineDetailsForm form = new RoutineDetailsForm())
            {
                form.ShowDialog(this);
            }
        }



        private void btnMorningToggle_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "ON")
            {
                btn.Text = "OFF";
                btn.BackColor = Color.FromArgb(80, 85, 110);
            }
            else
            {
                btn.Text = "ON";
                btn.BackColor = Color.FromArgb(112, 72, 220);
            }
        }

        private void btnDeleteRule_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Are you sure you want to delete this rule?",
                "Delete Rule",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
        }






        private void OpenTrigger_Click(object sender, EventArgs e)
        {
            Control clicked = (Control)sender;

            string triggerType = clicked.Tag?.ToString() ?? clicked.Text;

            using (TriggerDetailsForm form = new TriggerDetailsForm())
            {
                form.SetTriggerType(triggerType);
                form.ShowDialog(this);
            }
        }



    }
}
