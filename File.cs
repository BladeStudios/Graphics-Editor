using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Windows.Forms;
using System.IO;

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
                if (filePath == string.Empty)
                    openFileDialog.InitialDirectory = "c:\\";
                else
                    openFileDialog.InitialDirectory = filePath;
                openFileDialog.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|PPM files (*.ppm)|*.ppm|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 4;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();
                    _form.Text = Path.GetFileName(filePath) + " - Graphics Editor";
                    _form.appState.setZoom(1);

                    string extension = Path.GetExtension(filePath);
                    if(extension!=".ppm")
                    {
                        _form.Image = new Bitmap(Image.FromFile(openFileDialog.FileName));
                        if (_form.pictureBox.Image != null) _form.pictureBox.Image.Dispose();
                        _form.pictureBox.Image = _form.Image.Clone(new Rectangle(0, 0, _form.Image.Width, _form.Image.Height), System.Drawing.Imaging.PixelFormat.DontCare);
                    }
                    else
                    {
                        OpenPPM();
                    }
                }
            }
        }

        private void OpenPPM()
        {
            StreamReader sr = System.IO.File.OpenText(filePath);
            string s = String.Empty;
            string ppmType = String.Empty;
            int width = 0, height = 0, maxColorValue = 0;
            List<Color> list = new List<Color>();
            Color currentColor;
            Bitmap bitmap;
            int readingPhase = 0; //0-ppm type, 1-width, 2-height, 3-max color value, 4-colors
            int colorPhase = 0; //0-red, 1- green, 2- blue
            bool isBitmapCreated = false;
            int length;

            while((s = sr.ReadLine())!=null)
            {
                length = s.Length;
                for(int i=0;i<length;i++)
                {
                    //_form.console.Text = _form.console.Text.ToString() + "s[i]=" + s[i].ToString() + "\n";
                    if (s[i] == '#')
                        i = length;
                    else if (s[i] == ' ' || s[i] == '\n' || s[i] == '\t' || s[i] == '\r')
                    {
                        if (readingPhase != -1 && readingPhase != 4)
                            readingPhase++;
                    }
                    else
                    {
                        if (readingPhase == -1)
                            readingPhase++;
                        if (readingPhase==4)
                        {

                        }
                        else if (readingPhase == 0) //ppm type
                        {
                            ppmType = ppmType + s[i].ToString();
                        }
                        else if (readingPhase == 1) //width
                        {
                            width = width * 10 + int.Parse(s[i].ToString());
                        }
                        else if (readingPhase == 2) //height
                        {
                            height = height * 10 + int.Parse(s[i].ToString());
                        }
                        else if (readingPhase == 3) //maxColorValue
                        {
                            maxColorValue = maxColorValue * 10 + int.Parse(s[i].ToString());
                        }
                    }

                    if (i == length-1 && readingPhase < 4)
                        readingPhase++;
                }
            }

            _form.console.Text = _form.console.Text.ToString() + "PPM type: " + ppmType + "\n";
            _form.console.Text = _form.console.Text.ToString() + "width: " + width.ToString() + "\n";
            _form.console.Text = _form.console.Text.ToString() + "height: " + height.ToString() + "\n";
            _form.console.Text = _form.console.Text.ToString() + "max color value: " + maxColorValue.ToString() + "\n";
        }
    }
}
