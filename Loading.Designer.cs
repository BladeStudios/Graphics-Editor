namespace Graphics_Editor
{
    partial class Loading
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
            this.Load += new System.EventHandler(Loading_Load);
            this.maskLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskLabel
            // 
            this.maskLabel.AutoSize = true;
            this.maskLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskLabel.Location = new System.Drawing.Point(199, 17);
            this.maskLabel.Name = "maskLabel";
            this.maskLabel.Size = new System.Drawing.Size(94, 21);
            this.maskLabel.TabIndex = 28;
            this.maskLabel.Text = "Processing...";
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 47);
            this.ControlBox = false;
            this.Controls.Add(this.maskLabel);
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Please wait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label maskLabel;
    }
}