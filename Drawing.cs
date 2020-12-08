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
            g = Graphics.FromImage(_form.layers[0].bitmap);
            SolidBrush b = new SolidBrush(color);
            g.FillRectangle(b, x, y, 1, 1);
            _form.pictureBox.Image = _form.layers[0].bitmap.Clone(new Rectangle(0, 0, _form.layers[0].bitmap.Width, _form.layers[0].bitmap.Height), System.Drawing.Imaging.PixelFormat.DontCare);
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
            _form.pictureBox.Image = _form.layers[0].bitmap;
            g.Dispose();
        }

        public void drawLine(int x1, int y1, int x2, int y2, Color color, int layerIndex)
        {
            if (_form.layers.Count == 0)
            {
                Layer newLayer = new Layer(_form.pictureBox.Width, _form.pictureBox.Height);
                newLayer.bitmap = new Bitmap(_form.pictureBox.Width, _form.pictureBox.Height);
                _form.layers.Add(newLayer);
            }
                //_form.layers.Add(new Bitmap(_form.pictureBox.Width, _form.pictureBox.Height));
            Graphics g;
            g = Graphics.FromImage(_form.layers[layerIndex].bitmap);
            Pen p = new Pen(color);
            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            g.DrawLine(p, p1, p2);
            //_form.pictureBox.Image = _form.layers[layerIndex];
            _form.setImage(_form.layers[layerIndex].bitmap, layerIndex);
            g.Dispose();
        }

        public void drawRectangle(int x1, int y1, int x2, int y2, Color color)
        {
            if (_form.layers.Count == 0)
            {
                Layer newLayer = new Layer(_form.pictureBox.Width, _form.pictureBox.Height);
                newLayer.bitmap = new Bitmap(_form.pictureBox.Width, _form.pictureBox.Height);
                _form.layers.Add(newLayer);
            }
            //_form.layers.Add(new Bitmap(_form.pictureBox.Width, _form.pictureBox.Height));
            Graphics g;
            g = Graphics.FromImage(_form.layers[0].bitmap);
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
            _form.pictureBox.Image = _form.layers[0].bitmap;
            g.Dispose();
        }

        public void drawCircle(int x1, int y1, int x2, int y2, Color color)
        {
            if (_form.layers.Count == 0)
            {
                Layer newLayer = new Layer(_form.pictureBox.Width, _form.pictureBox.Height);
                newLayer.bitmap = new Bitmap(_form.pictureBox.Width, _form.pictureBox.Height);
                _form.layers.Add(newLayer);
            }
            //_form.layers.Add(new Bitmap(_form.pictureBox.Width, _form.pictureBox.Height));
            Graphics g;
            g = Graphics.FromImage(_form.layers[0].bitmap);
            Pen p = new Pen(color);
            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            g.DrawEllipse(p, x1, y1, x2, y2);
            _form.pictureBox.Image = _form.layers[0].bitmap;
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

        public void drawPolygon(int layer, List<Point> list, Color color)
        {
            if(list.Count>=2)
            {
                Bitmap bitmap = new Bitmap(_form.pictureBox.Width, _form.pictureBox.Height);
                if (_form.layers.Count<= layer)
                {
                    Layer newLayer = new Layer(_form.pictureBox.Width, _form.pictureBox.Height);
                    newLayer.bitmap = bitmap;
                    _form.layers.Add(newLayer);
                    //_form.layers.Add(bitmap);
                }
                else
                {
                    //_form.layers[layer] = bitmap;
                    _form.layers[layer].bitmap = bitmap;
                }
                for(int i=1; i<list.Count; i++)
                {
                    drawLine(list[i - 1].X, list[i - 1].Y, list[i].X, list[i].Y, color, layer);
                }
                drawLine(list[list.Count-1].X, list[list.Count-1].Y, list[0].X, list[0].Y, color, layer);
            }
        }

    }
}
