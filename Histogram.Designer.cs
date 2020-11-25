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
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 157);
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
            this.Text = "Histogram";
            this.Load += new System.EventHandler(this.Histogram_Load);
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
    }
}