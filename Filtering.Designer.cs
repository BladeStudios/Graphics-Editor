namespace Graphics_Editor
{
    partial class Filtering
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
            this.averagingFilterButton = new System.Windows.Forms.Button();
            this.medianFilterButton = new System.Windows.Forms.Button();
            this.sobelFilterHorizontalButton = new System.Windows.Forms.Button();
            this.sobelFilterVerticalButton = new System.Windows.Forms.Button();
            this.highPassFilterButton = new System.Windows.Forms.Button();
            this.gaussFilterButton = new System.Windows.Forms.Button();
            this.defaultFiltersBox = new System.Windows.Forms.GroupBox();
            this.customFiltersBox = new System.Windows.Forms.GroupBox();
            this.leftTopValue = new System.Windows.Forms.NumericUpDown();
            this.maskLabel = new System.Windows.Forms.Label();
            this.topValue = new System.Windows.Forms.NumericUpDown();
            this.rightTopValue = new System.Windows.Forms.NumericUpDown();
            this.leftValue = new System.Windows.Forms.NumericUpDown();
            this.middleValue = new System.Windows.Forms.NumericUpDown();
            this.rightValue = new System.Windows.Forms.NumericUpDown();
            this.leftBottomValue = new System.Windows.Forms.NumericUpDown();
            this.bottomValue = new System.Windows.Forms.NumericUpDown();
            this.rightBottomValue = new System.Windows.Forms.NumericUpDown();
            this.customFilterButton = new System.Windows.Forms.Button();
            this.defaultFiltersBox.SuspendLayout();
            this.customFiltersBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftTopValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightTopValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBottomValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBottomValue)).BeginInit();
            this.SuspendLayout();
            // 
            // averagingFilterButton
            // 
            this.averagingFilterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.averagingFilterButton.Location = new System.Drawing.Point(6, 21);
            this.averagingFilterButton.Name = "averagingFilterButton";
            this.averagingFilterButton.Size = new System.Drawing.Size(250, 30);
            this.averagingFilterButton.TabIndex = 38;
            this.averagingFilterButton.Text = "Averaging Filter";
            this.averagingFilterButton.UseVisualStyleBackColor = true;
            this.averagingFilterButton.Click += new System.EventHandler(this.averagingFilterButton_Click);
            // 
            // medianFilterButton
            // 
            this.medianFilterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.medianFilterButton.Location = new System.Drawing.Point(6, 57);
            this.medianFilterButton.Name = "medianFilterButton";
            this.medianFilterButton.Size = new System.Drawing.Size(250, 30);
            this.medianFilterButton.TabIndex = 39;
            this.medianFilterButton.Text = "Median Filter";
            this.medianFilterButton.UseVisualStyleBackColor = true;
            // 
            // sobelFilterHorizontalButton
            // 
            this.sobelFilterHorizontalButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sobelFilterHorizontalButton.Location = new System.Drawing.Point(6, 93);
            this.sobelFilterHorizontalButton.Name = "sobelFilterHorizontalButton";
            this.sobelFilterHorizontalButton.Size = new System.Drawing.Size(250, 30);
            this.sobelFilterHorizontalButton.TabIndex = 40;
            this.sobelFilterHorizontalButton.Text = "Sobel\'s Filter (Horizontal Mask)";
            this.sobelFilterHorizontalButton.UseVisualStyleBackColor = true;
            // 
            // sobelFilterVerticalButton
            // 
            this.sobelFilterVerticalButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sobelFilterVerticalButton.Location = new System.Drawing.Point(6, 129);
            this.sobelFilterVerticalButton.Name = "sobelFilterVerticalButton";
            this.sobelFilterVerticalButton.Size = new System.Drawing.Size(250, 30);
            this.sobelFilterVerticalButton.TabIndex = 41;
            this.sobelFilterVerticalButton.Text = "Sobel\'s Filter (Vertical Mask)";
            this.sobelFilterVerticalButton.UseVisualStyleBackColor = true;
            // 
            // highPassFilterButton
            // 
            this.highPassFilterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.highPassFilterButton.Location = new System.Drawing.Point(6, 165);
            this.highPassFilterButton.Name = "highPassFilterButton";
            this.highPassFilterButton.Size = new System.Drawing.Size(250, 30);
            this.highPassFilterButton.TabIndex = 42;
            this.highPassFilterButton.Text = "High-Pass Sharpening Filter";
            this.highPassFilterButton.UseVisualStyleBackColor = true;
            // 
            // gaussFilterButton
            // 
            this.gaussFilterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gaussFilterButton.Location = new System.Drawing.Point(6, 201);
            this.gaussFilterButton.Name = "gaussFilterButton";
            this.gaussFilterButton.Size = new System.Drawing.Size(250, 30);
            this.gaussFilterButton.TabIndex = 43;
            this.gaussFilterButton.Text = "Gauss Softening Filter";
            this.gaussFilterButton.UseVisualStyleBackColor = true;
            // 
            // defaultFiltersBox
            // 
            this.defaultFiltersBox.Controls.Add(this.averagingFilterButton);
            this.defaultFiltersBox.Controls.Add(this.medianFilterButton);
            this.defaultFiltersBox.Controls.Add(this.gaussFilterButton);
            this.defaultFiltersBox.Controls.Add(this.sobelFilterHorizontalButton);
            this.defaultFiltersBox.Controls.Add(this.highPassFilterButton);
            this.defaultFiltersBox.Controls.Add(this.sobelFilterVerticalButton);
            this.defaultFiltersBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.defaultFiltersBox.Location = new System.Drawing.Point(12, 12);
            this.defaultFiltersBox.Name = "defaultFiltersBox";
            this.defaultFiltersBox.Size = new System.Drawing.Size(267, 241);
            this.defaultFiltersBox.TabIndex = 44;
            this.defaultFiltersBox.TabStop = false;
            this.defaultFiltersBox.Text = "Default Filters";
            // 
            // customFiltersBox
            // 
            this.customFiltersBox.Controls.Add(this.customFilterButton);
            this.customFiltersBox.Controls.Add(this.rightBottomValue);
            this.customFiltersBox.Controls.Add(this.bottomValue);
            this.customFiltersBox.Controls.Add(this.leftBottomValue);
            this.customFiltersBox.Controls.Add(this.rightValue);
            this.customFiltersBox.Controls.Add(this.middleValue);
            this.customFiltersBox.Controls.Add(this.leftValue);
            this.customFiltersBox.Controls.Add(this.rightTopValue);
            this.customFiltersBox.Controls.Add(this.topValue);
            this.customFiltersBox.Controls.Add(this.maskLabel);
            this.customFiltersBox.Controls.Add(this.leftTopValue);
            this.customFiltersBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.customFiltersBox.Location = new System.Drawing.Point(285, 12);
            this.customFiltersBox.Name = "customFiltersBox";
            this.customFiltersBox.Size = new System.Drawing.Size(267, 241);
            this.customFiltersBox.TabIndex = 45;
            this.customFiltersBox.TabStop = false;
            this.customFiltersBox.Text = "Custom Filters";
            // 
            // leftTopValue
            // 
            this.leftTopValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftTopValue.Location = new System.Drawing.Point(20, 57);
            this.leftTopValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.leftTopValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.leftTopValue.Name = "leftTopValue";
            this.leftTopValue.Size = new System.Drawing.Size(51, 29);
            this.leftTopValue.TabIndex = 26;
            // 
            // maskLabel
            // 
            this.maskLabel.AutoSize = true;
            this.maskLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskLabel.Location = new System.Drawing.Point(16, 21);
            this.maskLabel.Name = "maskLabel";
            this.maskLabel.Size = new System.Drawing.Size(47, 21);
            this.maskLabel.TabIndex = 27;
            this.maskLabel.Text = "Mask";
            // 
            // topValue
            // 
            this.topValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topValue.Location = new System.Drawing.Point(89, 57);
            this.topValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.topValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.topValue.Name = "topValue";
            this.topValue.Size = new System.Drawing.Size(51, 29);
            this.topValue.TabIndex = 28;
            // 
            // rightTopValue
            // 
            this.rightTopValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rightTopValue.Location = new System.Drawing.Point(157, 57);
            this.rightTopValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rightTopValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.rightTopValue.Name = "rightTopValue";
            this.rightTopValue.Size = new System.Drawing.Size(51, 29);
            this.rightTopValue.TabIndex = 29;
            // 
            // leftValue
            // 
            this.leftValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftValue.Location = new System.Drawing.Point(20, 92);
            this.leftValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.leftValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.leftValue.Name = "leftValue";
            this.leftValue.Size = new System.Drawing.Size(51, 29);
            this.leftValue.TabIndex = 30;
            // 
            // middleValue
            // 
            this.middleValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.middleValue.Location = new System.Drawing.Point(89, 92);
            this.middleValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.middleValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.middleValue.Name = "middleValue";
            this.middleValue.Size = new System.Drawing.Size(51, 29);
            this.middleValue.TabIndex = 31;
            // 
            // rightValue
            // 
            this.rightValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rightValue.Location = new System.Drawing.Point(157, 92);
            this.rightValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rightValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.rightValue.Name = "rightValue";
            this.rightValue.Size = new System.Drawing.Size(51, 29);
            this.rightValue.TabIndex = 32;
            // 
            // leftBottomValue
            // 
            this.leftBottomValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftBottomValue.Location = new System.Drawing.Point(20, 127);
            this.leftBottomValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.leftBottomValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.leftBottomValue.Name = "leftBottomValue";
            this.leftBottomValue.Size = new System.Drawing.Size(51, 29);
            this.leftBottomValue.TabIndex = 33;
            // 
            // bottomValue
            // 
            this.bottomValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bottomValue.Location = new System.Drawing.Point(89, 127);
            this.bottomValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.bottomValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.bottomValue.Name = "bottomValue";
            this.bottomValue.Size = new System.Drawing.Size(51, 29);
            this.bottomValue.TabIndex = 34;
            // 
            // rightBottomValue
            // 
            this.rightBottomValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rightBottomValue.Location = new System.Drawing.Point(157, 127);
            this.rightBottomValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rightBottomValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.rightBottomValue.Name = "rightBottomValue";
            this.rightBottomValue.Size = new System.Drawing.Size(51, 29);
            this.rightBottomValue.TabIndex = 35;
            // 
            // customFilterButton
            // 
            this.customFilterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customFilterButton.Location = new System.Drawing.Point(6, 165);
            this.customFilterButton.Name = "customFilterButton";
            this.customFilterButton.Size = new System.Drawing.Size(250, 30);
            this.customFilterButton.TabIndex = 44;
            this.customFilterButton.Text = "Custom Filter";
            this.customFilterButton.UseVisualStyleBackColor = true;
            // 
            // Filtering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 262);
            this.Controls.Add(this.customFiltersBox);
            this.Controls.Add(this.defaultFiltersBox);
            this.Name = "Filtering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filtering";
            this.defaultFiltersBox.ResumeLayout(false);
            this.customFiltersBox.ResumeLayout(false);
            this.customFiltersBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftTopValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightTopValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBottomValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBottomValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button averagingFilterButton;
        private System.Windows.Forms.Button medianFilterButton;
        private System.Windows.Forms.Button sobelFilterHorizontalButton;
        private System.Windows.Forms.Button sobelFilterVerticalButton;
        private System.Windows.Forms.Button highPassFilterButton;
        private System.Windows.Forms.Button gaussFilterButton;
        private System.Windows.Forms.GroupBox defaultFiltersBox;
        private System.Windows.Forms.GroupBox customFiltersBox;
        private System.Windows.Forms.NumericUpDown leftTopValue;
        private System.Windows.Forms.Label maskLabel;
        private System.Windows.Forms.Button customFilterButton;
        private System.Windows.Forms.NumericUpDown rightBottomValue;
        private System.Windows.Forms.NumericUpDown bottomValue;
        private System.Windows.Forms.NumericUpDown leftBottomValue;
        private System.Windows.Forms.NumericUpDown rightValue;
        private System.Windows.Forms.NumericUpDown middleValue;
        private System.Windows.Forms.NumericUpDown leftValue;
        private System.Windows.Forms.NumericUpDown rightTopValue;
        private System.Windows.Forms.NumericUpDown topValue;
    }
}