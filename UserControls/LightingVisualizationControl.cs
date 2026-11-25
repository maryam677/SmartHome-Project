using System;
using System.Drawing;
using System.Windows.Forms;
using WinFormsApp2.Controls;
using WinFormsApp2.Data;

namespace WinFormsApp2.UserControls
{
    /// <summary>
    /// Composite UserControl that hosts the GDI+ lighting visualizations:
    ///   - LightSourcePanel  (interactive glowing circles for each room)
    ///   - LightingGraphPanel (brightness-history line graph + room bar chart)
    /// It subscribes to <see cref="AppData.DataChanged"/> so the graphics
    /// update automatically whenever a slider, button, or quick action fires.
    /// </summary>
    public class LightingVisualizationControl : UserControl
    {
        private readonly LightSourcePanel lightSourcePanel;
        private readonly LightingGraphPanel graphPanel;

        public LightingVisualizationControl()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);

            BackColor = Color.FromArgb(9, 8, 23);

            // ---- Light source circles (top row) ----
            lightSourcePanel = new LightSourcePanel
            {
                Location = new Point(0, 0),
                Size = new Size(1300, 200)
            };

            // ---- Line graph + bar chart (bottom row) ----
            graphPanel = new LightingGraphPanel
            {
                Location = new Point(0, 210),
                Size = new Size(1300, 250)
            };

            Controls.Add(lightSourcePanel);
            Controls.Add(graphPanel);

            // Wire cross-panel interaction
            lightSourcePanel.RoomSelected += (s, roomIndex) =>
            {
                if (graphPanel.HighlightedRoom == roomIndex)
                {
                    graphPanel.HighlightedRoom = -1;
                }
                else
                {
                    graphPanel.HighlightedRoom = roomIndex;
                }
            };

            graphPanel.BarClicked += (s, roomIndex) =>
            {
                lightSourcePanel.SelectedIndex = roomIndex;
                if (graphPanel.HighlightedRoom == roomIndex)
                    graphPanel.HighlightedRoom = -1;
                else
                    graphPanel.HighlightedRoom = roomIndex;
            };

            graphPanel.RecordSnapshot();
        }

        public void StartListening()
        {
            AppData.DataChanged += OnDataChanged;
        }

        public void RefreshVisuals()
        {
            graphPanel.RecordSnapshot();
            lightSourcePanel.Invalidate();
        }

        private void OnDataChanged()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(OnDataChanged));
                return;
            }
            RefreshVisuals();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (lightSourcePanel == null || graphPanel == null) return;

            int w = ClientSize.Width;
            int topHeight = Math.Max(180, (int)(ClientSize.Height * 0.42));
            int gap = 10;
            int bottomHeight = ClientSize.Height - topHeight - gap;

            lightSourcePanel.SetBounds(0, 0, w, topHeight);
            graphPanel.SetBounds(0, topHeight + gap, w, bottomHeight);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                AppData.DataChanged -= OnDataChanged;
            }
            base.Dispose(disposing);
        }
    }
}
