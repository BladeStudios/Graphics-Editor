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

        public void drawPoint(int x, int y)
        {
            /*
            _form.Image.SetPixel(x, y, Color.Black);
            _form.pictureBox.Image = _form.Image;*/
            Graphics g;
            g = Graphics.FromImage(_form.Image);

            SolidBrush b = new SolidBrush(Color.Black);
            
            g.FillRectangle(b, x, y, 1, 1);

            _form.pictureBox.Image = _form.Image;

            g.Dispose();
        }
    }
}
