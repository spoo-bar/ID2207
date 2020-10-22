namespace PresentationTier
{
    partial class ManageAssignmentForm
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
            this.planLabel = new System.Windows.Forms.Label();
            this.planTextBox = new System.Windows.Forms.TextBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.commentDataGridView = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.commentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // planLabel
            // 
            this.planLabel.AutoSize = true;
            this.planLabel.Location = new System.Drawing.Point(12, 9);
            this.planLabel.Name = "planLabel";
            this.planLabel.Size = new System.Drawing.Size(40, 17);
            this.planLabel.TabIndex = 0;
            this.planLabel.Text = "Plan:";
            // 
            // planTextBox
            // 
            this.planTextBox.Location = new System.Drawing.Point(15, 29);
            this.planTextBox.Multiline = true;
            this.planTextBox.Name = "planTextBox";
            this.planTextBox.Size = new System.Drawing.Size(773, 219);
            this.planTextBox.TabIndex = 1;
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(12, 251);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(78, 17);
            this.commentLabel.TabIndex = 2;
            this.commentLabel.Text = "Comments:";
            // 
            // commentDataGridView
            // 
            this.commentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Comment,
            this.User});
            this.commentDataGridView.Location = new System.Drawing.Point(15, 271);
            this.commentDataGridView.Name = "commentDataGridView";
            this.commentDataGridView.RowHeadersWidth = 51;
            this.commentDataGridView.RowTemplate.Height = 24;
            this.commentDataGridView.Size = new System.Drawing.Size(773, 138);
            this.commentDataGridView.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(15, 415);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(773, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.MinimumWidth = 6;
            this.Comment.Name = "Comment";
            this.Comment.Width = 125;
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.MinimumWidth = 6;
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Width = 125;
            // 
            // ManageAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.commentDataGridView);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.planTextBox);
            this.Controls.Add(this.planLabel);
            this.Name = "ManageAssignmentForm";
            this.Text = "AssignmentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AssignmentForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.commentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label planLabel;
        private System.Windows.Forms.TextBox planTextBox;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.DataGridView commentDataGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
    }
}