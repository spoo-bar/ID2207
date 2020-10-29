namespace PresentationTier
{
    partial class FinancialRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialRequestForm));
            this.financialRequestDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.financialRequestDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // financialRequestDataGridView
            // 
            this.financialRequestDataGridView.AllowUserToAddRows = false;
            this.financialRequestDataGridView.AllowUserToDeleteRows = false;
            this.financialRequestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.financialRequestDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financialRequestDataGridView.Location = new System.Drawing.Point(0, 0);
            this.financialRequestDataGridView.Name = "financialRequestDataGridView";
            this.financialRequestDataGridView.ReadOnly = true;
            this.financialRequestDataGridView.RowHeadersWidth = 51;
            this.financialRequestDataGridView.RowTemplate.Height = 24;
            this.financialRequestDataGridView.Size = new System.Drawing.Size(800, 450);
            this.financialRequestDataGridView.TabIndex = 0;
            this.financialRequestDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.FinancialRequestDataGridView_CellFormatting);
            this.financialRequestDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FinancialRequestDataGridView_CellMouseClick);
            // 
            // FinancialRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.financialRequestDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FinancialRequestForm";
            this.Text = "Financial Requests";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FinancialRequestForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.financialRequestDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView financialRequestDataGridView;
    }
}