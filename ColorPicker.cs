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
            //rValue = Convert.ToInt32(redValue.Value);
            //gValue = Convert.ToInt32(greenValue.Value);
            //bValue = Convert.ToInt32(blueValue.Value);
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

        // ---------------- RGB --------------------------

        private void redValue_ValueChanged(object sender, EventArgs e)
        {
            redBar.Value = Convert.ToInt32(redValue.Value);
            rValue = redBar.Value;
            RGBtoHSV();
            RGBtoCMYK();
            updateColor();
            updateAllValues();
        }

        private void greenValue_ValueChanged(object sender, EventArgs e)
        {
            greenBar.Value = Convert.ToInt32(greenValue.Value);
            gValue = greenBar.Value;
            RGBtoHSV();
            RGBtoCMYK();
            updateColor();
            updateAllValues();
        }

        private void blueValue_ValueChanged(object sender, EventArgs e)
        {
            blueBar.Value = Convert.ToInt32(blueValue.Value);
            bValue = blueBar.Value;
            RGBtoHSV();
            RGBtoCMYK();
            updateColor();
            updateAllValues();
        }

        private void redBar_Scroll(object sender, EventArgs e)
        {
            rValue = redBar.Value;
            redValue.Value = redBar.Value;
            RGBtoHSV();
            RGBtoCMYK();
            updateColor();
            updateAllValues();
        }

        private void greenBar_Scroll(object sender, EventArgs e)
        {
            gValue = greenBar.Value;
            greenValue.Value = greenBar.Value;
            RGBtoHSV();
            RGBtoCMYK();
            updateColor();
            updateAllValues();
        }

        private void blueBar_Scroll(object sender, EventArgs e)
        {
            bValue = blueBar.Value;
            blueValue.Value = blueBar.Value;
            RGBtoHSV();
            RGBtoCMYK();
            updateColor();
            updateAllValues();
        }

        // ------------------------- HSV ----------------------------

        private void hueValue_ValueChanged(object sender, EventArgs e)
        {
            hueBar.Value = Convert.ToInt32(hueValue.Value);
            hValue = hueBar.Value;
            HSVtoRGB();
            //
            updateColor();
            updateAllValues();
        }

        private void saturationValue_ValueChanged(object sender, EventArgs e)
        {
            saturationBar.Value = Convert.ToInt32(saturationValue.Value);
            sValue = saturationBar.Value;
        }

        private void valueValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hueBar_Scroll(object sender, EventArgs e)
        {
            hValue = hueBar.Value;
            hueValue.Value = hueBar.Value;
            HSVtoRGB();
            HSVtoCMYK();
            updateColor();
            updateAllValues();
        }

        private void saturationBar_Scroll(object sender, EventArgs e)
        {

        }

        private void valueBar_Scroll(object sender, EventArgs e)
        {

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
            if (diff == 0)
                hue = 0;
            else if (cmax == r01)
                hue = (60 * ((g01 - b01) / diff) + 360) % 360;
            else if (cmax == g01)
                hue = (60 * ((b01 - r01) / diff) + 120) % 360;
            else //if (cmax == b01)
                hue = (60 * ((r01 - g01) / diff) + 240) % 360;

            //if (hue == 360) hue = 0;

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
            double h01, s01, v01;
            double chroma, x, absolute;
            double r01, g01, b01;
            double red, green, blue;

            //calculating h01, s01 and v01
            h01 = Convert.ToDouble(hValue) / 60;
            s01 = Convert.ToDouble(sValue) / 100;
            v01 = Convert.ToDouble(vValue) / 100;

            //calculating chroma and x
            chroma = v01 * s01;
            absolute = (h01 % 2) - 1;
            if (absolute < 0)
                absolute = absolute * (-1);
            x = chroma * (1 - absolute);

            //calculating rgb
            if(h01 >= 0 && h01 <= 1)
            {
                r01 = chroma;
                g01 = x;
                b01 = 0;
            }
            else if (h01 > 1 && h01 <= 2)
            {
                r01 = x;
                g01 = chroma;
                b01 = 0;
            }
            else if (h01 > 2 && h01 <= 3)
            {
                r01 = 0;
                g01 = chroma;
                b01 = x;
            }
            else if (h01 > 3 && h01 <= 4)
            {
                r01 = 0;
                g01 = x;
                b01 = chroma;
            }
            else if (h01 > 4 && h01 <= 5)
            {
                r01 = x;
                g01 = 0;
                b01 = chroma;
            }
            else //if (h01 > 5 && h01 <= 6)
            {
                r01 = chroma;
                g01 = 0;
                b01 = x;
            }

            red = r01 + v01 - chroma;
            green = g01 + v01 - chroma;
            blue = b01 + v01 - chroma;

            rValue = Convert.ToInt32((red * 255));
            gValue = Convert.ToInt32((green * 255));
            bValue = Convert.ToInt32((blue * 255));
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

            if(keyColor==1)
            {
                cyan = 1;
                magenta = 1;
                yellow = 1;
            }
            else
            {
                cyan = (1 - r01 - keyColor) / (1 - keyColor);
                magenta = (1 - g01 - keyColor) / (1 - keyColor);
                yellow = (1 - b01 - keyColor) / (1 - keyColor);
            }
            cValue = Convert.ToInt32((cyan * 100));
            mValue = Convert.ToInt32((magenta * 100));
            yValue = Convert.ToInt32((yellow * 100));
        }

        private void CMYKtoRGB()
        {
            double c01, m01, y01, k01; //CMYK changed from 0-100 to 0-1
            double red, green, blue;

            //casting cmyk from 0-100 to 0-1
            c01 = Convert.ToDouble(cValue) / 100;
            m01 = Convert.ToDouble(mValue) / 100;
            y01 = Convert.ToDouble(yValue) / 100;
            k01 = Convert.ToDouble(kValue) / 100;

            red = 255 * (1 - c01) * (1 - k01);
            green = 255 * (1 - m01) * (1 - k01);
            blue = 255 * (1 - y01) * (1 - k01);

            rValue = Convert.ToInt32(red);
            gValue = Convert.ToInt32(green);
            bValue = Convert.ToInt32(blue);
        }

        private void HSVtoCMYK()
        {
            HSVtoRGB();
            RGBtoCMYK();
        }

        private void CMYKtoHSV()
        {
            CMYKtoRGB();
            RGBtoHSV();
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
