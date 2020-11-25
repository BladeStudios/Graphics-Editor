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

        private void Filtering_Load(object sender, EventArgs e)
        {
            if (Owner != null)
                Location = new Point(Owner.Location.X + Owner.Width / 2 - Width / 2,
                    Owner.Location.Y + Owner.Height / 2 - Height / 2);
        }

        private Bitmap filter(Bitmap bitmap, int lefttop, int top, int righttop, int left, int middle, int right, int leftbottom, int bottom, int rightbottom)
        {
            _form.startLoading();
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
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

                    if (redOut < 0) redOut = 0;
                    else if (redOut > 255) redOut = 255;
                    if (greenOut < 0) greenOut = 0;
                    else if (greenOut > 255) greenOut = 255;
                    if (blueOut < 0) blueOut = 0;
                    else if (blueOut > 255) blueOut = 255;

                    result.SetPixel(x, y, Color.FromArgb(redOut, greenOut, blueOut));
                }
            }

            _form.memoryAdd(result);
            _form.stopLoading();
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

        private Bitmap medianFiltering(Bitmap bitmap)
        {
            _form.startLoading();
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
            int redOut, greenOut, blueOut;
            int LTX, LTY, TX, TY, RTX, RTY, LX, LY, RX, RY, LBX, LBY, BX, BY, RBX, RBY;

            for (int x = 0; x < result.Width; x++)
            {
                for (int y = 0; y < result.Height; y++)
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
                    LY = y;
                    RY = y;

                    redOut = getMedian(new int[] {bitmap.GetPixel(LTX, LTY).R, bitmap.GetPixel(TX, TY).R, bitmap.GetPixel(RTX, RTY).R,
                        bitmap.GetPixel(LX, LY).R, bitmap.GetPixel(x, y).R, bitmap.GetPixel(RX, RY).R,
                        bitmap.GetPixel(LBX, LBY).R, bitmap.GetPixel(BX, BY).R, bitmap.GetPixel(RBX, RBY).R});

                    greenOut = getMedian(new int[] {bitmap.GetPixel(LTX, LTY).G, bitmap.GetPixel(TX, TY).G, bitmap.GetPixel(RTX, RTY).G,
                        bitmap.GetPixel(LX, LY).G, bitmap.GetPixel(x, y).G, bitmap.GetPixel(RX, RY).G,
                        bitmap.GetPixel(LBX, LBY).G, bitmap.GetPixel(BX, BY).G, bitmap.GetPixel(RBX, RBY).G});

                    blueOut = getMedian(new int[] {bitmap.GetPixel(LTX, LTY).B, bitmap.GetPixel(TX, TY).B, bitmap.GetPixel(RTX, RTY).B,
                        bitmap.GetPixel(LX, LY).B, bitmap.GetPixel(x, y).B, bitmap.GetPixel(RX, RY).B,
                        bitmap.GetPixel(LBX, LBY).B, bitmap.GetPixel(BX, BY).B, bitmap.GetPixel(RBX, RBY).B});

                    result.SetPixel(x, y, Color.FromArgb(redOut, greenOut, blueOut));
                }
            }
            _form.memoryAdd(result);
            _form.stopLoading();
            return result;
        }

        private void averagingFilterButton_Click(object sender, EventArgs e)
        {
            _form.setImage(filter(_form.getImage(), 1, 1, 1, 1, 1, 1, 1, 1, 1));
        }

        private void medianFilterButton_Click(object sender, EventArgs e)
        {
            _form.setImage(medianFiltering(_form.getImage()));
        }

        private void sobelFilterHorizontalButton_Click(object sender, EventArgs e)
        {
            _form.setImage(filter(_form.getImage(), -1, -2, -1, 0, 0, 0, 1, 2, 1));
        }

        private void sobelFilterVerticalButton_Click(object sender, EventArgs e)
        {
            _form.setImage(filter(_form.getImage(), -1, 0, 1, -2, 0, 2, -1, 0, 1));
        }

        private void highPassFilterButton_Click(object sender, EventArgs e)
        {
            _form.setImage(filter(_form.getImage(), -1, -1, -1, -1, 9, -1, -1, -1, -1));
        }

        private void gaussFilterButton_Click(object sender, EventArgs e)
        {
            _form.setImage(filter(_form.getImage(), 1, 2, 1, 2, 4, 2, 1, 2, 1));
        }

        private void customFilterButton_Click(object sender, EventArgs e)
        {
            _form.setImage(filter(_form.getImage(), Convert.ToInt32(leftTopValue.Value), Convert.ToInt32(topValue.Value), Convert.ToInt32(rightTopValue.Value), Convert.ToInt32(leftValue.Value),
                Convert.ToInt32(middleValue.Value), Convert.ToInt32(rightValue.Value), Convert.ToInt32(leftBottomValue.Value), Convert.ToInt32(bottomValue.Value), Convert.ToInt32(rightBottomValue.Value)));
        }
    }
}
