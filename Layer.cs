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

        public void addPolygonPoint(Point point)
        {
            this.polygonPoints.Add(point);
        }

        public List<Point> getPointsList()
        {
            return this.polygonPoints;
        }
    }
}
