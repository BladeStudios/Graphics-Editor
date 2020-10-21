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
        AppState appState;
        Drawing drawing;
        public Bitmap Image;
        public Form1()
        {
            InitializeComponent();
            file = new File(this);
            appState = new AppState(this);
            drawing = new Drawing(this);
            Image = new Bitmap(this.pictureBox.Width, this.pictureBox.Height);

            //setting button images
            int size = 20;

            this.menuColor.Image = createBitmap(size, 0, 0, 0);
            this.menuColorBlack.Image = createBitmap(size, 0, 0, 0);
            this.menuColorWhite.Image = createBitmap(size, 255, 255, 255);
            this.menuColorRed.Image = createBitmap(size,255,0,0);
            this.menuColorGreen.Image = createBitmap(size, 0, 255, 0);
            this.menuColorBlue.Image = createBitmap(size, 0, 0, 255);
            this.menuColorYellow.Image = createBitmap(size, 255, 255, 0);
            this.menuColorCyan.Image = createBitmap(size, 0, 255, 255);
            this.menuColorMagenta.Image = createBitmap(size, 255, 0, 255);
            this.menuColorOrange.Image = createBitmap(size, 255, 165, 0);
            this.menuColorViolet.Image = createBitmap(size, 238, 82, 238);
            this.menuColorGrey.Image = createBitmap(size, 80, 80, 80);
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
            file.Open();
        }

        Bitmap createBitmap(int size, int red, int green, int blue)
        {
            Bitmap bitmap = new Bitmap(size, size);
            Graphics graphics = Graphics.FromImage(bitmap);
            SolidBrush solidbrush = new SolidBrush(Color.FromArgb(red, green, blue));
            graphics.FillRectangle(solidbrush, 0, 0, size, size);
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
            }
            else if(menu == this.menuColor) //menu Color
            {

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
            drawing.drawPoint(x,y,appState.getColor());
        }

        private void menuPaintLine_Click(object sender, EventArgs e)
        {
            //drawing.drawLine(50, 50, 200, 200, Color.Red);
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
    }
}
