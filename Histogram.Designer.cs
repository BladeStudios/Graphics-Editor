namespace Graphics_Editor
{
    partial class Histogram
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
            this.histogramStretchingButton = new System.Windows.Forms.Button();
            this.redMinLabel = new System.Windows.Forms.Label();
            this.redMaxLabel = new System.Windows.Forms.Label();
            this.greenMinLabel = new System.Windows.Forms.Label();
            this.greenMaxLabel = new System.Windows.Forms.Label();
            this.blueMinLabel = new System.Windows.Forms.Label();
            this.blueMaxLabel = new System.Windows.Forms.Label();
            this.histogramEqualizationButton = new System.Windows.Forms.Button();
            this.binarizationBox = new System.Windows.Forms.GroupBox();
            this.customBinarizationButton = new System.Windows.Forms.Button();
            this.thresholdBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.thresholdValue = new System.Windows.Forms.NumericUpDown();
            this.bottomThresholdBox = new System.Windows.Forms.CheckBox();
            this.topThresholdBox = new System.Windows.Forms.CheckBox();
            this.binarizationBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdValue)).BeginInit();
            this.SuspendLayout();
            // 
            // histogramStretchingButton
            // 
            this.histogramStretchingButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.histogramStretchingButton.Location = new System.Drawing.Point(12, 79);
            this.histogramStretchingButton.Name = "histogramStretchingButton";
            this.histogramStretchingButton.Size = new System.Drawing.Size(396, 30);
            this.histogramStretchingButton.TabIndex = 39;
            this.histogramStretchingButton.Text = "Histogram Stretching";
            this.histogramStretchingButton.UseVisualStyleBackColor = true;
            this.histogramStretchingButton.Click += new System.EventHandler(this.histogramStretchingButton_Click);
            // 
            // redMinLabel
            // 
            this.redMinLabel.AutoSize = true;
            this.redMinLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.redMinLabel.Location = new System.Drawing.Point(12, 9);
            this.redMinLabel.Name = "redMinLabel";
            this.redMinLabel.Size = new System.Drawing.Size(109, 21);
            this.redMinLabel.TabIndex = 40;
            this.redMinLabel.Text = "RedMin = null";
            // 
            // redMaxLabel
            // 
            this.redMaxLabel.AutoSize = true;
            this.redMaxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.redMaxLabel.Location = new System.Drawing.Point(12, 42);
            this.redMaxLabel.Name = "redMaxLabel";
            this.redMaxLabel.Size = new System.Drawing.Size(111, 21);
            this.redMaxLabel.TabIndex = 41;
            this.redMaxLabel.Text = "RedMax = null";
            // 
            // greenMinLabel
            // 
            this.greenMinLabel.AutoSize = true;
            this.greenMinLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.greenMinLabel.Location = new System.Drawing.Point(153, 9);
            this.greenMinLabel.Name = "greenMinLabel";
            this.greenMinLabel.Size = new System.Drawing.Size(124, 21);
            this.greenMinLabel.TabIndex = 42;
            this.greenMinLabel.Text = "GreenMin = null";
            // 
            // greenMaxLabel
            // 
            this.greenMaxLabel.AutoSize = true;
            this.greenMaxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.greenMaxLabel.Location = new System.Drawing.Point(153, 42);
            this.greenMaxLabel.Name = "greenMaxLabel";
            this.greenMaxLabel.Size = new System.Drawing.Size(126, 21);
            this.greenMaxLabel.TabIndex = 43;
            this.greenMaxLabel.Text = "GreenMax = null";
            // 
            // blueMinLabel
            // 
            this.blueMinLabel.AutoSize = true;
            this.blueMinLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.blueMinLabel.Location = new System.Drawing.Point(296, 9);
            this.blueMinLabel.Name = "blueMinLabel";
            this.blueMinLabel.Size = new System.Drawing.Size(112, 21);
            this.blueMinLabel.TabIndex = 44;
            this.blueMinLabel.Text = "BlueMin = null";
            // 
            // blueMaxLabel
            // 
            this.blueMaxLabel.AutoSize = true;
            this.blueMaxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.blueMaxLabel.Location = new System.Drawing.Point(296, 42);
            this.blueMaxLabel.Name = "blueMaxLabel";
            this.blueMaxLabel.Size = new System.Drawing.Size(114, 21);
            this.blueMaxLabel.TabIndex = 45;
            this.blueMaxLabel.Text = "BlueMax = null";
            // 
            // histogramEqualizationButton
            // 
            this.histogramEqualizationButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.histogramEqualizationButton.Location = new System.Drawing.Point(12, 115);
            this.histogramEqualizationButton.Name = "histogramEqualizationButton";
            this.histogramEqualizationButton.Size = new System.Drawing.Size(396, 30);
            this.histogramEqualizationButton.TabIndex = 46;
            this.histogramEqualizationButton.Text = "Histogram Equalization";
            this.histogramEqualizationButton.UseVisualStyleBackColor = true;
            this.histogramEqualizationButton.Click += new System.EventHandler(this.histogramEqualizationButton_Click);
            // 
            // binarizationBox
            // 
            this.binarizationBox.Controls.Add(this.topThresholdBox);
            this.binarizationBox.Controls.Add(this.bottomThresholdBox);
            this.binarizationBox.Controls.Add(this.thresholdValue);
            this.binarizationBox.Controls.Add(this.label1);
            this.binarizationBox.Controls.Add(this.thresholdBar);
            this.binarizationBox.Controls.Add(this.customBinarizationButton);
            this.binarizationBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.binarizationBox.Location = new System.Drawing.Point(2, 151);
            this.binarizationBox.Name = "binarizationBox";
            this.binarizationBox.Size = new System.Drawing.Size(408, 387);
            this.binarizationBox.TabIndex = 47;
            this.binarizationBox.TabStop = false;
            this.binarizationBox.Text = "Binarization";
            // 
            // customBinarizationButton
            // 
            this.customBinarizationButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customBinarizationButton.Location = new System.Drawing.Point(6, 138);
            this.customBinarizationButton.Name = "customBinarizationButton";
            this.customBinarizationButton.Size = new System.Drawing.Size(396, 30);
            this.customBinarizationButton.TabIndex = 40;
            this.customBinarizationButton.Text = "Custom Binarization";
            this.customBinarizationButton.UseVisualStyleBackColor = true;
            this.customBinarizationButton.Click += new System.EventHandler(this.customBinarizationButton_Click);
            // 
            // thresholdBar
            // 
            this.thresholdBar.Location = new System.Drawing.Point(10, 63);
            this.thresholdBar.Maximum = 255;
            this.thresholdBar.Name = "thresholdBar";
            this.thresholdBar.Size = new System.Drawing.Size(335, 45);
            this.thresholdBar.TabIndex = 41;
            this.thresholdBar.Scroll += new System.EventHandler(this.thresholdBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 21);
            this.label1.TabIndex = 42;
            this.label1.Text = "Binarization Threshold";
            // 
            // thresholdValue
            // 
            this.thresholdValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.thresholdValue.Location = new System.Drawing.Point(351, 63);
            this.thresholdValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.thresholdValue.Name = "thresholdValue";
            this.thresholdValue.Size = new System.Drawing.Size(51, 29);
            this.thresholdValue.TabIndex = 43;
            this.thresholdValue.ValueChanged += new System.EventHandler(this.thresholdValue_ValueChanged);
            // 
            // bottomThresholdBox
            // 
            this.bottomThresholdBox.AutoSize = true;
            this.bottomThresholdBox.Checked = true;
            this.bottomThresholdBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bottomThresholdBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bottomThresholdBox.Location = new System.Drawing.Point(40, 107);
            this.bottomThresholdBox.Name = "bottomThresholdBox";
            this.bottomThresholdBox.Size = new System.Drawing.Size(153, 25);
            this.bottomThresholdBox.TabIndex = 44;
            this.bottomThresholdBox.Text = "Bottom Threshold";
            this.bottomThresholdBox.UseVisualStyleBackColor = true;
            this.bottomThresholdBox.CheckedChanged += new System.EventHandler(this.bottomThresholdBox_CheckedChanged);
            // 
            // topThresholdBox
            // 
            this.topThresholdBox.AutoSize = true;
            this.topThresholdBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.topThresholdBox.Location = new System.Drawing.Point(210, 107);
            this.topThresholdBox.Name = "topThresholdBox";
            this.topThresholdBox.Size = new System.Drawing.Size(126, 25);
            this.topThresholdBox.TabIndex = 45;
            this.topThresholdBox.Text = "Top Threshold";
            this.topThresholdBox.UseVisualStyleBackColor = true;
            this.topThresholdBox.CheckedChanged += new System.EventHandler(this.topThresholdBox_CheckedChanged);
            // 
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 541);
            this.Controls.Add(this.binarizationBox);
            this.Controls.Add(this.histogramEqualizationButton);
            this.Controls.Add(this.blueMaxLabel);
            this.Controls.Add(this.blueMinLabel);
            this.Controls.Add(this.greenMaxLabel);
            this.Controls.Add(this.greenMinLabel);
            this.Controls.Add(this.redMaxLabel);
            this.Controls.Add(this.redMinLabel);
            this.Controls.Add(this.histogramStretchingButton);
            this.Name = "Histogram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Histogram and Binarization";
            this.Load += new System.EventHandler(this.Histogram_Load);
            this.binarizationBox.ResumeLayout(false);
            this.binarizationBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button histogramStretchingButton;
        private System.Windows.Forms.Label redMinLabel;
        private System.Windows.Forms.Label redMaxLabel;
        private System.Windows.Forms.Label greenMinLabel;
        private System.Windows.Forms.Label greenMaxLabel;
        private System.Windows.Forms.Label blueMinLabel;
        private System.Windows.Forms.Label blueMaxLabel;
        private System.Windows.Forms.Button histogramEqualizationButton;
        private System.Windows.Forms.GroupBox binarizationBox;
        private System.Windows.Forms.Button customBinarizationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar thresholdBar;
        private System.Windows.Forms.NumericUpDown thresholdValue;
        private System.Windows.Forms.CheckBox bottomThresholdBox;
        private System.Windows.Forms.CheckBox topThresholdBox;
    }
}