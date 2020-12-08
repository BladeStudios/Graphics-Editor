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
    public partial class Form1 : Form
    {
        File file;
        public AppState appState;
        Drawing drawing;
        public Bitmap Image;
        public List<Bitmap> memory;
        public int currentMemoryIndex;
        public Loading loading;
        //public List<Bitmap> layers;
        public List<Layer> layers;

        public Form1()
        {
            InitializeComponent();
            //layers = new List<Bitmap>();
            layers = new List<Layer>();
            file = new File(this);
            appState = new AppState(this);
            drawing = new Drawing(this);
            //Image = new Bitmap(this.pictureBox.Width, this.pictureBox.Height);
            memory = new List<Bitmap>();
            currentMemoryIndex = -1;

            //setting button images
            int width = 20;
            int height = 20;

            this.menuColor.Image = createBitmap(width, height, 0, 0, 0);
            this.menuColorBlack.Image = createBitmap(width, height, 0, 0, 0);
            this.menuColorWhite.Image = createBitmap(width, height, 255, 255, 255);
            this.menuColorRed.Image = createBitmap(width, height,255,0,0);
            this.menuColorGreen.Image = createBitmap(width, height, 0, 255, 0);
            this.menuColorBlue.Image = createBitmap(width, height, 0, 0, 255);
            this.menuColorYellow.Image = createBitmap(width, height, 255, 255, 0);
            this.menuColorCyan.Image = createBitmap(width, height, 0, 255, 255);
            this.menuColorMagenta.Image = createBitmap(width, height, 255, 0, 255);
            this.menuColorOrange.Image = createBitmap(width, height, 255, 165, 0);
            this.menuColorViolet.Image = createBitmap(width, height, 238, 82, 238);
            this.menuColorGrey.Image = createBitmap(width, height, 80, 80, 80);
        }

        public void memoryAdd(Bitmap bitmap)
        {
            int count = memory.Count;
            if(count > (currentMemoryIndex+1))
            {
                for (int i = (count - 1); i > currentMemoryIndex; i--)
                    memory.RemoveAt(i);
            }

            Bitmap newBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            newBitmap = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), System.Drawing.Imaging.PixelFormat.DontCare);

            if (count >= 10)
                memory.RemoveAt(0);
            memory.Add(newBitmap);
            setMemoryIndex(memory.Count-1);
            consoleSay("Added to memory. Memory count: " + memory.Count);
        }

        public Bitmap memoryGet(int index)
        {
            return memory.ElementAt(index);
        }

        public void setMemoryIndex(int index)
        {
            this.currentMemoryIndex = index;
        }

        public int getMemoryIndex()
        {
            return this.currentMemoryIndex;
        }

        public int getMemoryCount()
        {
            return this.memory.Count;
        }

        public void addLayer()
        {
            Layer newLayer = new Layer(pictureBox.Width, pictureBox.Height);
            layers.Add(newLayer);
            appState.setCurrentLayer(layers.Count - 1);
        }

        public Bitmap getImage()
        {
            return layers.ElementAt(0).bitmap;
        }

        public void setImage(Bitmap bitmap, int layerIndex)
        {
            if (layerIndex > layers.Count-1)
            {
                Layer newLayer = new Layer(pictureBox.Width, pictureBox.Height);
                newLayer.bitmap = bitmap;
                //layers.Add(bitmap);
                layers.Add(newLayer);
            }
            else
            {
                //layers[layerIndex] = new Bitmap(bitmap.Width, bitmap.Height);
                //layers[layerIndex] = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), System.Drawing.Imaging.PixelFormat.DontCare);
                layers[layerIndex].bitmap = new Bitmap(bitmap.Width, bitmap.Height);
                layers[layerIndex].bitmap = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), System.Drawing.Imaging.PixelFormat.DontCare);
            }

            Bitmap finalImage = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(finalImage);
            //g.FillRectangle(Brushes.White, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height)); //new

            foreach(Layer layer in layers)
            {
                //g.DrawImage(layer, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));
                g.DrawImage(layer.bitmap, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));
            }
            g.Dispose();
            pictureBox.Image = finalImage.Clone(new Rectangle(0, 0, finalImage.Width, finalImage.Height), System.Drawing.Imaging.PixelFormat.DontCare);
        }

        private void menuFileNew_Click(object sender, EventArgs e)
        {
            file.New();
        }

        private void menuFileNewWindow_Click(object sender, EventArgs e)
        {
            file.NewWindow();
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            if(Image==null)
                Image = new Bitmap(this.pictureBox.Width, this.pictureBox.Height);
            file.Open();
        }

        Bitmap createBitmap(int width, int height, int red, int green, int blue)
        {
            Bitmap bitmap = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(bitmap);
            SolidBrush solidbrush = new SolidBrush(Color.FromArgb(red, green, blue));
            graphics.FillRectangle(solidbrush, 0, 0, width, height);
            return bitmap;
        }

        private void menuDrawingToolPencil_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuDrawingTool, menuDrawingToolPencil);
        }

        private void menuDrawingToolBrush_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuDrawingTool, menuDrawingToolBrush);
        }

        private void selectMenuItem(ToolStripDropDownButton menu, ToolStripMenuItem item)
        {
            if(menu == menuDrawingTool) //menu Drawing Tool
            {
                //unchecking all items
                this.menuDrawingToolPencil.Checked = false;
                this.menuDrawingToolPencil.CheckState = CheckState.Unchecked;
                this.menuDrawingToolBrush.Checked = false;
                this.menuDrawingToolBrush.CheckState = CheckState.Unchecked;
                this.menuDrawingToolLine.Checked = false;
                this.menuDrawingToolLine.CheckState = CheckState.Unchecked;
                this.menuDrawingToolRectangle.Checked = false;
                this.menuDrawingToolRectangle.CheckState = CheckState.Unchecked;
                this.menuDrawingToolCircle.Checked = false;
                this.menuDrawingToolCircle.CheckState = CheckState.Unchecked;
                this.menuDrawingToolBezier.Checked = false;
                this.menuDrawingToolBezier.CheckState = CheckState.Unchecked;
                this.menuDrawingToolPolygon.Checked = false;
                this.menuDrawingToolPolygon.CheckState = CheckState.Unchecked;
                this.polygonSelect.Checked = false;
                this.polygonSelect.CheckState = CheckState.Unchecked;
                this.polygonDraw.Checked = false;
                this.polygonDraw.CheckState = CheckState.Unchecked;
                this.polygonMove.Checked = false;
                this.polygonMove.CheckState = CheckState.Unchecked;
                this.polygonRotate.Checked = false;
                this.polygonRotate.CheckState = CheckState.Unchecked;

                if (item == menuDrawingToolPencil)
                {
                    this.menuDrawingToolPencil.Checked = true;
                    this.menuDrawingToolPencil.CheckState = CheckState.Checked;
                    this.menuDrawingTool.Image = this.menuDrawingToolPencil.Image;
                    appState.setDrawingTool("Pencil");
                }
                else if (item == menuDrawingToolBrush)
                {
                    this.menuDrawingToolBrush.Checked = true;
                    this.menuDrawingToolBrush.CheckState = CheckState.Checked;
                    this.menuDrawingTool.Image = this.menuDrawingToolBrush.Image;
                    appState.setDrawingTool("Brush");
                }
                else if (item == menuDrawingToolLine)
                {
                    this.menuDrawingToolLine.Checked = true;
                    this.menuDrawingToolLine.CheckState = CheckState.Checked;
                    this.menuDrawingTool.Image = this.menuDrawingToolLine.Image;
                    appState.setDrawingTool("Line");
                }
                else if (item == menuDrawingToolRectangle)
                {
                    this.menuDrawingToolRectangle.Checked = true;
                    this.menuDrawingToolRectangle.CheckState = CheckState.Checked;
                    this.menuDrawingTool.Image = this.menuDrawingToolRectangle.Image;
                    appState.setDrawingTool("Rectangle");
                }
                else if (item == menuDrawingToolCircle)
                {
                    this.menuDrawingToolCircle.Checked = true;
                    this.menuDrawingToolCircle.CheckState = CheckState.Checked;
                    this.menuDrawingTool.Image = this.menuDrawingToolCircle.Image;
                    appState.setDrawingTool("Circle");
                }
                else if (item == menuDrawingToolBezier)
                {
                    this.menuDrawingToolBezier.Checked = true;
                    this.menuDrawingToolBezier.CheckState = CheckState.Checked;
                    this.menuDrawingTool.Image = this.menuDrawingToolBezier.Image;
                    appState.setDrawingTool("Bezier");
                }
                else if (item == polygonSelect)
                {
                    this.menuDrawingToolPolygon.Checked = true;
                    this.menuDrawingToolPolygon.CheckState = CheckState.Checked;
                    this.polygonSelect.Checked = true;
                    this.polygonSelect.CheckState = CheckState.Checked;
                    this.menuDrawingTool.Image = this.menuDrawingToolPolygon.Image;
                    appState.setDrawingTool("Polygon");
                    appState.setSelectedPolygonMode("Select");
                }
                else if (item == polygonDraw)
                {
                    this.menuDrawingToolPolygon.Checked = true;
                    this.menuDrawingToolPolygon.CheckState = CheckState.Checked;
                    this.polygonDraw.Checked = true;
                    this.polygonDraw.CheckState = CheckState.Checked;
                    this.menuDrawingTool.Image = this.menuDrawingToolPolygon.Image;
                    appState.setDrawingTool("Polygon");
                    appState.setSelectedPolygonMode("Draw");
                }
                else if (item == polygonMove)
                {
                    this.menuDrawingToolPolygon.Checked = true;
                    this.menuDrawingToolPolygon.CheckState = CheckState.Checked;
                    this.polygonMove.Checked = true;
                    this.polygonMove.CheckState = CheckState.Checked;
                    this.menuDrawingTool.Image = this.menuDrawingToolPolygon.Image;
                    appState.setDrawingTool("Polygon");
                    appState.setSelectedPolygonMode("Move");
                }
                else if (item == polygonRotate)
                {
                    this.menuDrawingToolPolygon.Checked = true;
                    this.menuDrawingToolPolygon.CheckState = CheckState.Checked;
                    this.polygonRotate.Checked = true;
                    this.polygonRotate.CheckState = CheckState.Checked;
                    this.menuDrawingTool.Image = this.menuDrawingToolPolygon.Image;
                    appState.setDrawingTool("Polygon");
                    appState.setSelectedPolygonMode("Rotate");
                }
            }
            else if(menu == this.menuColor) //menu Color
            {
                //unchecking all items
                this.menuColorBlack.Checked = false;
                this.menuColorBlack.CheckState = CheckState.Unchecked;
                this.menuColorWhite.Checked = false;
                this.menuColorWhite.CheckState = CheckState.Unchecked;
                this.menuColorRed.Checked = false;
                this.menuColorRed.CheckState = CheckState.Unchecked;
                this.menuColorGreen.Checked = false;
                this.menuColorGreen.CheckState = CheckState.Unchecked;
                this.menuColorBlue.Checked = false;
                this.menuColorBlue.CheckState = CheckState.Unchecked;
                this.menuColorYellow.Checked = false;
                this.menuColorYellow.CheckState = CheckState.Unchecked;
                this.menuColorCyan.Checked = false;
                this.menuColorCyan.CheckState = CheckState.Unchecked;
                this.menuColorMagenta.Checked = false;
                this.menuColorMagenta.CheckState = CheckState.Unchecked;
                this.menuColorOrange.Checked = false;
                this.menuColorOrange.CheckState = CheckState.Unchecked;
                this.menuColorViolet.Checked = false;
                this.menuColorViolet.CheckState = CheckState.Unchecked;
                this.menuColorGrey.Checked = false;
                this.menuColorGrey.CheckState = CheckState.Unchecked;
                this.menuColorOther.Checked = false;
                this.menuColorOther.CheckState = CheckState.Unchecked;
                this.menuColorOther.Image = null;

                if (item == menuColorBlack)
                {
                    this.menuColorBlack.Checked = true;
                    this.menuColorBlack.CheckState = CheckState.Checked;
                    this.menuColor.Image = this.menuColorBlack.Image;
                    appState.setColor(Color.Black);
                }
                else if (item == menuColorWhite)
                {
                    this.menuColorWhite.Checked = true;
                    this.menuColorWhite.CheckState = CheckState.Checked;
                    this.menuColor.Image = this.menuColorWhite.Image;
                    appState.setColor(Color.White);
                }
                else if (item == menuColorRed)
                {
                    this.menuColorRed.Checked = true;
                    this.menuColorRed.CheckState = CheckState.Checked;
                    this.menuColor.Image = this.menuColorRed.Image;
                    appState.setColor(Color.Red);
                }
                else if (item == menuColorGreen)
                {
                    this.menuColorGreen.Checked = true;
                    this.menuColorGreen.CheckState = CheckState.Checked;
                    this.menuColor.Image = this.menuColorGreen.Image;
                    appState.setColor(Color.Green);
                }
                else if (item == menuColorBlue)
                {
                    this.menuColorBlue.Checked = true;
                    this.menuColorBlue.CheckState = CheckState.Checked;
                    this.menuColor.Image = this.menuColorBlue.Image;
                    appState.setColor(Color.Blue);
                }
                else if (item == menuColorYellow)
                {
                    this.menuColorYellow.Checked = true;
                    this.menuColorYellow.CheckState = CheckState.Checked;
                    this.menuColor.Image = this.menuColorYellow.Image;
                    appState.setColor(Color.Yellow);
                }
                else if (item == menuColorCyan)
                {
                    this.menuColorCyan.Checked = true;
                    this.menuColorCyan.CheckState = CheckState.Checked;
                    this.menuColor.Image = this.menuColorCyan.Image;
                    appState.setColor(Color.Cyan);
                }
                else if (item == menuColorMagenta)
                {
                    this.menuColorMagenta.Checked = true;
                    this.menuColorMagenta.CheckState = CheckState.Checked;
                    this.menuColor.Image = this.menuColorMagenta.Image;
                    appState.setColor(Color.Magenta);
                }
                else if (item == menuColorOrange)
                {
                    this.menuColorOrange.Checked = true;
                    this.menuColorOrange.CheckState = CheckState.Checked;
                    this.menuColor.Image = this.menuColorOrange.Image;
                    appState.setColor(Color.FromArgb(255, 165, 0));
                }
                else if (item == menuColorViolet)
                {
                    this.menuColorViolet.Checked = true;
                    this.menuColorViolet.CheckState = CheckState.Checked;
                    this.menuColor.Image = this.menuColorViolet.Image;
                    appState.setColor(Color.FromArgb(238, 82, 238));
                }
                else if (item == menuColorGrey)
                {
                    this.menuColorGrey.Checked = true;
                    this.menuColorGrey.CheckState = CheckState.Checked;
                    this.menuColor.Image = this.menuColorGrey.Image;
                    appState.setColor(Color.FromArgb(80, 80, 80));
                }
                else if (item == menuColorOther)
                {
                    this.menuColorOther.Checked = true;
                    this.menuColorOther.CheckState = CheckState.Checked;
                    this.menuColor.Image = this.menuColorOther.Image;
                }
            }

        }

        private void menuDrawingToolLine_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuDrawingTool, menuDrawingToolLine);
        }

        private void menuDrawingToolRectangle_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuDrawingTool, menuDrawingToolRectangle);
        }

        private void menuDrawingToolCircle_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuDrawingTool, menuDrawingToolCircle);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            int x = pictureBox.PointToClient(Cursor.Position).X;
            int y = pictureBox.PointToClient(Cursor.Position).Y;
            if(appState.getDrawingTool()=="Pencil")
                drawing.drawPoint(x,y,appState.getColor());
            else if (appState.getDrawingTool()=="Bezier")
            {
                drawing.drawBezierCircle(x, y, appState.getColor());
                appState.addBezierPoint(new Point(x, y));
                if(appState.getPointsAmount()>1)
                {
                    Point p = appState.getBezierPoint(appState.getPointsAmount() - 2);
                    drawing.drawLine(p.X, p.Y, x, y, appState.getColor(),0);
                }
                Bitmap bitmap = new Bitmap(layers[0].bitmap);
                memoryAdd(bitmap);
                if (appState.getPointsAmount() >= 3)
                {
                    drawBezierCurve();
                }
            }
            else if (appState.getDrawingTool()=="Polygon")
            {
                if(appState.getSelectedPolygonMode()=="Draw")
                {
                    //addLayer();
                    layers[appState.getCurrentLayer()].addPolygonPoint(new Point(x, y));
                    drawing.drawPolygon(appState.getCurrentLayer(), layers[appState.getCurrentLayer()].getPointsList(), Color.Black);
                }
                else if (appState.getSelectedPolygonMode() == "Select")
                {
                    for(int i=0; i<layers.Count; i++)
                    {
                        if (isPointInside(layers[i].bitmap, Color.Black, new Point(x, y)))
                        {
                            drawing.drawPolygon(i, layers[i].getPointsList(), Color.Red);
                            layers[i].setSelected(true);
                        }
                        else
                        {
                            drawing.drawPolygon(i, layers[i].getPointsList(), Color.Black);
                            layers[i].setSelected(false);
                        }
                    }
                }

            }
        }

        private void menuPaintLine_Click(object sender, EventArgs e)
        {
            DrawLine drawline = new DrawLine(this,"line");
            drawline.ShowDialog();
        }

        private void menuPaintRectangle_Click(object sender, EventArgs e)
        {
            DrawLine drawline = new DrawLine(this, "rectangle");
            drawline.ShowDialog();
        }

        private void menuPaintCircle_Click(object sender, EventArgs e)
        {
            DrawLine drawline = new DrawLine(this, "circle");
            drawline.ShowDialog();
        }

        private void clearDrawingAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Image = null;
            //Image = new Bitmap(this.pictureBox.Width, this.pictureBox.Height);
            layers = null;
            layers = new List<Layer>();
            pictureBox.Image = null;
            pictureBox.Image = createBitmap(pictureBox.Width, pictureBox.Height, 255, 255, 255);
            appState.resetPoints();
            appState.resetPolygonPoints();
        }

        private void menuColorBlack_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuColor, menuColorBlack);
        }

        private void menuColorWhite_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuColor, menuColorWhite);
        }

        private void menuColorRed_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuColor, menuColorRed);
        }

        private void menuColorGreen_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuColor, menuColorGreen);
        }

        private void menuColorBlue_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuColor, menuColorBlue);
        }

        private void menuColorYellow_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuColor, menuColorYellow);
        }

        private void menuColorCyan_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuColor, menuColorCyan);
        }

        private void menuColorMagenta_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuColor, menuColorMagenta);
        }

        private void menuColorOrange_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuColor, menuColorOrange);
        }

        private void menuColorViolet_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuColor, menuColorViolet);
        }

        private void menuColorGrey_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuColor, menuColorGrey);
        }

        private void menuColorOther_Click(object sender, EventArgs e)
        {
            ColorPicker colorpicker = new ColorPicker(this);
            colorpicker.ShowDialog();
        }

        private void zoom (double ratio)
        {
            Size size = new Size((int)(Image.Width * ratio),(int)(Image.Height * ratio));
            Bitmap bitmap = new Bitmap(Image, size);
            pictureBox.Image = bitmap;
        }

        private void zoomPlusButton_Click(object sender, EventArgs e)
        {
            double ratio = appState.getZoom();
            if(ratio<8)
            {
                if (ratio < 1)
                    ratio *= 2;
                else
                    ratio += 1;
                appState.setZoom(ratio);
                zoom(ratio);
            }
        }

        private void zoomMinusButton_Click(object sender, EventArgs e)
        {
            double ratio = appState.getZoom();
            if (ratio>0.2)
            {
                if (ratio <= 1)
                    ratio /= 2;
                else
                    ratio -= 1;
                appState.setZoom(ratio);
                zoom(ratio);
            }
        }

        private void menuToolsRGBCube_Click(object sender, EventArgs e)
        {
            Cube cube = new Cube(this);
            cube.ShowDialog();
        }

        private void menuToolsPointTransformation_Click(object sender, EventArgs e)
        {
            if(Image==null)
            {
                MessageBox.Show("Open image first.","Error",MessageBoxButtons.OK);
            }
            else
            {
                Transformation transformation = new Transformation(this);
                transformation.Show(this);
            }
        }
        public void consoleSay(string text)
        {
            console.AppendText(DateTime.Now.ToString("HH:mm:ss") + " " + text + "\n");
            console.SelectionStart = console.Text.Length;
            console.ScrollToCaret();
        }

        private void menuEditUndo_Click(object sender, EventArgs e)
        {
            undo();
        }

        private void undo()
        {
            if (getMemoryIndex() > 0)
            {
                setMemoryIndex(getMemoryIndex() - 1);
                setImage(memoryGet(getMemoryIndex()),0);
                consoleSay("Displaying image from " + getMemoryIndex() + " index.");
            }
            else
                consoleSay("Cannot undo more.");
        }

        private void redo()
        {
            if (getMemoryIndex() < (getMemoryCount()-1))
            {
                setMemoryIndex(getMemoryIndex() + 1);
                setImage(memoryGet(getMemoryIndex()),0);
                consoleSay("Displaying image from " + getMemoryIndex() + " index.");
            }
            else
                consoleSay("Cannot redo more.");
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            undo();
        }

        private void menuEditRedo_Click(object sender, EventArgs e)
        {
            redo();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            redo();
        }

        private void menuToolsFiltering_Click(object sender, EventArgs e)
        {
            if (Image == null)
            {
                MessageBox.Show("Open image first.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Filtering filtering = new Filtering(this);
                filtering.Show(this);
            }
        }

        public void startLoading()
        {
            loading = new Loading();
            loading.Show(this);
            loading.Refresh();
        }

        public void stopLoading()
        {
            loading.Hide();
            loading.Dispose();
            loading = null;
        }

        private void menuToolsHistogram_Click(object sender, EventArgs e)
        {
            if (Image == null)
            {
                MessageBox.Show("Open image first.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Histogram histogram = new Histogram(this);
                histogram.Show(this);
            }
        }

        private void menuToolsBezier_Click(object sender, EventArgs e)
        {
            Bezier bezier = new Bezier(this);
            bezier.Show(this);
        }

        private void menuDrawingToolBezier_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuDrawingTool, menuDrawingToolBezier);
        }

        private void drawBezierCurve()
        {
            Bitmap bezierBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            bezierBitmap.MakeTransparent();
            Graphics graphics = Graphics.FromImage(bezierBitmap);
            double t;
            //Point p;
            for(int i=0; i<=1000; i++)
            {
                t = Convert.ToDouble(i) / 1000;
                bezierBitmap.SetPixel(getCurvePoint(t).X, getCurvePoint(t).Y, Color.Red);
            }

            setImage(bezierBitmap,1);
        }

        private int getFactorial(int n)
        {
            if (n == 0)
                return 1;
            else
            {
                int result = 1;
                for(int i=1; i<=n; i++)
                {
                    result *= i;
                }
                return result;
            }
        }

        private double getPower(double a, double b)
        {
            if (a == 0 && b == 0)
                return 1;
            else
                return Math.Pow(a, b);
        }

        private Point getCurvePoint(double t)
        {
            Point result;
            double px = 0;
            double py = 0;
            int n = appState.getPointsAmount() - 1;
            double bez;

            for(int k=0; k<=n; k++)
            {
                bez = (getFactorial(n) / (getFactorial(k) * getFactorial(n - k))) * getPower(t, k) * getPower(1 - t, n - k);
                px += (bez * appState.getBezierPoint(k).X);
                py += (bez * appState.getBezierPoint(k).Y);
            }

            result = new Point(Convert.ToInt32(px), Convert.ToInt32(py));

            return result;
        }

        private void polygonDraw_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuDrawingTool, polygonDraw);
            addLayer();
        }

        private void polygonMove_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuDrawingTool, polygonMove);
        }

        private void polygonRotate_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuDrawingTool, polygonRotate);
        }

        private void polygonSelect_Click(object sender, EventArgs e)
        {
            selectMenuItem(menuDrawingTool, polygonSelect);
        }

        private bool isPointInside(Bitmap bitmap, Color color, Point p)
        {
            int passes = 0; //number of times the line passed polygon borders
            bool colorChanged = false;
            Color pixelColor;

            pixelColor = bitmap.GetPixel(p.X, p.Y);
            if (pixelColor.A == color.A && pixelColor.R == color.R && pixelColor.G == color.G && pixelColor.B == color.B)
                return true;
            else
            {
                for (int i = p.X; i < bitmap.Width; i++)
                {
                    pixelColor = bitmap.GetPixel(i, p.Y);
                    if (pixelColor.A == color.A && pixelColor.R == color.R && pixelColor.G == color.G && pixelColor.B == color.B && colorChanged == false)
                    {
                        colorChanged = true;
                        passes++;
                    }
                    else if (!(pixelColor.A == color.A && pixelColor.R == color.R && pixelColor.G == color.G && pixelColor.B == color.B) && colorChanged == true)
                    {
                        colorChanged = false;
                    }
                }

            }

            if (passes % 2 == 0)
                return false;
            else
                return true;
        }
    }
}
