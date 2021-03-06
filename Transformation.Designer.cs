﻿namespace Graphics_Editor
{
    partial class Transformation
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
            this.Load += new System.EventHandler(Transformation_Load);
            this.value = new System.Windows.Forms.NumericUpDown();
            this.valueLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.modifyingBox = new System.Windows.Forms.GroupBox();
            this.brightnessBox = new System.Windows.Forms.GroupBox();
            this.brightnessValue = new System.Windows.Forms.NumericUpDown();
            this.brightnessBar = new System.Windows.Forms.TrackBar();
            this.greyScaleBox = new System.Windows.Forms.GroupBox();
            this.decompositionButton = new System.Windows.Forms.Button();
            this.averagingButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.value)).BeginInit();
            this.modifyingBox.SuspendLayout();
            this.brightnessBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).BeginInit();
            this.greyScaleBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // value
            // 
            this.value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.value.Location = new System.Drawing.Point(60, 24);
            this.value.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.value.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(51, 29);
            this.value.TabIndex = 24;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valueLabel.Location = new System.Drawing.Point(6, 26);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(48, 21);
            this.valueLabel.TabIndex = 25;
            this.valueLabel.Text = "Value";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addButton.Location = new System.Drawing.Point(127, 24);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(85, 30);
            this.addButton.TabIndex = 36;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subtractButton.Location = new System.Drawing.Point(228, 24);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(85, 30);
            this.subtractButton.TabIndex = 37;
            this.subtractButton.Text = "Subtract";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.multiplyButton.Location = new System.Drawing.Point(334, 24);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(85, 30);
            this.multiplyButton.TabIndex = 38;
            this.multiplyButton.Text = "Multiply";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.divideButton.Location = new System.Drawing.Point(437, 24);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(85, 30);
            this.divideButton.TabIndex = 39;
            this.divideButton.Text = "Divide";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // modifyingBox
            // 
            this.modifyingBox.Controls.Add(this.valueLabel);
            this.modifyingBox.Controls.Add(this.divideButton);
            this.modifyingBox.Controls.Add(this.value);
            this.modifyingBox.Controls.Add(this.multiplyButton);
            this.modifyingBox.Controls.Add(this.addButton);
            this.modifyingBox.Controls.Add(this.subtractButton);
            this.modifyingBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.modifyingBox.Location = new System.Drawing.Point(12, 12);
            this.modifyingBox.Name = "modifyingBox";
            this.modifyingBox.Size = new System.Drawing.Size(528, 69);
            this.modifyingBox.TabIndex = 42;
            this.modifyingBox.TabStop = false;
            this.modifyingBox.Text = "Modifying all pixels values";
            // 
            // brightnessBox
            // 
            this.brightnessBox.Controls.Add(this.brightnessValue);
            this.brightnessBox.Controls.Add(this.brightnessBar);
            this.brightnessBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.brightnessBox.Location = new System.Drawing.Point(12, 87);
            this.brightnessBox.Name = "brightnessBox";
            this.brightnessBox.Size = new System.Drawing.Size(528, 75);
            this.brightnessBox.TabIndex = 43;
            this.brightnessBox.TabStop = false;
            this.brightnessBox.Text = "Brightness";
            // 
            // brightnessValue
            // 
            this.brightnessValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brightnessValue.Location = new System.Drawing.Point(471, 24);
            this.brightnessValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.brightnessValue.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.brightnessValue.Name = "brightnessValue";
            this.brightnessValue.Size = new System.Drawing.Size(51, 29);
            this.brightnessValue.TabIndex = 25;
            this.brightnessValue.ValueChanged += new System.EventHandler(this.brightnessValue_ValueChanged);
            // 
            // brightnessBar
            // 
            this.brightnessBar.Location = new System.Drawing.Point(10, 24);
            this.brightnessBar.Maximum = 255;
            this.brightnessBar.Minimum = -255;
            this.brightnessBar.Name = "brightnessBar";
            this.brightnessBar.Size = new System.Drawing.Size(455, 45);
            this.brightnessBar.TabIndex = 20;
            this.brightnessBar.Scroll += new System.EventHandler(this.brightnessBar_Scroll);
            this.brightnessBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.brightnessBar_MouseDown);
            this.brightnessBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.brightnessBar_MouseUp);
            // 
            // greyScaleBox
            // 
            this.greyScaleBox.Controls.Add(this.decompositionButton);
            this.greyScaleBox.Controls.Add(this.averagingButton);
            this.greyScaleBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.greyScaleBox.Location = new System.Drawing.Point(12, 168);
            this.greyScaleBox.Name = "greyScaleBox";
            this.greyScaleBox.Size = new System.Drawing.Size(528, 84);
            this.greyScaleBox.TabIndex = 44;
            this.greyScaleBox.TabStop = false;
            this.greyScaleBox.Text = "Grey scale";
            // 
            // decompositionButton
            // 
            this.decompositionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decompositionButton.Location = new System.Drawing.Point(272, 33);
            this.decompositionButton.Name = "decompositionButton";
            this.decompositionButton.Size = new System.Drawing.Size(250, 30);
            this.decompositionButton.TabIndex = 38;
            this.decompositionButton.Text = "Decomposition Alghoritm";
            this.decompositionButton.UseVisualStyleBackColor = true;
            this.decompositionButton.Click += new System.EventHandler(this.decompositionButton_Click);
            // 
            // averagingButton
            // 
            this.averagingButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.averagingButton.Location = new System.Drawing.Point(10, 33);
            this.averagingButton.Name = "averagingButton";
            this.averagingButton.Size = new System.Drawing.Size(250, 30);
            this.averagingButton.TabIndex = 37;
            this.averagingButton.Text = "Averaging Alghoritm";
            this.averagingButton.UseVisualStyleBackColor = true;
            this.averagingButton.Click += new System.EventHandler(this.averagingButton_Click);
            // 
            // Transformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 262);
            this.Controls.Add(this.greyScaleBox);
            this.Controls.Add(this.brightnessBox);
            this.Controls.Add(this.modifyingBox);
            this.Name = "Transformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Point Transformation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Transformation_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.value)).EndInit();
            this.modifyingBox.ResumeLayout(false);
            this.modifyingBox.PerformLayout();
            this.brightnessBox.ResumeLayout(false);
            this.brightnessBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).EndInit();
            this.greyScaleBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown value;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.GroupBox modifyingBox;
        private System.Windows.Forms.GroupBox brightnessBox;
        private System.Windows.Forms.NumericUpDown brightnessValue;
        private System.Windows.Forms.TrackBar brightnessBar;
        private System.Windows.Forms.GroupBox greyScaleBox;
        private System.Windows.Forms.Button decompositionButton;
        private System.Windows.Forms.Button averagingButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}