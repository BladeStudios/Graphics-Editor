namespace Graphics_Editor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaintLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaintRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaintCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearDrawingAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolsRGBCube = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolsPointTransformation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.menuDrawingTool = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuDrawingToolPencil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDrawingToolBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuDrawingToolLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDrawingToolRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDrawingToolCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColor = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuColorBlack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorWhite = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorRed = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorYellow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorCyan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorMagenta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorOrange = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorViolet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorGrey = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorOther = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomLabel = new System.Windows.Forms.ToolStripLabel();
            this.zoomMinusButton = new System.Windows.Forms.ToolStripButton();
            this.zoomPlusButton = new System.Windows.Forms.ToolStripButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.console = new System.Windows.Forms.RichTextBox();
            this.consoleLabel = new System.Windows.Forms.Label();
            this.menuBar.SuspendLayout();
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuPaint,
            this.menuView,
            this.menuTools,
            this.menuHelp});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1002, 29);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileNewWindow,
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.menuFilePrint});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 25);
            this.menuFile.Text = "File";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.Size = new System.Drawing.Size(171, 26);
            this.menuFileNew.Text = "New";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuFileNewWindow
            // 
            this.menuFileNewWindow.Name = "menuFileNewWindow";
            this.menuFileNewWindow.Size = new System.Drawing.Size(171, 26);
            this.menuFileNewWindow.Text = "New window";
            this.menuFileNewWindow.Click += new System.EventHandler(this.menuFileNewWindow_Click);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(171, 26);
            this.menuFileOpen.Text = "Open";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.Size = new System.Drawing.Size(171, 26);
            this.menuFileSave.Text = "Save";
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Size = new System.Drawing.Size(171, 26);
            this.menuFileSaveAs.Text = "Save as...";
            // 
            // menuFilePrint
            // 
            this.menuFilePrint.Name = "menuFilePrint";
            this.menuFilePrint.Size = new System.Drawing.Size(171, 26);
            this.menuFilePrint.Text = "Print...";
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditUndo,
            this.menuEditRedo,
            this.menuEditCut,
            this.menuEditCopy,
            this.menuEditPaste});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(48, 25);
            this.menuEdit.Text = "Edit";
            // 
            // menuEditUndo
            // 
            this.menuEditUndo.Name = "menuEditUndo";
            this.menuEditUndo.Size = new System.Drawing.Size(118, 26);
            this.menuEditUndo.Text = "Undo";
            // 
            // menuEditRedo
            // 
            this.menuEditRedo.Name = "menuEditRedo";
            this.menuEditRedo.Size = new System.Drawing.Size(118, 26);
            this.menuEditRedo.Text = "Redo";
            // 
            // menuEditCut
            // 
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.Size = new System.Drawing.Size(118, 26);
            this.menuEditCut.Text = "Cut";
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.Size = new System.Drawing.Size(118, 26);
            this.menuEditCopy.Text = "Copy";
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.Size = new System.Drawing.Size(118, 26);
            this.menuEditPaste.Text = "Paste";
            // 
            // menuPaint
            // 
            this.menuPaint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPaintLine,
            this.menuPaintRectangle,
            this.menuPaintCircle,
            this.toolStripMenuItem2,
            this.clearDrawingAreaToolStripMenuItem});
            this.menuPaint.Name = "menuPaint";
            this.menuPaint.Size = new System.Drawing.Size(65, 25);
            this.menuPaint.Text = "Paint...";
            // 
            // menuPaintLine
            // 
            this.menuPaintLine.Name = "menuPaintLine";
            this.menuPaintLine.Size = new System.Drawing.Size(215, 26);
            this.menuPaintLine.Text = "Line";
            this.menuPaintLine.Click += new System.EventHandler(this.menuPaintLine_Click);
            // 
            // menuPaintRectangle
            // 
            this.menuPaintRectangle.Name = "menuPaintRectangle";
            this.menuPaintRectangle.Size = new System.Drawing.Size(215, 26);
            this.menuPaintRectangle.Text = "Rectangle";
            this.menuPaintRectangle.Click += new System.EventHandler(this.menuPaintRectangle_Click);
            // 
            // menuPaintCircle
            // 
            this.menuPaintCircle.Name = "menuPaintCircle";
            this.menuPaintCircle.Size = new System.Drawing.Size(215, 26);
            this.menuPaintCircle.Text = "Circle";
            this.menuPaintCircle.Click += new System.EventHandler(this.menuPaintCircle_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(212, 6);
            // 
            // clearDrawingAreaToolStripMenuItem
            // 
            this.clearDrawingAreaToolStripMenuItem.Name = "clearDrawingAreaToolStripMenuItem";
            this.clearDrawingAreaToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.clearDrawingAreaToolStripMenuItem.Text = "Clear Drawing Area";
            this.clearDrawingAreaToolStripMenuItem.Click += new System.EventHandler(this.clearDrawingAreaToolStripMenuItem_Click);
            // 
            // menuView
            // 
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(56, 25);
            this.menuView.Text = "View";
            // 
            // menuTools
            // 
            this.menuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolsRGBCube,
            this.menuToolsPointTransformation});
            this.menuTools.Name = "menuTools";
            this.menuTools.Size = new System.Drawing.Size(57, 25);
            this.menuTools.Text = "Tools";
            // 
            // menuToolsRGBCube
            // 
            this.menuToolsRGBCube.Name = "menuToolsRGBCube";
            this.menuToolsRGBCube.Size = new System.Drawing.Size(225, 26);
            this.menuToolsRGBCube.Text = "RGB Cube";
            this.menuToolsRGBCube.Click += new System.EventHandler(this.menuToolsRGBCube_Click);
            // 
            // menuToolsPointTransformation
            // 
            this.menuToolsPointTransformation.Name = "menuToolsPointTransformation";
            this.menuToolsPointTransformation.Size = new System.Drawing.Size(225, 26);
            this.menuToolsPointTransformation.Text = "Point Transformation";
            this.menuToolsPointTransformation.Click += new System.EventHandler(this.menuToolsPointTransformation_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(54, 25);
            this.menuHelp.Text = "Help";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(122, 26);
            this.menuHelpAbout.Text = "About";
            // 
            // toolBar
            // 
            this.toolBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDrawingTool,
            this.menuColor,
            this.zoomLabel,
            this.zoomMinusButton,
            this.zoomPlusButton});
            this.toolBar.Location = new System.Drawing.Point(0, 29);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(1002, 28);
            this.toolBar.TabIndex = 1;
            this.toolBar.Text = "toolStrip1";
            // 
            // menuDrawingTool
            // 
            this.menuDrawingTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDrawingToolPencil,
            this.menuDrawingToolBrush,
            this.toolStripMenuItem1,
            this.menuDrawingToolLine,
            this.menuDrawingToolRectangle,
            this.menuDrawingToolCircle});
            this.menuDrawingTool.Image = global::Graphics_Editor.Properties.Resources.pencil;
            this.menuDrawingTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuDrawingTool.Name = "menuDrawingTool";
            this.menuDrawingTool.Size = new System.Drawing.Size(130, 25);
            this.menuDrawingTool.Text = "Drawing Tool";
            this.menuDrawingTool.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // menuDrawingToolPencil
            // 
            this.menuDrawingToolPencil.Checked = true;
            this.menuDrawingToolPencil.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuDrawingToolPencil.Image = global::Graphics_Editor.Properties.Resources.pencil;
            this.menuDrawingToolPencil.Name = "menuDrawingToolPencil";
            this.menuDrawingToolPencil.Size = new System.Drawing.Size(148, 26);
            this.menuDrawingToolPencil.Text = "Pencil";
            this.menuDrawingToolPencil.Click += new System.EventHandler(this.menuDrawingToolPencil_Click);
            // 
            // menuDrawingToolBrush
            // 
            this.menuDrawingToolBrush.Image = global::Graphics_Editor.Properties.Resources.brush;
            this.menuDrawingToolBrush.Name = "menuDrawingToolBrush";
            this.menuDrawingToolBrush.Size = new System.Drawing.Size(148, 26);
            this.menuDrawingToolBrush.Text = "Brush";
            this.menuDrawingToolBrush.Click += new System.EventHandler(this.menuDrawingToolBrush_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 6);
            // 
            // menuDrawingToolLine
            // 
            this.menuDrawingToolLine.Image = global::Graphics_Editor.Properties.Resources.line;
            this.menuDrawingToolLine.Name = "menuDrawingToolLine";
            this.menuDrawingToolLine.Size = new System.Drawing.Size(148, 26);
            this.menuDrawingToolLine.Text = "Line";
            this.menuDrawingToolLine.Click += new System.EventHandler(this.menuDrawingToolLine_Click);
            // 
            // menuDrawingToolRectangle
            // 
            this.menuDrawingToolRectangle.Image = global::Graphics_Editor.Properties.Resources.rectangle;
            this.menuDrawingToolRectangle.Name = "menuDrawingToolRectangle";
            this.menuDrawingToolRectangle.Size = new System.Drawing.Size(148, 26);
            this.menuDrawingToolRectangle.Text = "Rectangle";
            this.menuDrawingToolRectangle.Click += new System.EventHandler(this.menuDrawingToolRectangle_Click);
            // 
            // menuDrawingToolCircle
            // 
            this.menuDrawingToolCircle.Image = global::Graphics_Editor.Properties.Resources.circle;
            this.menuDrawingToolCircle.Name = "menuDrawingToolCircle";
            this.menuDrawingToolCircle.Size = new System.Drawing.Size(148, 26);
            this.menuDrawingToolCircle.Text = "Circle";
            this.menuDrawingToolCircle.Click += new System.EventHandler(this.menuDrawingToolCircle_Click);
            // 
            // menuColor
            // 
            this.menuColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuColorBlack,
            this.menuColorWhite,
            this.menuColorRed,
            this.menuColorGreen,
            this.menuColorBlue,
            this.menuColorYellow,
            this.menuColorCyan,
            this.menuColorMagenta,
            this.menuColorOrange,
            this.menuColorViolet,
            this.menuColorGrey,
            this.menuColorOther});
            this.menuColor.Image = ((System.Drawing.Image)(resources.GetObject("menuColor.Image")));
            this.menuColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuColor.Name = "menuColor";
            this.menuColor.Size = new System.Drawing.Size(77, 25);
            this.menuColor.Text = "Color";
            this.menuColor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // menuColorBlack
            // 
            this.menuColorBlack.Checked = true;
            this.menuColorBlack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuColorBlack.Name = "menuColorBlack";
            this.menuColorBlack.Size = new System.Drawing.Size(141, 26);
            this.menuColorBlack.Text = "Black";
            this.menuColorBlack.Click += new System.EventHandler(this.menuColorBlack_Click);
            // 
            // menuColorWhite
            // 
            this.menuColorWhite.Name = "menuColorWhite";
            this.menuColorWhite.Size = new System.Drawing.Size(141, 26);
            this.menuColorWhite.Text = "White";
            this.menuColorWhite.Click += new System.EventHandler(this.menuColorWhite_Click);
            // 
            // menuColorRed
            // 
            this.menuColorRed.Name = "menuColorRed";
            this.menuColorRed.Size = new System.Drawing.Size(141, 26);
            this.menuColorRed.Text = "Red";
            this.menuColorRed.Click += new System.EventHandler(this.menuColorRed_Click);
            // 
            // menuColorGreen
            // 
            this.menuColorGreen.Name = "menuColorGreen";
            this.menuColorGreen.Size = new System.Drawing.Size(141, 26);
            this.menuColorGreen.Text = "Green";
            this.menuColorGreen.Click += new System.EventHandler(this.menuColorGreen_Click);
            // 
            // menuColorBlue
            // 
            this.menuColorBlue.Name = "menuColorBlue";
            this.menuColorBlue.Size = new System.Drawing.Size(141, 26);
            this.menuColorBlue.Text = "Blue";
            this.menuColorBlue.Click += new System.EventHandler(this.menuColorBlue_Click);
            // 
            // menuColorYellow
            // 
            this.menuColorYellow.Name = "menuColorYellow";
            this.menuColorYellow.Size = new System.Drawing.Size(141, 26);
            this.menuColorYellow.Text = "Yellow";
            this.menuColorYellow.Click += new System.EventHandler(this.menuColorYellow_Click);
            // 
            // menuColorCyan
            // 
            this.menuColorCyan.Name = "menuColorCyan";
            this.menuColorCyan.Size = new System.Drawing.Size(141, 26);
            this.menuColorCyan.Text = "Cyan";
            this.menuColorCyan.Click += new System.EventHandler(this.menuColorCyan_Click);
            // 
            // menuColorMagenta
            // 
            this.menuColorMagenta.Name = "menuColorMagenta";
            this.menuColorMagenta.Size = new System.Drawing.Size(141, 26);
            this.menuColorMagenta.Text = "Magenta";
            this.menuColorMagenta.Click += new System.EventHandler(this.menuColorMagenta_Click);
            // 
            // menuColorOrange
            // 
            this.menuColorOrange.Name = "menuColorOrange";
            this.menuColorOrange.Size = new System.Drawing.Size(141, 26);
            this.menuColorOrange.Text = "Orange";
            this.menuColorOrange.Click += new System.EventHandler(this.menuColorOrange_Click);
            // 
            // menuColorViolet
            // 
            this.menuColorViolet.Name = "menuColorViolet";
            this.menuColorViolet.Size = new System.Drawing.Size(141, 26);
            this.menuColorViolet.Text = "Violet";
            this.menuColorViolet.Click += new System.EventHandler(this.menuColorViolet_Click);
            // 
            // menuColorGrey
            // 
            this.menuColorGrey.Name = "menuColorGrey";
            this.menuColorGrey.Size = new System.Drawing.Size(141, 26);
            this.menuColorGrey.Text = "Grey";
            this.menuColorGrey.Click += new System.EventHandler(this.menuColorGrey_Click);
            // 
            // menuColorOther
            // 
            this.menuColorOther.Name = "menuColorOther";
            this.menuColorOther.Size = new System.Drawing.Size(141, 26);
            this.menuColorOther.Text = "Other...";
            this.menuColorOther.Click += new System.EventHandler(this.menuColorOther_Click);
            // 
            // zoomLabel
            // 
            this.zoomLabel.AutoSize = false;
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(100, 25);
            this.zoomLabel.Text = "Zoom: 1x";
            this.zoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // zoomMinusButton
            // 
            this.zoomMinusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomMinusButton.Image = global::Graphics_Editor.Properties.Resources.zoomminus1;
            this.zoomMinusButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomMinusButton.Name = "zoomMinusButton";
            this.zoomMinusButton.Size = new System.Drawing.Size(23, 25);
            this.zoomMinusButton.Text = "toolStripButton2";
            this.zoomMinusButton.ToolTipText = "Zoom -";
            this.zoomMinusButton.Click += new System.EventHandler(this.zoomMinusButton_Click);
            // 
            // zoomPlusButton
            // 
            this.zoomPlusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomPlusButton.Image = global::Graphics_Editor.Properties.Resources.zoomplus1;
            this.zoomPlusButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomPlusButton.Name = "zoomPlusButton";
            this.zoomPlusButton.Size = new System.Drawing.Size(23, 25);
            this.zoomPlusButton.Text = "toolStripButton1";
            this.zoomPlusButton.ToolTipText = "Zoom +";
            this.zoomPlusButton.Click += new System.EventHandler(this.zoomPlusButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(0, 57);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1000, 450);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // console
            // 
            this.console.Font = new System.Drawing.Font("Verdana", 8F);
            this.console.Location = new System.Drawing.Point(0, 528);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(1000, 110);
            this.console.TabIndex = 3;
            this.console.Text = "";
            // 
            // consoleLabel
            // 
            this.consoleLabel.AutoSize = true;
            this.consoleLabel.Location = new System.Drawing.Point(-3, 507);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(73, 18);
            this.consoleLabel.TabIndex = 4;
            this.consoleLabel.Text = "Console";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 639);
            this.Controls.Add(this.consoleLabel);
            this.Controls.Add(this.console);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.menuBar);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphics Editor";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileNewWindow;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuFilePrint;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditUndo;
        private System.Windows.Forms.ToolStripMenuItem menuEditRedo;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolStrip toolBar;
        public System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripMenuItem menuPaint;
        private System.Windows.Forms.ToolStripMenuItem menuPaintLine;
        private System.Windows.Forms.ToolStripMenuItem menuPaintRectangle;
        private System.Windows.Forms.ToolStripMenuItem menuPaintCircle;
        public System.Windows.Forms.ToolStripDropDownButton menuDrawingTool;
        public System.Windows.Forms.ToolStripDropDownButton menuColor;
        public System.Windows.Forms.ToolStripMenuItem menuDrawingToolPencil;
        public System.Windows.Forms.ToolStripMenuItem menuDrawingToolBrush;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem menuDrawingToolLine;
        public System.Windows.Forms.ToolStripMenuItem menuDrawingToolRectangle;
        public System.Windows.Forms.ToolStripMenuItem menuDrawingToolCircle;
        private System.Windows.Forms.ToolStripMenuItem menuColorBlack;
        private System.Windows.Forms.ToolStripMenuItem menuColorWhite;
        private System.Windows.Forms.ToolStripMenuItem menuColorRed;
        private System.Windows.Forms.ToolStripMenuItem menuColorGreen;
        private System.Windows.Forms.ToolStripMenuItem menuColorBlue;
        private System.Windows.Forms.ToolStripMenuItem menuColorYellow;
        private System.Windows.Forms.ToolStripMenuItem menuColorCyan;
        private System.Windows.Forms.ToolStripMenuItem menuColorMagenta;
        private System.Windows.Forms.ToolStripMenuItem menuColorOrange;
        private System.Windows.Forms.ToolStripMenuItem menuColorViolet;
        private System.Windows.Forms.ToolStripMenuItem menuColorGrey;
        public System.Windows.Forms.ToolStripMenuItem menuColorOther;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clearDrawingAreaToolStripMenuItem;
        public System.Windows.Forms.ToolStripLabel zoomLabel;
        private System.Windows.Forms.ToolStripButton zoomPlusButton;
        private System.Windows.Forms.ToolStripButton zoomMinusButton;
        public System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Label consoleLabel;
        private System.Windows.Forms.ToolStripMenuItem menuTools;
        private System.Windows.Forms.ToolStripMenuItem menuToolsRGBCube;
        private System.Windows.Forms.ToolStripMenuItem menuToolsPointTransformation;
    }
}

