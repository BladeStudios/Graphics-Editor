using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_Editor
{
    class Drawing
    {
        private readonly Form1 _form;

        public Drawing(Form1 form)
        {
            _form = form;
        }

        public void drawPoint(int x, int y, Color color)
        {
            if (_form.layers.Count == 0)
            {
                _form.setImage(new Bitmap(_form.pictureBox.Width, _form.pictureBox.Height), 0);
            }
            Graphics g;
            g = Graphics.FromImage(_form.layers[0]);
            SolidBrush b = new SolidBrush(color);
            g.FillRectangle(b, x, y, 1, 1);
            _form.pictureBox.Image = _form.layers[0].Clone(new Rectangle(0, 0, _form.layers[0].Width, _form.layers[0].Height), System.Drawing.Imaging.PixelFormat.DontCare);
            g.Dispose();
            
        }

        public void drawPointBitmap(int x, int y, Color color, Bitmap bitmap)
        {
            if (bitmap == null)
                bitmap = new Bitmap(_form.pictureBox.Width, _form.pictureBox.Height);
            Graphics g;
            g = Graphics.FromImage(bitmap);
            SolidBrush b = new SolidBrush(color);
            g.FillRectangle(b, x, y, 1, 1);
            _form.pictureBox.Image = _form.layers[0];
            g.Dispose();
        }

        public void drawLine(int x1, int y1, int x2, int y2, Color color)
        {
            if (_form.layers.Count == 0)
                _form.layers.Add(new Bitmap(_form.pictureBox.Width, _form.pictureBox.Height));
            Graphics g;
            g = Graphics.FromImage(_form.layers[0]);
            Pen p = new Pen(color);
            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            g.DrawLine(p, p1, p2);
            _form.pictureBox.Image = _form.layers[0];
            g.Dispose();
        }

        public void drawRectangle(int x1, int y1, int x2, int y2, Color color)
        {
            if (_form.layers.Count == 0)
                _form.layers.Add(new Bitmap(_form.pictureBox.Width, _form.pictureBox.Height));
            Graphics g;
            g = Graphics.FromImage(_form.layers[0]);
            Pen p = new Pen(color);
            int width, height;
            if (x2 > x1)
                width = x2 - x1;
            else
                width = x1 - x2;
            if (y2 > y1)
                height = y2 - y1;
            else
                height = y1 - y2;
            g.DrawRectangle(p, x1, y1, width, height);
            _form.pictureBox.Image = _form.layers[0];
            g.Dispose();
        }

        public void drawCircle(int x1, int y1, int x2, int y2, Color color)
        {
            if (_form.layers.Count == 0)
                _form.layers.Add(new Bitmap(_form.pictureBox.Width, _form.pictureBox.Height));
            Graphics g;
            g = Graphics.FromImage(_form.layers[0]);
            Pen p = new Pen(color);
            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            g.DrawEllipse(p, x1, y1, x2, y2);
            _form.pictureBox.Image = _form.layers[0];
            g.Dispose();
        }

        public void drawBezierCircle(int x, int y, Color color)
        {
            for(int i=x-2; i <= x+2; i++)
            {
                for(int j=y-2; j <= y+2; j++)
                {
                    if (i >= 0 && j >= 0 && i < _form.pictureBox.Width && j < _form.pictureBox.Height)
                    {
                        if((i == x - 2 && (j >= y - 1 || j <= y + 1)) ||
                            (i == x + 2 && (j >= y - 1 || j <= y + 1)) ||
                            (j == y - 2 && (i >= x - 1 || i <= x + 1)) ||
                            (j == y + 2 && (i >= x - 1 || i <= x + 1)))
                                drawPoint(i, j, color);
                    }
                }
            }
        }

    }
}
