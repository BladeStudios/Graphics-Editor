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
    public partial class Form1 : Form
    {
        File file;
        public Bitmap Image;
        public Form1()
        {
            InitializeComponent();
            file = new File(this);

            //setting button images
            int size = 20;

            this.menuColor.Image = createBitmap(size, 0, 0, 0);
            this.menuColorBlack.Image = createBitmap(size, 0, 0, 0);
            this.menuColorWhite.Image = createBitmap(size, 255, 255, 255);
            this.menuColorRed.Image = createBitmap(size,255,0,0);
            this.menuColorGreen.Image = createBitmap(size, 0, 255, 0);
            this.menuColorBlue.Image = createBitmap(size, 0, 0, 255);
            this.menuColorYellow.Image = createBitmap(size, 255, 255, 0);
            this.menuColorCyan.Image = createBitmap(size, 0, 255, 255);
            this.menuColorMagenta.Image = createBitmap(size, 255, 0, 255);
            this.menuColorOrange.Image = createBitmap(size, 255, 165, 0);
            this.menuColorViolet.Image = createBitmap(size, 238, 82, 238);
            this.menuColorGrey.Image = createBitmap(size, 80, 80, 80);
        }

        private void menuFileNew_Click(object sender, EventArgs e)
        {
            file.New();
        }

        private void menuFileNewWindow_Click(object sender, EventArgs e)
        {
            file.NewWindow();
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            file.Open();
        }

        Bitmap createBitmap(int size, int red, int green, int blue)
        {
            Bitmap bitmap = new Bitmap(size, size);
            Graphics graphics = Graphics.FromImage(bitmap);
            SolidBrush solidbrush = new SolidBrush(Color.FromArgb(red, green, blue));
            graphics.FillRectangle(solidbrush, 0, 0, size, size);
            return bitmap;
        }
    }
}
