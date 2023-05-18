using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР8
{
    public partial class Form2 : Form
    {
        Color colorResult;
        
        public Form2(Color color)
        {
            InitializeComponent();

            hScrollBarRed.Tag = numericUpDownRed;
            hScrollBarGreen.Tag = numericUpDownGreen;
            hScrollBarBlue.Tag = numericUpDownBlue;

            numericUpDownRed.Tag = hScrollBarRed;
            numericUpDownGreen.Tag = hScrollBarGreen;

            numericUpDownBlue.Tag = hScrollBarBlue;

            numericUpDownRed.Value = color.R;
            numericUpDownGreen.Value = color.G;
            numericUpDownBlue.Value = color.B;
        }

        private void hScrollBarRed_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            UpdateColor();
        }

        private void hScrollBarGreen_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            UpdateColor();
        }

        private void hScrollBarBlue_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            UpdateColor();
        }

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
            UpdateColor();
        }

        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
            UpdateColor();
        }

        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
            UpdateColor();
        }

        private void UpdateColor()
        {
            colorResult = Color.FromArgb(hScrollBarRed.Value, hScrollBarGreen.Value, hScrollBarBlue.Value);
            pictureBoxColors.BackColor = colorResult;
        }

        private void buttonColors_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                hScrollBarRed.Value = colorDialog.Color.R;
                hScrollBarGreen.Value = colorDialog.Color.G;
                hScrollBarBlue.Value = colorDialog.Color.B;
                colorResult = colorDialog.Color;
                UpdateColor();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Form1 form1 = this.Owner as Form1;
            form1.currentPen.Color = colorResult;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
