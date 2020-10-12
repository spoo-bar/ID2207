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
            this.requestDataGridView = new System.Windows.Forms.DataGridView();
            this.createEventRequestButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.requestDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // requestDataGridView
            // 
            this.requestDataGridView.AllowUserToAddRows = false;
            this.requestDataGridView.AllowUserToDeleteRows = false;
            this.requestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestDataGridView.Location = new System.Drawing.Point(13, 13);
            this.requestDataGridView.MultiSelect = false;
            this.requestDataGridView.Name = "requestDataGridView";
            this.requestDataGridView.ReadOnly = true;
            this.requestDataGridView.RowHeadersWidth = 51;
            this.requestDataGridView.RowTemplate.Height = 24;
            this.requestDataGridView.Size = new System.Drawing.Size(775, 373);
            this.requestDataGridView.TabIndex = 0;
            this.requestDataGridView.DoubleClick += new System.EventHandler(this.RequestDataGridView_DoubleClick);
            // 
            // createEventRequestButton
            // 
            this.createEventRequestButton.Location = new System.Drawing.Point(13, 392);
            this.createEventRequestButton.Name = "createEventRequestButton";
            this.createEventRequestButton.Size = new System.Drawing.Size(775, 46);
            this.createEventRequestButton.TabIndex = 2;
            this.createEventRequestButton.Text = "Create Event Request";
            this.createEventRequestButton.UseVisualStyleBackColor = true;
            this.createEventRequestButton.Click += new System.EventHandler(this.CreateEventRequestButton_Click);
            // 
            // EventRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createEventRequestButton);
            this.Controls.Add(this.requestDataGridView);
            this.Name = "EventRequestForm";
            this.Text = "EventRequestForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EventRequestForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.requestDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView requestDataGridView;
        private System.Windows.Forms.Button createEventRequestButton;
    }
}