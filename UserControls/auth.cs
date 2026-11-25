using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.classes;
using WinFormsApp2.Popups;



namespace WinFormsApp2
{
    public partial class auth : UserControl
    {
        public auth()
        {
            InitializeComponent();

            int overviewInset = pnlOverview.ClientSize.Width * 15 / 353;
            int chartSize = Math.Min(180, label4.Left - 2 * overviewInset);
            AutomationDonutChart chart = new AutomationDonutChart
            {
                EnabledCount = 4,
                DisabledCount = 1,
                Size = new Size(chartSize, chartSize),
                Location = new Point(overviewInset, overviewTitle.Bottom + overviewInset)
            };

            pnlOverview.Controls.Add(chart);
            chart.BringToFront();

            void UpdateOverviewCounts()
            {
                label4.Text =
                    $"{chart.EnabledCount + (long)chart.DisabledCount} Total\n" +
                    $"{chart.EnabledCount} Enabled\n" +
                    $"{chart.DisabledCount} Disabled\n";
            }

            chart.CountsChanged += (_, _) => UpdateOverviewCounts();
            UpdateOverviewCounts();

            int scheduleInset = lblScheduleTitle.Left;
            int timelineTop = lblScheduleTitle.Bottom + 8;
            AutomationTimeline timeline = new AutomationTimeline
            {
                Location = new Point(scheduleInset, timelineTop),
                Size = new Size(
                    pnlSchedule.ClientSize.Width - 2 * scheduleInset,
                    pnlSchedule.ClientSize.Height - timelineTop - scheduleInset
                ),
                Anchor = AnchorStyles.Top |
                         AnchorStyles.Left |
                         AnchorStyles.Right |
                         AnchorStyles.Bottom
            };

            pnlSchedule.Controls.Add(timeline);
            timeline.BringToFront();


            ApplyRoundedUI();

        }




        private void ApplyRoundedUI()
        {
           
            UiRoundHelper.ApplyRoundedRegion(pnlSchedule, 20);
            UiRoundHelper.ApplyRoundedRegion(pnlOverview, 20);
            UiRoundHelper.ApplyRoundedRegion(pnlMorning, 20);
            UiRoundHelper.ApplyRoundedRegion(pnlAway, 20);
            UiRoundHelper.ApplyRoundedRegion(pnlNight, 20);
            UiRoundHelper.ApplyRoundedRegion(pnlVacation, 20);
            UiRoundHelper.ApplyRoundedRegion(rulesPanel, 20);
            UiRoundHelper.ApplyRoundedRegion(pnlTriggers, 20);
            UiRoundHelper.ApplyRoundedRegion(panel2, 20);
            UiRoundHelper.ApplyRoundedRegion(panel3, 20);
            UiRoundHelper.ApplyRoundedRegion(panel4, 20);
            UiRoundHelper.ApplyRoundedRegion(panel5, 20);
            UiRoundHelper.ApplyRoundedRegion(panel11, 20);
            UiRoundHelper.ApplyRoundedRegion(panel6, 20);
            UiRoundHelper.ApplyRoundedRegion(panel8, 20);
            UiRoundHelper.ApplyRoundedRegion(panel9, 20);
            UiRoundHelper.ApplyRoundedRegion(btnCreateRoutine, 8);
            UiRoundHelper.ApplyRoundedRegion(btnSchedule, 8);





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
