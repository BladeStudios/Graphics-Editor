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
    public partial class Histogram : Form
    {
        private readonly Form1 _form;
        private int [] redHistogram;
        private int[] greenHistogram;
        private int [] blueHistogram;
        private double[] redCdf;
        private double[] greenCdf;
        private double[] blueCdf;
        private int[] redLUT;
        private int[] greenLUT;
        private int[] blueLUT;
        private double redMin, greenMin, blueMin;
        private double redMax, greenMax, blueMax;
        bool checkingBlock;

        public Histogram(Form1 form)
        {
            InitializeComponent();
            _form = form;
            redHistogram = new int[256];
            greenHistogram = new int[256];
            blueHistogram = new int[256];
            redCdf = new double[256];
            greenCdf = new double[256];
            blueCdf = new double[256];
            redLUT = new int[256];
            greenLUT = new int[256];
            blueLUT = new int[256];
            checkingBlock = true;
            //clearHistogram();
            calculateHistogram(_form.getImage());
            setLabels();
        }

        private void Histogram_Load(object sender, EventArgs e)
        {
            if (Owner != null)
                Location = new Point(Owner.Location.X + Owner.Width / 2 - Width / 2,
                    Owner.Location.Y + Owner.Height / 2 - Height / 2);
        }

        private void calculateHistogram(Bitmap bitmap)
        {
            clearHistogram();
            for(int i=0;i<bitmap.Width;i++)
            {
                for(int j=0;j<bitmap.Height; j++)
                {
                    redHistogram[bitmap.GetPixel(i, j).R]++;
                    greenHistogram[bitmap.GetPixel(i, j).G]++;
                    blueHistogram[bitmap.GetPixel(i, j).B]++;
                }
            }
            setMin();
            setMax();
        }

        private void clearHistogram()
        {
            for(int i=0;i<256;i++)
            {
                redHistogram[i] = 0;
                greenHistogram[i] = 0;
                blueHistogram[i] = 0;
            }
        }

        private void setLabels()
        {
            redMinLabel.Text = "RedMin = " + redMin;
            redMaxLabel.Text = "RedMax = " + redMax;
            greenMinLabel.Text = "GreenMin = " + greenMin;
            greenMaxLabel.Text = "GreenMax = " + greenMax;
            blueMinLabel.Text = "BlueMin = " + blueMin;
            blueMaxLabel.Text = "BlueMax = " + blueMax;
        }

        private void setMin()
        {
            int i = 0;
            while (redHistogram[i] == 0)
                i++;
            redMin = i;

            i = 0;
            while (greenHistogram[i] == 0)
                i++;
            greenMin = i;

            i = 0;
            while (blueHistogram[i] == 0)
                i++;
            blueMin = i;
        }

        private void setMax()
        {
            int i = 255;
            while (redHistogram[i] == 0)
                i--;
            redMax = i;

            i = 255;
            while (greenHistogram[i] == 0)
                i--;
            greenMax = i;

            i = 255;
            while (blueHistogram[i] == 0)
                i--;
            blueMax = i;
        }

        private Bitmap stretchingHistogram(Bitmap bitmap)
        {
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
            calculateHistogram(bitmap);
            if (redMin != redMax && greenMin!=greenMax && blueMin!=blueMax)
            {
                int red, green, blue;
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        red = Convert.ToInt32((bitmap.GetPixel(i, j).R - redMin) / (redMax - redMin) * 255);
                        green = Convert.ToInt32((bitmap.GetPixel(i, j).G - greenMin) / (greenMax - greenMin) * 255);
                        blue = Convert.ToInt32((bitmap.GetPixel(i, j).B - blueMin) / (blueMax - blueMin) * 255);
                        result.SetPixel(i, j, Color.FromArgb(red, green, blue));
                    }
                }
            }
            calculateHistogram(result);
            setLabels();
            _form.memoryAdd(result);
            return result;
        }

        private Bitmap histogramEqualization(Bitmap bitmap)
        {
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
            setCdf(bitmap);
            setLUT();

            for(int i=0;i<bitmap.Width; i++)
            {
                for(int j=0; j<bitmap.Height; j++)
                {
                    result.SetPixel(i, j, Color.FromArgb(redLUT[bitmap.GetPixel(i, j).R], greenLUT[bitmap.GetPixel(i,j).G], blueLUT[bitmap.GetPixel(i,j).B]));
                }
            }

            _form.memoryAdd(result);
            return result;
        }

        private void setCdf(Bitmap bitmap)
        {
            calculateHistogram(bitmap);
            int sumRed = 0;
            int sumGreen = 0;
            int sumBlue = 0;
            int size = bitmap.Width * bitmap.Height;
            for(int i=0; i<256; i++)
            {
                sumRed += redHistogram[i];
                redCdf[i] = (Convert.ToDouble(sumRed) / size);

                sumGreen += greenHistogram[i];
                greenCdf[i] = (Convert.ToDouble(sumGreen) / size);

                sumBlue += blueHistogram[i];
                blueCdf[i] = (Convert.ToDouble(sumBlue) / size);
            }
        }

        private void setLUT()
        {
            double minRed, minGreen, minBlue;

            int i = 0;
            while(redCdf[i]==0)
            {
                i++;
            }
            minRed = redCdf[i];

            i = 0;
            while (greenCdf[i] == 0)
            {
                i++;
            }
            minGreen = greenCdf[i];

            i = 0;
            while (blueCdf[i] == 0)
            {
                i++;
            }
            minBlue = blueCdf[i];

            for(i=0; i<256; i++)
            {
                redLUT[i] = Convert.ToInt32((redCdf[i] - minRed) / (1 - minRed) * 255);
                greenLUT[i] = Convert.ToInt32((greenCdf[i] - minGreen) / (1 - minGreen) * 255);
                blueLUT[i] = Convert.ToInt32((blueCdf[i] - minBlue) / (1 - minBlue) * 255);
            }
        }

        private Bitmap customBinarization(Bitmap bitmap, int threshold, bool isBottomThreshold)
        {
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    if (isBottomThreshold)
                    {
                        if (bitmap.GetPixel(i, j).R <= threshold)
                            result.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                        else
                            result.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                    else //top threshold
                    {
                        if (bitmap.GetPixel(i, j).R >= threshold)
                            result.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                        else
                            result.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                }
            }

            _form.memoryAdd(result);
            return result;
        }

        private void histogramStretchingButton_Click(object sender, EventArgs e)
        {
            _form.startLoading();
            _form.setImage(stretchingHistogram(_form.getImage()));
            _form.stopLoading();
        }

        private void histogramEqualizationButton_Click(object sender, EventArgs e)
        {
            _form.startLoading();
            _form.setImage(histogramEqualization(_form.getImage()));
            _form.stopLoading();
        }

        private void customBinarizationButton_Click(object sender, EventArgs e)
        {
            bool isBottomThreshold;
            if (bottomThresholdBox.Checked == true)
                isBottomThreshold = true;
            else
                isBottomThreshold = false;
            _form.startLoading();
            _form.setImage(customBinarization(_form.getImage(),thresholdBar.Value,isBottomThreshold));
            _form.stopLoading();
        }

        private void bottomThresholdBox_CheckedChanged(object sender, EventArgs e)
        {
            if(checkingBlock)
            {
                checkingBlock = false;

                bottomThresholdBox.Checked = true;
                bottomThresholdBox.CheckState = CheckState.Checked;

                topThresholdBox.Checked = false;
                topThresholdBox.CheckState = CheckState.Unchecked;

                checkingBlock = true;
            }
        }

        private void topThresholdBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkingBlock)
            {
                checkingBlock = false;

                topThresholdBox.Checked = true;
                topThresholdBox.CheckState = CheckState.Checked;

                bottomThresholdBox.Checked = false;
                bottomThresholdBox.CheckState = CheckState.Unchecked;

                checkingBlock = true;
            }
        }

        private void thresholdBar_Scroll(object sender, EventArgs e)
        {
            thresholdValue.Value = thresholdBar.Value;
        }

        private void thresholdValue_ValueChanged(object sender, EventArgs e)
        {
            thresholdBar.Value = Convert.ToInt32(thresholdValue.Value);
        }
    }
}
