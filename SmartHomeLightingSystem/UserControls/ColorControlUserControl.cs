using System;
using System.Drawing;
using System.Windows.Forms;
using SmartHomeLightingSystem.Controls;
using SmartHomeLightingSystem.Data;

namespace SmartHomeLightingSystem.UserControls
{
    // Lets the user choose the light color of all rooms.
    public partial class ColorControlUserControl : UserControl
    {
        public ColorControlUserControl()
        {
            InitializeComponent();
        }

        private ColorSwatchButton[] GetSwatches()
        {
            return new ColorSwatchButton[]
            {
                swatchPurple, swatchBlue, swatchCyan, swatchGreen, swatchYellow, swatchOrange, swatchPink
            };
        }

        // One of the 7 round color buttons was clicked
        private void Swatch_Click(object sender, EventArgs e)
        {
            ColorSwatchButton clicked = (ColorSwatchButton)sender;
            MarkSelected(clicked);
            SelectColor(clicked.SwatchColor, clicked.Tag.ToString());
        }

        // The user clicked somewhere on the rainbow bar
        private void gradientBar_ColorPicked(object sender, EventArgs e)
        {
            MarkSelected(null);
            SelectColor(gradientBar.PickedColor, "Custom");
        }

        private void btnCustomColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                MarkSelected(null);
                SelectColor(colorDialog.Color, "Custom");
            }
        }

        private void MarkSelected(ColorSwatchButton selected)
        {
            foreach (ColorSwatchButton swatch in GetSwatches())
            {
                swatch.Selected = (swatch == selected);
            }
        }

        private void SelectColor(Color color, string colorName)
        {
            pnlSelectedColor.FillColor = color;
            pnlSelectedColor.Invalidate();
            lblSelectedColorName.Text = colorName;

            AppData.SetColorForAllRooms(color);
        }
    }
}
