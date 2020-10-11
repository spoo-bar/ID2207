namespace PresentationTier
{
    partial class Main
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
            this.loggedinUserLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loggedinUserLabel
            // 
            this.loggedinUserLabel.AutoSize = true;
            this.loggedinUserLabel.Location = new System.Drawing.Point(608, 9);
            this.loggedinUserLabel.Name = "loggedinUserLabel";
            this.loggedinUserLabel.Size = new System.Drawing.Size(0, 17);
            this.loggedinUserLabel.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loggedinUserLabel);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loggedinUserLabel;
    }
}