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
    public partial class Filtering : Form
    {
        private readonly Form1 _form;
        public Bitmap img;

        public Filtering(Form1 form)
        {
            InitializeComponent();
            _form = form;
            //img = new Bitmap(_form.getImage());
        }

        private Bitmap filter(Bitmap bitmap, int lefttop, int top, int righttop, int left, int middle, int right, int leftbottom, int bottom, int rightbottom)
        {
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
            int redIn, greenIn, blueIn;
            int redOut, greenOut, blueOut;
            int LTX, LTY, TX, TY, RTX, RTY, LX, LY, RX, RY, LBX, LBY, BX, BY, RBX, RBY;
            int divideby;

            for(int x=0; x<result.Width; x++)
            {
                for(int y=0; y<result.Height; y++)
                {
                    if (x > 0)
                    {
                        LTX = x - 1;
                        LX = x - 1;
                        LBX = x - 1;
                    }
                    else
                    {
                        LTX = x;
                        LX = x;
                        LBX = x;
                    }
                    if (x < result.Width - 1)
                    {
                        RTX = x + 1;
                        RX = x + 1;
                        RBX = x + 1;
                    }
                    else
                    {
                        RTX = x;
                        RX = x;
                        RBX = x;
                    }
                    if (y > 0)
                    {
                        LTY = y - 1;
                        TY = y - 1;
                        RTY = y - 1;
                    }
                    else
                    {
                        LTY = y;
                        TY = y;
                        RTY = y;
                    }
                    if (y < result.Height - 1)
                    {
                        LBY = y + 1;
                        BY = y + 1;
                        RBY = y + 1;
                    }
                    else
                    {
                        LBY = y;
                        BY = y;
                        RBY = y;
                    }
                    TX = x;
                    BX = x;
                    LY = y ;
                    RY = y;

                    divideby = lefttop + top + righttop + left + middle + right + leftbottom + bottom + rightbottom;
                    if (divideby == 0) divideby = 1;

                    redOut = (bitmap.GetPixel(LTX, LTY).R * lefttop + bitmap.GetPixel(TX, TY).R * top + bitmap.GetPixel(RTX, RTY).R * righttop +
                        bitmap.GetPixel(LX, LY).R * left + bitmap.GetPixel(x, y).R * middle + bitmap.GetPixel(RX, RY).R * right +
                        bitmap.GetPixel(LBX, LBY).R * leftbottom + bitmap.GetPixel(BX, BY).R * bottom + bitmap.GetPixel(RBX, RBY).R * rightbottom) / divideby;

                    greenOut = (bitmap.GetPixel(LTX, LTY).G * lefttop + bitmap.GetPixel(TX, TY).G * top + bitmap.GetPixel(RTX, RTY).G * righttop +
                        bitmap.GetPixel(LX, LY).G * left + bitmap.GetPixel(x, y).G * middle + bitmap.GetPixel(RX, RY).G * right +
                        bitmap.GetPixel(LBX, LBY).G * leftbottom + bitmap.GetPixel(BX, BY).G * bottom + bitmap.GetPixel(RBX, RBY).G * rightbottom) / divideby;

                    blueOut = (bitmap.GetPixel(LTX, LTY).B * lefttop + bitmap.GetPixel(TX, TY).B * top + bitmap.GetPixel(RTX, RTY).B * righttop +
                        bitmap.GetPixel(LX, LY).B * left + bitmap.GetPixel(x, y).B * middle + bitmap.GetPixel(RX, RY).B * right +
                        bitmap.GetPixel(LBX, LBY).B * leftbottom + bitmap.GetPixel(BX, BY).B * bottom + bitmap.GetPixel(RBX, RBY).B * rightbottom) / divideby;

                    result.SetPixel(x, y, Color.FromArgb(redOut, greenOut, blueOut));
                }
            }


            return result;
        }

        private int getMedian(int [] tab)
        {
            int temp;
            for(int i=0;i<tab.Length-1;i++)
            {
                for(int j=i+1; j<tab.Length; j++)
                {
                    if(tab[i]>tab[j])
                    {
                        temp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = temp;
                    }
                }
            }

            int result = tab[tab.Length / 2];
            return result;
        }

        private void averagingFilterButton_Click(object sender, EventArgs e)
        {
            _form.setImage(filter(_form.getImage(), 1, 1, 1, 1, 1, 1, 1, 1, 1));
        }
    }
}
