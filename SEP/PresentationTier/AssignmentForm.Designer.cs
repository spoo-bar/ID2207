namespace PresentationTier
{
    partial class AssignmentForm
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
            this.assignmentDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // assignmentDataGridView
            // 
            this.assignmentDataGridView.AllowUserToAddRows = false;
            this.assignmentDataGridView.AllowUserToDeleteRows = false;
            this.assignmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignmentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assignmentDataGridView.Location = new System.Drawing.Point(0, 0);
            this.assignmentDataGridView.Name = "assignmentDataGridView";
            this.assignmentDataGridView.ReadOnly = true;
            this.assignmentDataGridView.RowHeadersWidth = 51;
            this.assignmentDataGridView.RowTemplate.Height = 24;
            this.assignmentDataGridView.Size = new System.Drawing.Size(800, 450);
            this.assignmentDataGridView.TabIndex = 0;
            this.assignmentDataGridView.DoubleClick += new System.EventHandler(this.AssignmentDataGridView_DoubleClick);
            // 
            // AssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.assignmentDataGridView);
            this.Name = "AssignmentForm";
            this.Text = "Assignments";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AssignmentForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView assignmentDataGridView;
    }
}