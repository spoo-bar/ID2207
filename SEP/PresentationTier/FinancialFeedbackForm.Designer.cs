namespace PresentationTier
{
    partial class FinancialFeedbackForm
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
            this.budgetLabel = new System.Windows.Forms.Label();
            this.BudgetTextBox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eventTypeLabel = new System.Windows.Forms.Label();
            this.eventTypeTextBox = new System.Windows.Forms.TextBox();
            this.clientLabel = new System.Windows.Forms.Label();
            this.attendeesLabel = new System.Windows.Forms.Label();
            this.recordNrLabel = new System.Windows.Forms.Label();
            this.recordNrTextBox = new System.Windows.Forms.TextBox();
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.feedbackTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.attendeesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.Location = new System.Drawing.Point(12, 245);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(57, 17);
            this.budgetLabel.TabIndex = 28;
            this.budgetLabel.Text = "Budget:";
            // 
            // BudgetTextBox
            // 
            this.BudgetTextBox.Location = new System.Drawing.Point(128, 245);
            this.BudgetTextBox.Name = "BudgetTextBox";
            this.BudgetTextBox.ReadOnly = true;
            this.BudgetTextBox.Size = new System.Drawing.Size(100, 22);
            this.BudgetTextBox.TabIndex = 27;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(12, 175);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(29, 17);
            this.toLabel.TabIndex = 26;
            this.toLabel.Text = "To:";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Enabled = false;
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(128, 170);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.toDateTimePicker.TabIndex = 25;
            this.toDateTimePicker.Value = new System.DateTime(2020, 10, 11, 0, 0, 0, 0);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(12, 137);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(44, 17);
            this.fromLabel.TabIndex = 24;
            this.fromLabel.Text = "From:";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Enabled = false;
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(128, 132);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fromDateTimePicker.TabIndex = 23;
            this.fromDateTimePicker.Value = new System.DateTime(2020, 10, 11, 0, 0, 0, 0);
            // 
            // eventTypeLabel
            // 
            this.eventTypeLabel.AutoSize = true;
            this.eventTypeLabel.Location = new System.Drawing.Point(12, 87);
            this.eventTypeLabel.Name = "eventTypeLabel";
            this.eventTypeLabel.Size = new System.Drawing.Size(79, 17);
            this.eventTypeLabel.TabIndex = 21;
            this.eventTypeLabel.Text = "Event type:";
            // 
            // eventTypeTextBox
            // 
            this.eventTypeTextBox.Location = new System.Drawing.Point(128, 87);
            this.eventTypeTextBox.Name = "eventTypeTextBox";
            this.eventTypeTextBox.ReadOnly = true;
            this.eventTypeTextBox.Size = new System.Drawing.Size(100, 22);
            this.eventTypeTextBox.TabIndex = 20;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(12, 50);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(47, 17);
            this.clientLabel.TabIndex = 18;
            this.clientLabel.Text = "Client:";
            // 
            // attendeesLabel
            // 
            this.attendeesLabel.AutoSize = true;
            this.attendeesLabel.Location = new System.Drawing.Point(12, 208);
            this.attendeesLabel.Name = "attendeesLabel";
            this.attendeesLabel.Size = new System.Drawing.Size(76, 17);
            this.attendeesLabel.TabIndex = 17;
            this.attendeesLabel.Text = "Attendees:";
            // 
            // recordNrLabel
            // 
            this.recordNrLabel.AutoSize = true;
            this.recordNrLabel.Location = new System.Drawing.Point(12, 12);
            this.recordNrLabel.Name = "recordNrLabel";
            this.recordNrLabel.Size = new System.Drawing.Size(110, 17);
            this.recordNrLabel.TabIndex = 16;
            this.recordNrLabel.Text = "Record number:";
            // 
            // recordNrTextBox
            // 
            this.recordNrTextBox.Location = new System.Drawing.Point(128, 12);
            this.recordNrTextBox.Name = "recordNrTextBox";
            this.recordNrTextBox.ReadOnly = true;
            this.recordNrTextBox.Size = new System.Drawing.Size(100, 22);
            this.recordNrTextBox.TabIndex = 15;
            // 
            // clientTextBox
            // 
            this.clientTextBox.Location = new System.Drawing.Point(128, 50);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.ReadOnly = true;
            this.clientTextBox.Size = new System.Drawing.Size(100, 22);
            this.clientTextBox.TabIndex = 29;
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(12, 283);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(119, 17);
            this.feedbackLabel.TabIndex = 30;
            this.feedbackLabel.Text = "Budget feedback:";
            // 
            // feedbackTextBox
            // 
            this.feedbackTextBox.Location = new System.Drawing.Point(128, 283);
            this.feedbackTextBox.Multiline = true;
            this.feedbackTextBox.Name = "feedbackTextBox";
            this.feedbackTextBox.Size = new System.Drawing.Size(565, 104);
            this.feedbackTextBox.TabIndex = 31;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(15, 392);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 32;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // attendeesTextBox
            // 
            this.attendeesTextBox.Location = new System.Drawing.Point(128, 208);
            this.attendeesTextBox.Name = "attendeesTextBox";
            this.attendeesTextBox.ReadOnly = true;
            this.attendeesTextBox.Size = new System.Drawing.Size(100, 22);
            this.attendeesTextBox.TabIndex = 33;
            // 
            // FinancialFeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.attendeesTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.feedbackTextBox);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.clientTextBox);
            this.Controls.Add(this.budgetLabel);
            this.Controls.Add(this.BudgetTextBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.eventTypeLabel);
            this.Controls.Add(this.eventTypeTextBox);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.attendeesLabel);
            this.Controls.Add(this.recordNrLabel);
            this.Controls.Add(this.recordNrTextBox);
            this.Name = "FinancialFeedbackForm";
            this.Text = "FinancialFeedbackForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FinancialFeedbackForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label budgetLabel;
        private System.Windows.Forms.TextBox BudgetTextBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label eventTypeLabel;
        private System.Windows.Forms.TextBox eventTypeTextBox;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label attendeesLabel;
        private System.Windows.Forms.Label recordNrLabel;
        private System.Windows.Forms.TextBox recordNrTextBox;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.TextBox feedbackTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox attendeesTextBox;
    }
}