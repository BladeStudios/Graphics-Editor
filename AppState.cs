using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics_Editor
{
    class AppState
    {
        private readonly Form1 _form;
        string selectedDrawingTool;

        public AppState(Form1 form)
        {
            _form = form;
            selectedDrawingTool = "Pencil";
        }

        public void setDrawingTool(string drawingTool)
        {
            selectedDrawingTool = drawingTool;
        }

        public string getDrawingTool()
        {
            return selectedDrawingTool;
        }

    }
}
