using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics_Editor
{
    public class AppState
    {
        private readonly Form1 _form;
        string selectedDrawingTool;
        Color selectedColor;
        double zoom;
        List<Point> bezierPoints;
        List<Point> polygonPoints;
        int currentLayer;
        string selectedPolygonMode;

        public AppState(Form1 form)
        {
            _form = form;
            selectedDrawingTool = "Pencil";
            selectedColor = Color.Black;
            zoom = 1;
            bezierPoints = new List<Point>();
            polygonPoints = new List<Point>();
            setCurrentLayer(0);
            selectedPolygonMode = "";
        }

        public void setDrawingTool(string drawingTool)
        {
            selectedDrawingTool = drawingTool;
        }

        public string getDrawingTool()
        {
            return selectedDrawingTool;
        }

        public void setColor(Color color)
        {
            selectedColor = color;
        }

        public Color getColor()
        {
            return selectedColor;
        }

        public void setZoom(double _zoom)
        {
            zoom = _zoom;
            _form.zoomLabel.Text = "Zoom: " + zoom.ToString() + "x";
        }

        public double getZoom()
        {
            return zoom;
        }

        public void resetPoints()
        {
            bezierPoints = null;
            bezierPoints = new List<Point>();
        }

        public void addBezierPoint(Point point)
        {
            this.bezierPoints.Add(point);
        }

        public int getPointsAmount()
        {
            return this.bezierPoints.Count;
        }

        public Point getBezierPoint(int index)
        {
            return this.bezierPoints.ElementAt(index);
        }

        public void resetPolygonPoints()
        {
            polygonPoints = null;
            polygonPoints = new List<Point>();
        }

        public void addPolygonPoint(Point point)
        {
            this.polygonPoints.Add(point);
        }

        public Point getPolygonPoint(int index)
        {
            return this.polygonPoints.ElementAt(index);
        }

        public List<Point> getPolygonPointsList()
        {
            return this.polygonPoints;
        }

        public void setCurrentLayer(int index)
        {
            this.currentLayer = index;
        }

        public int getCurrentLayer()
        {
            return this.currentLayer;
        }

        public int getLayersCount()
        {
            return _form.layers.Count;
        }

        public void setSelectedPolygonMode(string s)
        {
            this.selectedPolygonMode = s;
        }

        public string getSelectedPolygonMode()
        {
            return this.selectedPolygonMode;
        }

    }
}
