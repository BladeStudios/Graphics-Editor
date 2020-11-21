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
    public partial class Transformation : Form
    {
        private readonly Form1 _form;
        public Bitmap img;
        public Bitmap temp;
        public Transformation(Form1 form)
        {
            InitializeComponent();
            _form = form;
            img = _form.getImage();
            temp = null;
        }

        private void transform(int mode)
        {
            //0 - add, 1 - subtract, 2 - multiply, 3 - divide
            resetBrightness();
            Color pixelColor;
            int newR, newG, newB;
            if (Convert.ToInt32(value.Value) == 0 && mode == 3)
                mode = 4;

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    pixelColor = img.GetPixel(i, j);
                    switch (mode)
                    {
                        case 0:
                            {
                                newR = (pixelColor.R + Convert.ToInt32(value.Value)) % 256;
                                newG = (pixelColor.G + Convert.ToInt32(value.Value)) % 256;
                                newB = (pixelColor.B + Convert.ToInt32(value.Value)) % 256;
                            } break;
                        case 1:
                            {
                                newR = (pixelColor.R + (256 - Convert.ToInt32(value.Value) % 256)) % 256;
                                newG = (pixelColor.G + (256 - Convert.ToInt32(value.Value) % 256)) % 256;
                                newB = (pixelColor.B + (256 - Convert.ToInt32(value.Value) % 256)) % 256;
                            } break;
                        case 2:
                            {
                                newR = (pixelColor.R * Convert.ToInt32(value.Value)) % 256;
                                newG = (pixelColor.G * Convert.ToInt32(value.Value)) % 256;
                                newB = (pixelColor.B * Convert.ToInt32(value.Value)) % 256;
                            } break;
                        case 3:
                            {
                                newR = Convert.ToInt32((Convert.ToDouble(pixelColor.R) / Convert.ToDouble(value.Value)) % 256);
                                newG = Convert.ToInt32((Convert.ToDouble(pixelColor.G) / Convert.ToDouble(value.Value)) % 256);
                                newB = Convert.ToInt32((Convert.ToDouble(pixelColor.B) / Convert.ToDouble(value.Value)) % 256);
                            } break;
                        default:
                            {
                                newR = 0;
                                newG = 0;
                                newB = 0;
                                if(mode==4)
                                    _form.console.Text = _form.console.Text + "Error: Cannot divide by 0.";
                                else
                                    _form.console.Text = _form.console.Text + "Error: Unable to transform.";
                                this.Close();
                            } break;
                    }
                    img.SetPixel(i, j, Color.FromArgb(newR, newG, newB));
                }
            }
            _form.setImage(img);
        }

        private void changeBrightness(int brightness)
        {
            if (temp == null)
            {
                temp = img.Clone(new Rectangle(0, 0, img.Width, img.Height), System.Drawing.Imaging.PixelFormat.DontCare);
            }
            int newR, newG, newB;

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    newR = temp.GetPixel(i, j).R + brightness;
                    newG = temp.GetPixel(i, j).G + brightness;
                    newB = temp.GetPixel(i, j).B + brightness;
                    if (newR > 255) newR = 255;
                    else if (newR < 0) newR = 0;
                    if (newG > 255) newG = 255;
                    else if (newG < 0) newG = 0;
                    if (newB > 255) newB = 255;
                    else if (newB < 0) newB = 0;
                    img.SetPixel(i, j, Color.FromArgb(newR, newG, newB));
                }
            }
            _form.setImage(img);
        }

        private void resetBrightness()
        {
            temp = null;
            brightnessBar.Value = 0;
            brightnessValue.Value = 0;
        }

        private void averagingAlghoritm()
        {
            int grey;
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    grey = (img.GetPixel(i,j).R + img.GetPixel(i, j).G + img.GetPixel(i, j).B)/3;
                    img.SetPixel(i, j, Color.FromArgb(grey, grey, grey));
                }
            }
            _form.setImage(img);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            transform(0);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            transform(1);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            transform(2);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            transform(3);
        }

        private void brightnessBar_Scroll(object sender, EventArgs e)
        {
            brightnessValue.Value = brightnessBar.Value;
            changeBrightness(brightnessBar.Value);
        }

        private void brightnessValue_ValueChanged(object sender, EventArgs e)
        {
            brightnessBar.Value = Convert.ToInt32(brightnessValue.Value);
            changeBrightness(Convert.ToInt32(brightnessValue.Value));
        }

        private void averagingButton_Click(object sender, EventArgs e)
        {
            averagingAlghoritm();
        }
    }
}
