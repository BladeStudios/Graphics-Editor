using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

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
            _form.console.Text = "";
            StreamReader sr = System.IO.File.OpenText(filePath);
            string s = String.Empty;
            string ppmType = String.Empty;
            int width = 0, height = 0, maxColorValue = 0;
            List<Color> list = new List<Color>();
            Bitmap bitmap = new Bitmap(1,1);
            int readingPhase = -1; //-1 - default, 0-ppm type, 1-width, 2-height, 3-max color value, 4-colors
            bool isBitmapCreated = false;
            int length;
            int newR = 0, newG = 0, newB = 0;
            int x = 0, y = 0;
            bool error = false;
            bool consoleInfoShowed = false;
            bool canGoNextPhase = true;
            int line = 0;
            bool shouldColorBeReseted = true;
            byte[] tab;

            while ((s = sr.ReadLine())!=null && !error)
            {
                line++;
                length = s.Length;
                for (int i=0;i<length;i++)
                {
                    if (s[i] == '#')
                    {
                        i = length - 1;
                    }
                    else if (s[i] == ' ' || s[i] == '\t')
                    {
                        //wasPreviousSymbolALineFeed = false;
                        if (canGoNextPhase && readingPhase!=-1)
                        {
                            readingPhase++;
                            canGoNextPhase = false;
                        }
                        if (readingPhase >= 7)
                        {
                            if(line<40)
                                _form.console.Text = _form.console.Text.ToString() + '[' + x.ToString() + "][" + y.ToString() + "] = (" + newR.ToString() + ',' + newG.ToString()
                                + ',' + newB.ToString() + ")\n";
                            if (newR >= 0 && newR < 256 && newG >= 0 && newG < 256 && newB >= 0 && newB < 256)
                            {
                                bitmap.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
                                x++;
                                if (x >= width)
                                {
                                    x = 0;
                                    y++;
                                }
                                if (y >= height)
                                {
                                    error = true;
                                    _form.console.Text = _form.console.Text.ToString() + "ERROR IN LINE " + line.ToString() + " height=" + height.ToString() + "\n";
                                }
                            }
                            else
                            {
                                _form.console.Text = _form.console.Text.ToString() + "ERROR IN LINE " + line.ToString() + ": newR=" + newR.ToString() + " newG=" + newG.ToString()
                                    + " newB=" + newB.ToString() + "\n";
                                error = true;
                            }
                            readingPhase = 4;
                        }
                    }
                    else
                    {
                        canGoNextPhase = true;
                        if (readingPhase == -1)
                        {
                            readingPhase++;
                        }
                        if (readingPhase == 0) //ppm type
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
                        else if (readingPhase == 4) //read R
                        {
                            if (isBitmapCreated == false)
                            {
                                bitmap = new Bitmap(width, height);
                                tab = new byte[width * height * 8];
                                isBitmapCreated = true;
                            }
                            if (shouldColorBeReseted == true)
                            {
                                newR = 0;
                                newG = 0;
                                newB = 0;
                                shouldColorBeReseted = false;
                            }
                            newR = newR * 10 + int.Parse(s[i].ToString());
                        }
                        else if (readingPhase == 5) //read G
                        {
                            newG = newG * 10 + int.Parse(s[i].ToString());
                        }
                        else if (readingPhase == 6) //read B
                        {
                            if (!shouldColorBeReseted)
                                shouldColorBeReseted = true;
                            newB = newB * 10 + int.Parse(s[i].ToString());
                        }
                    }
                    
                    if (i == length-1 && canGoNextPhase)
                    {
                        readingPhase++;
                        if (readingPhase >= 7)
                        {
                            if (line < 40)
                                _form.console.Text = _form.console.Text.ToString() + '[' + x.ToString() + "][" + y.ToString() + "] = (" + newR.ToString() + ',' + newG.ToString()
                                + ',' + newB.ToString() + ")\n";
                            if (newR >= 0 && newR < 256 && newG >= 0 && newG < 256 && newB >= 0 && newB < 256)
                            {
                                bitmap.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
                                _form.pictureBox.Image = bitmap;
                                x++;
                                if (x >= width)
                                {
                                    x = 0;
                                    y++;
                                }
                                if (y >= height)
                                {
                                    error = true;
                                }
                            }
                            else
                            {
                                _form.console.Text = _form.console.Text.ToString() + "ERROR IN LINE " + line.ToString() + ": newR=" + newR.ToString() + " newG=" + newG.ToString()
                                    + " newB=" + newB.ToString() + "\n";
                                error = true;
                            }
                            readingPhase = 4;
                        }

                        if (readingPhase == 4 && !consoleInfoShowed)
                        {
                            _form.console.Text = _form.console.Text.ToString() + "PPM type: " + ppmType + "\n";
                            _form.console.Text = _form.console.Text.ToString() + "width: " + width.ToString() + "\n";
                            _form.console.Text = _form.console.Text.ToString() + "height: " + height.ToString() + "\n";
                            _form.console.Text = _form.console.Text.ToString() + "max color value: " + maxColorValue.ToString() + "\n";
                            consoleInfoShowed = true;
                        }

                        canGoNextPhase = false;
                    }
                }
            }

            _form.pictureBox.Image = bitmap;
            _form.console.Text = _form.console.Text.ToString() + "DONE, Succesfully readed " + line.ToString() + " lines.\n";
            /*
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    _form.console.Text = _form.console.Text.ToString() + "[" + i.ToString() + "][" + j.ToString() + "]=(" +
                        bitmap.GetPixel(i, j).R.ToString() + "," + bitmap.GetPixel(i, j).G.ToString() + "," + bitmap.GetPixel(i, j).B.ToString() + ")\n";
                }
            }*/

        }

        private void setPixels(Bitmap processedBitmap, byte [] tab)
        {
            BitmapData bitmapData = processedBitmap.LockBits(new Rectangle(0, 0, processedBitmap.Width, processedBitmap.Height), ImageLockMode.ReadWrite, processedBitmap.PixelFormat);
            int bytesPerPixel = Bitmap.GetPixelFormatSize(processedBitmap.PixelFormat) / 8;
            int byteCount = bitmapData.Stride * processedBitmap.Height;
            //byte[] pixels = new byte[byteCount];
        }
    }
}
