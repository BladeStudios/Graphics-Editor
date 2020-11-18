using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Editor
{
    public partial class ColorPicker : Form
    {
        private readonly Form1 _form;
        public Bitmap Image;
        int rValue, gValue, bValue;
        public ColorPicker(Form1 form)
        {
            InitializeComponent();
            _form = form;
            Image = new Bitmap(this.pictureBox.Width, this.pictureBox.Height);
            updateColor();
        }

        private void updateColor()
        {
            rValue = Convert.ToInt32(redValue.Value);
            gValue = Convert.ToInt32(greenValue.Value);
            bValue = Convert.ToInt32(blueValue.Value);
            Graphics g;
            g = Graphics.FromImage(Image);
            SolidBrush b = new SolidBrush(Color.FromArgb(rValue, gValue, bValue));
            g.FillRectangle(b, 0, 0, pictureBox.Width, pictureBox.Height);
            pictureBox.Image = Image;
            g.Dispose();
        }

        private void redBar_Scroll(object sender, EventArgs e)
        {
            redValue.Value = redBar.Value;
            updateColor();
        }

        private void selectColorButton_Click(object sender, EventArgs e)
        {
            _form.appState.setColor(Color.FromArgb(rValue, gValue, bValue));
            _form.menuColorOther.Checked = true;
            _form.menuColorOther.CheckState = CheckState.Checked;
            _form.menuColorOther.Image = Image;
            _form.menuColor.Image = Image;
            this.Close();
        }

        private void redValue_ValueChanged(object sender, EventArgs e)
        {
            redBar.Value = Convert.ToInt32(redValue.Value);
            updateColor();
        }

        private void greenValue_ValueChanged(object sender, EventArgs e)
        {
            greenBar.Value = Convert.ToInt32(greenValue.Value);
            updateColor();
        }

        private void blueValue_ValueChanged(object sender, EventArgs e)
        {
            blueBar.Value = Convert.ToInt32(blueValue.Value);
            updateColor();
        }

        private void greenBar_Scroll(object sender, EventArgs e)
        {
            greenValue.Value = greenBar.Value;
            updateColor();
        }

        private void blueBar_Scroll(object sender, EventArgs e)
        {
            blueValue.Value = blueBar.Value;
            updateColor();
        }

    }
}
