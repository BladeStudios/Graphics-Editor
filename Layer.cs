using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics_Editor
{
    public class Layer
    {
        public Bitmap bitmap;
        List<Point> polygonPoints = new List<Point>();
        bool isSelected = false;

        public Layer(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            /*Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            SolidBrush b = new SolidBrush(Color.White);
            g.DrawImage(bitmap, 0, 0, width, height);
            g.Dispose();*/
        }

        public void addPolygonPoint(Point point)
        {
            this.polygonPoints.Add(point);
        }

        public List<Point> getPointsList()
        {
            return this.polygonPoints;
        }

        public void setSelected(bool s)
        {
            isSelected = s;
        }

        public bool getSelected()
        {
            return isSelected;
        }

        public Point getPoint(int index)
        {
            return polygonPoints.ElementAt(index);
        }

        public void setPoint(int index, int x, int y)
        {
            this.polygonPoints[index] = new Point(x, y);
        }
    }
}
