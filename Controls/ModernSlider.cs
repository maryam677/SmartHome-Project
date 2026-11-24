using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApp2.Controls
{
    /// <summary>
    /// Modern GDI+ slider control with a dynamic progress fill track,
    /// smooth rounded thumb, hover feedback, and drag interaction.
    /// Drop-in compatible with System.Windows.Forms.TrackBar.
    /// </summary>
    public class ModernSlider : Control, ISupportInitialize
    {
        private int value = 50;
        private int minimum = 0;
        private int maximum = 100;
        private bool isDragging = false;
        private bool isHovered = false;

        private Color trackColor = Color.FromArgb(40, 32, 78);
        private Color fillColor = Color.FromArgb(59, 130, 246);
        private Color thumbColor = Color.FromArgb(59, 130, 246);
        private Color thumbHoverColor = Color.FromArgb(96, 165, 250);

        private int trackHeight = 6;
        private int thumbSize = 16;

        public event EventHandler? Scroll;
        public event EventHandler? ValueChanged;

        public ModernSlider()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.Selectable, true);

            BackColor = Color.FromArgb(27, 21, 56);
            Cursor = Cursors.Hand;
            Size = new Size(281, 40);
        }

        public void BeginInit() { }
        public void EndInit() { }

        [Category("Behavior")]
        [DefaultValue(50)]
        public int Value
        {
            get => value;
            set
            {
                int clamped = Math.Max(minimum, Math.Min(maximum, value));
                if (this.value == clamped) return;
                this.value = clamped;
                Invalidate();
                ValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        [Category("Behavior")]
        [DefaultValue(0)]
        public int Minimum
        {
            get => minimum;
            set
            {
                minimum = value;
                if (this.value < minimum) Value = minimum;
                Invalidate();
            }
        }

        [Category("Behavior")]
        [DefaultValue(100)]
        public int Maximum
        {
            get => maximum;
            set
            {
                maximum = Math.Max(minimum + 1, value);
                if (this.value > maximum) Value = maximum;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color TrackColor
        {
            get => trackColor;
            set { trackColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color FillColor
        {
            get => fillColor;
            set { fillColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color ThumbColor
        {
            get => thumbColor;
            set { thumbColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color ThumbHoverColor
        {
            get => thumbHoverColor;
            set { thumbHoverColor = value; Invalidate(); }
        }

        // Dummy properties for WinForms TrackBar designer compatibility
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int TickFrequency { get; set; } = 10;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TickStyle TickStyle { get; set; } = TickStyle.None;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override bool AutoSize
        {
            get => base.AutoSize;
            set => base.AutoSize = value;
        }

        private Rectangle GetTrackBounds()
        {
            int padding = thumbSize / 2 + 2;
            int trackW = Math.Max(1, Width - padding * 2);
            int trackY = (Height - trackHeight) / 2;
            return new Rectangle(padding, trackY, trackW, trackHeight);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Clear background
            using (SolidBrush bgBrush = new SolidBrush(BackColor))
            {
                g.FillRectangle(bgBrush, ClientRectangle);
            }

            Rectangle trackRect = GetTrackBounds();
            if (trackRect.Width <= 0) return;

            // 1. Draw base unfilled track
            using (GraphicsPath trackPath = RoundedPanel.GetRoundedRectPath(trackRect, trackHeight / 2))
            using (SolidBrush trackBrush = new SolidBrush(trackColor))
            {
                g.FillPath(trackBrush, trackPath);
            }

            // 2. Draw dynamic filled track (progress line that grows/shrinks)
            float range = maximum - minimum;
            float ratio = range > 0 ? (float)(value - minimum) / range : 0f;
            ratio = Math.Max(0f, Math.Min(1f, ratio));

            int fillWidth = (int)Math.Round(ratio * trackRect.Width);
            if (fillWidth > 0)
            {
                Rectangle fillRect = new Rectangle(trackRect.X, trackRect.Y, fillWidth, trackHeight);
                using (GraphicsPath fillPath = RoundedPanel.GetRoundedRectPath(fillRect, trackHeight / 2))
                using (SolidBrush fillBrush = new SolidBrush(fillColor))
                {
                    g.FillPath(fillBrush, fillPath);
                }
            }

            // 3. Draw Thumb (the interactive "blue circle")
            int thumbX = trackRect.X + fillWidth;
            int thumbY = Height / 2;
            Rectangle thumbRect = new Rectangle(thumbX - thumbSize / 2, thumbY - thumbSize / 2, thumbSize, thumbSize);

            // Subtle glow around thumb when hovering or dragging
            if (isHovered || isDragging)
            {
                using (SolidBrush glowBrush = new SolidBrush(Color.FromArgb(50, thumbColor)))
                {
                    g.FillEllipse(glowBrush, thumbRect.X - 4, thumbRect.Y - 4, thumbSize + 8, thumbSize + 8);
                }
            }

            // Thumb body
            using (SolidBrush thumbBrush = new SolidBrush((isHovered || isDragging) ? thumbHoverColor : thumbColor))
            {
                g.FillEllipse(thumbBrush, thumbRect);
            }

            // Crisp inner border / highlight on thumb
            using (Pen borderPen = new Pen(Color.FromArgb(220, 255, 255, 255), 1.5f))
            {
                g.DrawEllipse(borderPen, thumbRect);
            }
        }

        private void UpdateValueFromMouse(int mouseX)
        {
            Rectangle trackRect = GetTrackBounds();
            if (trackRect.Width <= 0) return;

            float ratio = (float)(mouseX - trackRect.X) / trackRect.Width;
            ratio = Math.Max(0f, Math.Min(1f, ratio));
            int newValue = minimum + (int)Math.Round(ratio * (maximum - minimum));

            if (newValue != value)
            {
                Value = newValue;
                Scroll?.Invoke(this, EventArgs.Empty);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                Capture = true;
                UpdateValueFromMouse(e.X);
                Focus();
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (isDragging)
            {
                UpdateValueFromMouse(e.X);
            }
            else
            {
                // Check if hovering thumb or track
                Rectangle trackRect = GetTrackBounds();
                float ratio = (maximum - minimum) > 0 ? (float)(value - minimum) / (maximum - minimum) : 0f;
                int thumbX = trackRect.X + (int)Math.Round(ratio * trackRect.Width);
                int thumbY = Height / 2;
                Rectangle thumbRect = new Rectangle(thumbX - thumbSize / 2, thumbY - thumbSize / 2, thumbSize, thumbSize);
                bool hoveredNow = thumbRect.Contains(e.Location) || trackRect.Contains(e.Location);
                if (hoveredNow != isHovered)
                {
                    isHovered = hoveredNow;
                    Invalidate();
                }
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (isDragging)
            {
                isDragging = false;
                Capture = false;
                Invalidate();
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovered = false;
            Invalidate();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Down)
            {
                Value = Math.Max(minimum, value - 1);
                Scroll?.Invoke(this, EventArgs.Empty);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Up)
            {
                Value = Math.Min(maximum, value + 1);
                Scroll?.Invoke(this, EventArgs.Empty);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Home)
            {
                Value = minimum;
                Scroll?.Invoke(this, EventArgs.Empty);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.End)
            {
                Value = maximum;
                Scroll?.Invoke(this, EventArgs.Empty);
                e.Handled = true;
            }
        }
    }
}
