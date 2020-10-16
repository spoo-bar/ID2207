namespace PresentationTier
{
    partial class EventForm
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
            this.eventFormGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.eventFormGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // eventFormGridView
            // 
            this.eventFormGridView.AllowUserToAddRows = false;
            this.eventFormGridView.AllowUserToDeleteRows = false;
            this.eventFormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventFormGridView.Location = new System.Drawing.Point(0, 0);
            this.eventFormGridView.Name = "eventFormGridView";
            this.eventFormGridView.ReadOnly = true;
            this.eventFormGridView.RowHeadersWidth = 51;
            this.eventFormGridView.RowTemplate.Height = 24;
            this.eventFormGridView.Size = new System.Drawing.Size(788, 438);
            this.eventFormGridView.TabIndex = 0;
            this.eventFormGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EventFormGridView_CellMouseClick);
            this.eventFormGridView.DoubleClick += new System.EventHandler(this.EventDataGridView_DoubleClick);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eventFormGridView);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EventForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.eventFormGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView eventFormGridView;
    }
}