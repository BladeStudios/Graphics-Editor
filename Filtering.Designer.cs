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
            this.SuspendLayout();
            // 
            // averagingFilterButton
            // 
            this.averagingFilterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.averagingFilterButton.Location = new System.Drawing.Point(275, 210);
            this.averagingFilterButton.Name = "averagingFilterButton";
            this.averagingFilterButton.Size = new System.Drawing.Size(250, 30);
            this.averagingFilterButton.TabIndex = 38;
            this.averagingFilterButton.Text = "Averaging Filter";
            this.averagingFilterButton.UseVisualStyleBackColor = true;
            // 
            // Filtering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.averagingFilterButton);
            this.Name = "Filtering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filtering";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button averagingFilterButton;
    }
}