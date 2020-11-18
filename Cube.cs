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
    public partial class Cube : Form
    {
        private readonly Form1 _form;
        public Cube(Form1 form)
        {
            InitializeComponent();
            _form = form;
            drawCube();
        }

        private void drawCube()
        {
            Pen p = new Pen(Color.Black);

            //top
            Bitmap top = new Bitmap(256, 256);
            Graphics gTop;
            gTop = Graphics.FromImage(top);
            gTop.DrawRectangle(p, new Rectangle(22, 22, 256, 256));
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    top.SetPixel(i, j, Color.FromArgb(j, i, 255));
                }
            }
            pictureBox1.Image = top;

            //left
            Bitmap left = new Bitmap(256, 256);
            Graphics gLeft;
            gLeft = Graphics.FromImage(left);
            gLeft.DrawRectangle(p, new Rectangle(22, 22, 256, 256));
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    left.SetPixel(i, j, Color.FromArgb(i, 0, 255-j));
                }
            }
            pictureBox2.Image = left;

            //front
            Bitmap front = new Bitmap(256,256);
            Graphics gFront;
            gFront = Graphics.FromImage(front);
            gFront.DrawRectangle(p, new Rectangle(22, 22, 256, 256));
            for(int i=0;i<256;i++)
            {
                for(int j=0; j<256; j++)
                {
                    front.SetPixel(i, j, Color.FromArgb(255, i, 255-j));
                }
            }
            pictureBox3.Image = front;

            //right
            Bitmap right = new Bitmap(256, 256);
            Graphics gRight;
            gRight = Graphics.FromImage(right);
            gRight.DrawRectangle(p, new Rectangle(22, 22, 256, 256));
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    right.SetPixel(i, j, Color.FromArgb(255-i, 255, 255-j));
                }
            }
            pictureBox4.Image = right;

            //back
            Bitmap back = new Bitmap(256, 256);
            Graphics gBack;
            gBack = Graphics.FromImage(back);
            gBack.DrawRectangle(p, new Rectangle(22, 22, 256, 256));
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    back.SetPixel(i, j, Color.FromArgb(0, 255-i, 255 - j));
                }
            }
            pictureBox5.Image = back;

            //bottom
            Bitmap bottom = new Bitmap(256, 256);
            Graphics gBottom;
            gBottom = Graphics.FromImage(bottom);
            gBottom.DrawRectangle(p, new Rectangle(22, 22, 256, 256));
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    bottom.SetPixel(i, j, Color.FromArgb(255-j, i, 0));
                }
            }
            pictureBox6.Image = bottom;

        }
    }
}
