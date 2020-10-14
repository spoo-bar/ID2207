using System;

namespace PresentationTier
{
    partial class StaffAvailabilityForm
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
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(62, 17);
            this.fromDateTimePicker.Value = DateTime.Now;
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(128, 22);
            this.fromDateTimePicker.TabIndex = 0;
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(249, 17);
            this.fromDateTimePicker.Value = DateTime.Now.AddDays(1);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(128, 22);
            this.toDateTimePicker.TabIndex = 1;
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(12, 17);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(44, 17);
            this.fromLabel.TabIndex = 2;
            this.fromLabel.Text = "From:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(214, 17);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(29, 17);
            this.toLabel.TabIndex = 3;
            this.toLabel.Text = "To:";
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.AllowUserToAddRows = false;
            this.staffDataGridView.AllowUserToDeleteRows = false;
            this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDataGridView.Location = new System.Drawing.Point(15, 51);
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.ReadOnly = true;
            this.staffDataGridView.RowHeadersWidth = 51;
            this.staffDataGridView.RowTemplate.Height = 24;
            this.staffDataGridView.Size = new System.Drawing.Size(773, 387);
            this.staffDataGridView.TabIndex = 4;
            // 
            // StaffAvailabilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.staffDataGridView);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Name = "StaffAvailabilityForm";
            this.Text = "StaffAvailabilityForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffAvailabilityForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DataGridView staffDataGridView;
    }
}