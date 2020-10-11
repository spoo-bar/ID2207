namespace PresentationTier
{
    partial class EventRequestForm
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
            this.textAttendees = new System.Windows.Forms.TextBox();
            this.labelAttendees = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textAttendees
            // 
            this.textAttendees.Location = new System.Drawing.Point(120, 12);
            this.textAttendees.Name = "textAttendees";
            this.textAttendees.Size = new System.Drawing.Size(100, 22);
            this.textAttendees.TabIndex = 0;
            // 
            // labelAttendees
            // 
            this.labelAttendees.AutoSize = true;
            this.labelAttendees.Location = new System.Drawing.Point(13, 12);
            this.labelAttendees.Name = "labelAttendees";
            this.labelAttendees.Size = new System.Drawing.Size(76, 17);
            this.labelAttendees.TabIndex = 1;
            this.labelAttendees.Text = "Attendees:";
            // 
            // EventRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAttendees);
            this.Controls.Add(this.textAttendees);
            this.Name = "EventRequest";
            this.Text = "Request for new event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textAttendees;
        private System.Windows.Forms.Label labelAttendees;
    }
}

