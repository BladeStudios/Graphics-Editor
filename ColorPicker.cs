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
        int rValue, gValue, bValue, hValue, sValue, vValue, cValue, mValue, yValue, kValue;
        public ColorPicker(Form1 form)
        {
            InitializeComponent();
            _form = form;
            Image = new Bitmap(this.pictureBox.Width, this.pictureBox.Height);
            rValue = 0;
            gValue = 0;
            bValue = 0;
            hValue = 0;
            sValue = 0;
            vValue = 0;
            cValue = 100;
            mValue = 100;
            yValue = 100;
            kValue = 100;
            updateColor();
            updateAllValues();
        }

        private void updateAllValues()
        {
            redValue.Value = rValue;
            redBar.Value = rValue;
            greenValue.Value = gValue;
            greenBar.Value = gValue;
            blueValue.Value = bValue;
            blueBar.Value = bValue;

            hueValue.Value = hValue;
            hueBar.Value = hValue;
            saturationValue.Value = sValue;
            saturationBar.Value = sValue;
            valueValue.Value = vValue;
            valueBar.Value = vValue;

            cyanValue.Value = cValue;
            cyanBar.Value = cValue;
            magentaValue.Value = mValue;
            magentaBar.Value = mValue;
            yellowValue.Value = yValue;
            yellowBar.Value = yValue;
            keyColorValue.Value = kValue;
            keyColorBar.Value = kValue;
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

        private void redBar_Scroll(object sender, EventArgs e)
        {
            redValue.Value = redBar.Value;
            updateColor();
            RGBtoHSV();
            RGBtoCMYK();
            updateAllValues();
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

        private void hueBar_Scroll(object sender, EventArgs e)
        {
            hueValue.Value = hueBar.Value;
        }

        private void RGBtoHSV()
        {
            double r01, g01, b01; //rgb changed from 0-255 to 0-1
            double hue, saturation, value;
            double cmin, cmax, diff;

            //casting rgb from 0-255 to 0-1
            r01 = Convert.ToDouble(rValue) / 255;
            g01 = Convert.ToDouble(gValue) / 255;
            b01 = Convert.ToDouble(bValue) / 255;

            //calculating cmin, cmax and diff
            cmin = getMin(r01, g01, b01);
            cmax = getMax(r01, g01, b01);
            diff = cmax - cmin;

            //hue calculation
            if (cmax == 0 && cmin == 0)
                hue = 0;
            else if (cmax == r01)
                hue = (60 * ((g01 - b01) / diff) + 360) % 360;
            else if (cmax == g01)
                hue = (60 * ((b01 - r01) / diff) + 120) % 360;
            else //if (cmax == b01)
                hue = (60 * ((r01 - g01) / diff) + 240) % 360;

            hValue = Convert.ToInt32(hue);

            //saturation calculation
            if (cmax == 0)
                saturation = 0;
            else
                saturation = (diff / cmax) * 100;

            sValue = Convert.ToInt32(saturation);

            //value calculation
            value = cmax * 100;

            vValue = Convert.ToInt32(value);
        }

        private void HSVtoRGB()
        {

        }

        private void RGBtoCMYK()
        {
            double r01, g01, b01; //rgb changed from 0-255 to 0-1
            double cyan, magenta, yellow, keyColor;
            double cmax;

            //casting rgb from 0-255 to 0-1
            r01 = Convert.ToDouble(rValue) / 255;
            g01 = Convert.ToDouble(gValue) / 255;
            b01 = Convert.ToDouble(bValue) / 255;

            //calculation cmax
            cmax = getMax(r01, g01, b01);

            //calculating colors
            keyColor = (1 - cmax);
            kValue = Convert.ToInt32((keyColor*100));
            cyan = (1 - r01 - keyColor) / (1 - keyColor);
            cValue = Convert.ToInt32((cyan * 100));
            magenta = (1 - g01 - keyColor) / (1 - keyColor);
            mValue = Convert.ToInt32((magenta * 100));
            yellow = (1 - b01 - keyColor) / (1 - keyColor);
            yValue = Convert.ToInt32((yellow * 100));
        }

        private double getMin(double a, double b, double c)
        {
            if (a <= b)
            {
                if (a <= c)
                    return a;
                else
                    return c;
            }
            else
            {
                if (b <= c)
                    return b;
                else
                    return c;
            }
        }

        private double getMax(double a, double b, double c)
        {
            if (a >= b)
            {
                if (a >= c)
                    return a;
                else
                    return c;
            }
            else
            {
                if (b >= c)
                    return b;
                else
                    return c;
            }
        }

    }
}
