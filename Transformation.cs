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
        public Transformation(Form1 form)
        {
            InitializeComponent();
            _form = form;
            img = _form.getImage();
        }

        private void transform(int mode)
        {
            //0 - add, 1 - subtract, 2 - multiply, 3 - divide
            Color pixelColor;
            int newR, newG, newB;

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
                                _form.console.Text = _form.console.Text + "Error: Invalid operation mode - Transformation:transform()";
                                this.Close();
                            } break;
                    }
                    img.SetPixel(i, j, Color.FromArgb(newR, newG, newB));
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
    }
}
