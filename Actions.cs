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
    public partial class Actions : Form
    {
        private readonly Form1 _form;
        Drawing drawing;

        public Actions(Form1 form)
        {
            InitializeComponent();
            _form = form;
            drawing = new Drawing(_form);
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            _form.appState.setDrawingTool("Polygon");
            _form.appState.setSelectedPolygonMode("Draw");
            _form.addLayer();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            _form.appState.setDrawingTool("Polygon");
            _form.appState.setSelectedPolygonMode("Select");
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            _form.appState.setDrawingTool("Polygon");
            _form.appState.setSelectedPolygonMode("Move");

            for (int i = 0; i < _form.layers.Count; i++)
            {
                if (_form.layers[i].getSelected())
                {
                    //move(i, 100, 100);
                    _form.move(i, Convert.ToInt32(vectorX.Value), Convert.ToInt32(vectorY.Value));
                    drawing.drawPolygon(i, _form.layers[i].getPointsList(), Color.Red);
                    break;
                }
            }
        }
    }
}
