namespace Graphics_Editor
{
    partial class Actions
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
            this.drawButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.vectorX = new System.Windows.Forms.NumericUpDown();
            this.vectorY = new System.Windows.Forms.NumericUpDown();
            this.vectorXLabel = new System.Windows.Forms.Label();
            this.vectorYLabel = new System.Windows.Forms.Label();
            this.rotateButton = new System.Windows.Forms.Button();
            this.rotateXLabel = new System.Windows.Forms.Label();
            this.rotateX = new System.Windows.Forms.NumericUpDown();
            this.rotateYLabel = new System.Windows.Forms.Label();
            this.rotateY = new System.Windows.Forms.NumericUpDown();
            this.rotateAngleLabel = new System.Windows.Forms.Label();
            this.rotateAngle = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.vectorX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vectorY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // drawButton
            // 
            this.drawButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.drawButton.Location = new System.Drawing.Point(33, 21);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(250, 30);
            this.drawButton.TabIndex = 39;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectButton.Location = new System.Drawing.Point(33, 57);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(250, 30);
            this.selectButton.TabIndex = 40;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // moveButton
            // 
            this.moveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moveButton.Location = new System.Drawing.Point(33, 93);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(250, 30);
            this.moveButton.TabIndex = 41;
            this.moveButton.Text = "Move by vector...";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // vectorX
            // 
            this.vectorX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vectorX.Location = new System.Drawing.Point(333, 93);
            this.vectorX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.vectorX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.vectorX.Name = "vectorX";
            this.vectorX.Size = new System.Drawing.Size(51, 29);
            this.vectorX.TabIndex = 43;
            // 
            // vectorY
            // 
            this.vectorY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vectorY.Location = new System.Drawing.Point(430, 93);
            this.vectorY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.vectorY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.vectorY.Name = "vectorY";
            this.vectorY.Size = new System.Drawing.Size(51, 29);
            this.vectorY.TabIndex = 44;
            // 
            // vectorXLabel
            // 
            this.vectorXLabel.AutoSize = true;
            this.vectorXLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vectorXLabel.Location = new System.Drawing.Point(310, 95);
            this.vectorXLabel.Name = "vectorXLabel";
            this.vectorXLabel.Size = new System.Drawing.Size(17, 21);
            this.vectorXLabel.TabIndex = 45;
            this.vectorXLabel.Text = "x";
            // 
            // vectorYLabel
            // 
            this.vectorYLabel.AutoSize = true;
            this.vectorYLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vectorYLabel.Location = new System.Drawing.Point(407, 95);
            this.vectorYLabel.Name = "vectorYLabel";
            this.vectorYLabel.Size = new System.Drawing.Size(18, 21);
            this.vectorYLabel.TabIndex = 46;
            this.vectorYLabel.Text = "y";
            // 
            // rotateButton
            // 
            this.rotateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rotateButton.Location = new System.Drawing.Point(33, 129);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(250, 30);
            this.rotateButton.TabIndex = 47;
            this.rotateButton.Text = "Rotate by...";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // rotateXLabel
            // 
            this.rotateXLabel.AutoSize = true;
            this.rotateXLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rotateXLabel.Location = new System.Drawing.Point(310, 129);
            this.rotateXLabel.Name = "rotateXLabel";
            this.rotateXLabel.Size = new System.Drawing.Size(17, 21);
            this.rotateXLabel.TabIndex = 48;
            this.rotateXLabel.Text = "x";
            // 
            // rotateX
            // 
            this.rotateX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rotateX.Location = new System.Drawing.Point(333, 127);
            this.rotateX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rotateX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.rotateX.Name = "rotateX";
            this.rotateX.Size = new System.Drawing.Size(51, 29);
            this.rotateX.TabIndex = 49;
            // 
            // rotateYLabel
            // 
            this.rotateYLabel.AutoSize = true;
            this.rotateYLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rotateYLabel.Location = new System.Drawing.Point(407, 129);
            this.rotateYLabel.Name = "rotateYLabel";
            this.rotateYLabel.Size = new System.Drawing.Size(18, 21);
            this.rotateYLabel.TabIndex = 50;
            this.rotateYLabel.Text = "y";
            // 
            // rotateY
            // 
            this.rotateY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rotateY.Location = new System.Drawing.Point(431, 128);
            this.rotateY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rotateY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.rotateY.Name = "rotateY";
            this.rotateY.Size = new System.Drawing.Size(51, 29);
            this.rotateY.TabIndex = 51;
            // 
            // rotateAngleLabel
            // 
            this.rotateAngleLabel.AutoSize = true;
            this.rotateAngleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rotateAngleLabel.Location = new System.Drawing.Point(502, 130);
            this.rotateAngleLabel.Name = "rotateAngleLabel";
            this.rotateAngleLabel.Size = new System.Drawing.Size(16, 21);
            this.rotateAngleLabel.TabIndex = 52;
            this.rotateAngleLabel.Text = "°";
            // 
            // rotateAngle
            // 
            this.rotateAngle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rotateAngle.Location = new System.Drawing.Point(526, 127);
            this.rotateAngle.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.rotateAngle.Minimum = new decimal(new int[] {
            359,
            0,
            0,
            -2147483648});
            this.rotateAngle.Name = "rotateAngle";
            this.rotateAngle.Size = new System.Drawing.Size(51, 29);
            this.rotateAngle.TabIndex = 53;
            // 
            // Actions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 185);
            this.Controls.Add(this.rotateAngle);
            this.Controls.Add(this.rotateAngleLabel);
            this.Controls.Add(this.rotateY);
            this.Controls.Add(this.rotateYLabel);
            this.Controls.Add(this.rotateX);
            this.Controls.Add(this.rotateXLabel);
            this.Controls.Add(this.rotateButton);
            this.Controls.Add(this.vectorYLabel);
            this.Controls.Add(this.vectorXLabel);
            this.Controls.Add(this.vectorY);
            this.Controls.Add(this.vectorX);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.drawButton);
            this.Name = "Actions";
            this.Text = "Polygon Actions";
            this.Load += new System.EventHandler(this.Actions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vectorX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vectorY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.NumericUpDown vectorX;
        private System.Windows.Forms.NumericUpDown vectorY;
        private System.Windows.Forms.Label vectorXLabel;
        private System.Windows.Forms.Label vectorYLabel;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.Label rotateXLabel;
        private System.Windows.Forms.NumericUpDown rotateX;
        private System.Windows.Forms.Label rotateYLabel;
        private System.Windows.Forms.NumericUpDown rotateY;
        private System.Windows.Forms.Label rotateAngleLabel;
        private System.Windows.Forms.NumericUpDown rotateAngle;
    }
}