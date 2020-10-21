namespace Graphics_Editor
{
    partial class DrawLine
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
            this.fromXLabel = new System.Windows.Forms.Label();
            this.fromX = new System.Windows.Forms.NumericUpDown();
            this.fromYLabel = new System.Windows.Forms.Label();
            this.toXLabel = new System.Windows.Forms.Label();
            this.toYLabel = new System.Windows.Forms.Label();
            this.RLabel = new System.Windows.Forms.Label();
            this.fromY = new System.Windows.Forms.NumericUpDown();
            this.toX = new System.Windows.Forms.NumericUpDown();
            this.toY = new System.Windows.Forms.NumericUpDown();
            this.R = new System.Windows.Forms.NumericUpDown();
            this.GLabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.NumericUpDown();
            this.B = new System.Windows.Forms.NumericUpDown();
            this.drawButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fromX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fromXLabel
            // 
            this.fromXLabel.AutoSize = true;
            this.fromXLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fromXLabel.Location = new System.Drawing.Point(12, 18);
            this.fromXLabel.Name = "fromXLabel";
            this.fromXLabel.Size = new System.Drawing.Size(60, 21);
            this.fromXLabel.TabIndex = 0;
            this.fromXLabel.Text = "From X";
            // 
            // fromX
            // 
            this.fromX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fromX.Location = new System.Drawing.Point(79, 16);
            this.fromX.Name = "fromX";
            this.fromX.Size = new System.Drawing.Size(120, 29);
            this.fromX.TabIndex = 1;
            // 
            // fromYLabel
            // 
            this.fromYLabel.AutoSize = true;
            this.fromYLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fromYLabel.Location = new System.Drawing.Point(12, 57);
            this.fromYLabel.Name = "fromYLabel";
            this.fromYLabel.Size = new System.Drawing.Size(60, 21);
            this.fromYLabel.TabIndex = 2;
            this.fromYLabel.Text = "From Y";
            // 
            // toXLabel
            // 
            this.toXLabel.AutoSize = true;
            this.toXLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toXLabel.Location = new System.Drawing.Point(217, 18);
            this.toXLabel.Name = "toXLabel";
            this.toXLabel.Size = new System.Drawing.Size(38, 21);
            this.toXLabel.TabIndex = 3;
            this.toXLabel.Text = "To X";
            // 
            // toYLabel
            // 
            this.toYLabel.AutoSize = true;
            this.toYLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toYLabel.Location = new System.Drawing.Point(217, 59);
            this.toYLabel.Name = "toYLabel";
            this.toYLabel.Size = new System.Drawing.Size(38, 21);
            this.toYLabel.TabIndex = 4;
            this.toYLabel.Text = "To Y";
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RLabel.Location = new System.Drawing.Point(12, 109);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(23, 21);
            this.RLabel.TabIndex = 8;
            this.RLabel.Text = "R:";
            // 
            // fromY
            // 
            this.fromY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fromY.Location = new System.Drawing.Point(79, 57);
            this.fromY.Name = "fromY";
            this.fromY.Size = new System.Drawing.Size(120, 29);
            this.fromY.TabIndex = 9;
            // 
            // toX
            // 
            this.toX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toX.Location = new System.Drawing.Point(293, 16);
            this.toX.Name = "toX";
            this.toX.Size = new System.Drawing.Size(120, 29);
            this.toX.TabIndex = 10;
            // 
            // toY
            // 
            this.toY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toY.Location = new System.Drawing.Point(293, 59);
            this.toY.Name = "toY";
            this.toY.Size = new System.Drawing.Size(120, 29);
            this.toY.TabIndex = 11;
            // 
            // R
            // 
            this.R.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.R.Location = new System.Drawing.Point(41, 107);
            this.R.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(60, 29);
            this.R.TabIndex = 12;
            this.R.ValueChanged += new System.EventHandler(this.R_ValueChanged);
            // 
            // GLabel
            // 
            this.GLabel.AutoSize = true;
            this.GLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GLabel.Location = new System.Drawing.Point(107, 109);
            this.GLabel.Name = "GLabel";
            this.GLabel.Size = new System.Drawing.Size(24, 21);
            this.GLabel.TabIndex = 13;
            this.GLabel.Text = "G:";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BLabel.Location = new System.Drawing.Point(202, 109);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(22, 21);
            this.BLabel.TabIndex = 14;
            this.BLabel.Text = "B:";
            // 
            // G
            // 
            this.G.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.G.Location = new System.Drawing.Point(136, 107);
            this.G.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(60, 29);
            this.G.TabIndex = 15;
            this.G.ValueChanged += new System.EventHandler(this.G_ValueChanged);
            // 
            // B
            // 
            this.B.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B.Location = new System.Drawing.Point(231, 107);
            this.B.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(60, 29);
            this.B.TabIndex = 16;
            this.B.ValueChanged += new System.EventHandler(this.B_ValueChanged);
            // 
            // drawButton
            // 
            this.drawButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.drawButton.Location = new System.Drawing.Point(136, 153);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(151, 43);
            this.drawButton.TabIndex = 18;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(313, 107);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 29);
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // DrawLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 208);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.B);
            this.Controls.Add(this.G);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.GLabel);
            this.Controls.Add(this.R);
            this.Controls.Add(this.toY);
            this.Controls.Add(this.toX);
            this.Controls.Add(this.fromY);
            this.Controls.Add(this.RLabel);
            this.Controls.Add(this.toYLabel);
            this.Controls.Add(this.toXLabel);
            this.Controls.Add(this.fromYLabel);
            this.Controls.Add(this.fromX);
            this.Controls.Add(this.fromXLabel);
            this.Name = "DrawLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Draw Line";
            ((System.ComponentModel.ISupportInitialize)(this.fromX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromXLabel;
        private System.Windows.Forms.NumericUpDown fromX;
        private System.Windows.Forms.Label fromYLabel;
        private System.Windows.Forms.Label toXLabel;
        private System.Windows.Forms.Label toYLabel;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.NumericUpDown fromY;
        private System.Windows.Forms.NumericUpDown toX;
        private System.Windows.Forms.NumericUpDown toY;
        private System.Windows.Forms.NumericUpDown R;
        private System.Windows.Forms.Label GLabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.NumericUpDown G;
        private System.Windows.Forms.NumericUpDown B;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button drawButton;
    }
}