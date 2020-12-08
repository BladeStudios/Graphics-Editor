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
    public partial class DrawLine : Form
    {
        private readonly Form1 _form;
        public Bitmap Image;
        int rValue, gValue, bValue;
        string mode;
        public DrawLine(Form1 form, string drawMode)
        {
            InitializeComponent();
            _form = form;
            mode = drawMode;
            if (mode == "line")
                this.Text = "Draw Line";
            else if (mode == "rectangle")
                this.Text = "Draw Rectangle";
            else if (mode == "circle")
                this.Text = "Draw Circle";
            fromX.Maximum = _form.pictureBox.Width;
            fromY.Maximum = _form.pictureBox.Height;
            toX.Maximum = _form.pictureBox.Width;
            toY.Maximum = _form.pictureBox.Height;
            Image = new Bitmap(this.pictureBox.Width, this.pictureBox.Height);
            updateColor();
        }

        private void R_ValueChanged(object sender, EventArgs e)
        {
            updateColor();
        }

        private void G_ValueChanged(object sender, EventArgs e)
        {
            updateColor();
        }

        private void B_ValueChanged(object sender, EventArgs e)
        {
            updateColor();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Drawing drawing = new Drawing(_form);
            int fromXValue = Convert.ToInt32(fromX.Value);
            int fromYValue = Convert.ToInt32(fromY.Value);
            int toXValue = Convert.ToInt32(toX.Value);
            int toYValue = Convert.ToInt32(toY.Value);
            int temp;
            if (fromXValue > toXValue)
            {
                temp = fromXValue;
                fromXValue = toXValue;
                toXValue = temp;
            }
            if(fromYValue > toYValue)
            {
                temp = fromYValue;
                fromYValue = toYValue;
                toYValue = temp;
            }
            if(mode=="line")
                drawing.drawLine(fromXValue, fromYValue, toXValue, toYValue, Color.FromArgb(rValue,gValue,bValue),0);
            else if(mode=="rectangle")
                drawing.drawRectangle(fromXValue, fromYValue, toXValue, toYValue, Color.FromArgb(rValue, gValue, bValue));
            else if(mode=="circle")
                drawing.drawCircle(fromXValue, fromYValue, toXValue, toYValue, Color.FromArgb(rValue, gValue, bValue));
        }

        private void updateColor()
        {
            rValue = Convert.ToInt32(R.Value);
            gValue = Convert.ToInt32(G.Value);
            bValue = Convert.ToInt32(B.Value);
            Graphics g;
            g = Graphics.FromImage(Image);
            SolidBrush b = new SolidBrush(Color.FromArgb(rValue,gValue,bValue));
            g.FillRectangle(b, 0, 0, pictureBox.Width, pictureBox.Height);
            pictureBox.Image =Image;
            g.Dispose();
        }
    }
}
