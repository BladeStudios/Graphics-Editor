using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Windows.Forms;

namespace Graphics_Editor
{
    class File
    {
        private readonly Form1 _form;
        string filePath;
        public File(Form1 form)
        {
            _form = form;
            filePath = string.Empty;
        }

        public void New()
        {
            _form.pictureBox.Image = null;
        }

        public void NewWindow()
        {
            Form1 f = new Form1();
            f.Show();
        }

        public void Open()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 3;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();

                    _form.Image = new Bitmap(Image.FromFile(openFileDialog.FileName));
                    if (_form.pictureBox.Image != null) _form.pictureBox.Image.Dispose();
                    _form.pictureBox.Image = _form.Image.Clone(new Rectangle(0, 0, _form.Image.Width, _form.Image.Height), System.Drawing.Imaging.PixelFormat.DontCare);
                }
            }
        }
    }
}
