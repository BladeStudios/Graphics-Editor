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

        public AppState(Form1 form)
        {
            _form = form;
            selectedDrawingTool = "Pencil";
            selectedColor = Color.Black;
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

    }
}
