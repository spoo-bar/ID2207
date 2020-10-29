namespace PresentationTier
{
    partial class ManageEventRequestForm
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
            this.components = new System.ComponentModel.Container();
            this.recordNrTextBox = new System.Windows.Forms.TextBox();
            this.recordNrLabel = new System.Windows.Forms.Label();
            this.attendeesLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.clientListBox = new System.Windows.Forms.ListBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventTypeLabel = new System.Windows.Forms.Label();
            this.eventTypeTextBox = new System.Windows.Forms.TextBox();
            this.attendeesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.budgetLabel = new System.Windows.Forms.Label();
            this.BudgetTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.feedbackTextBox = new System.Windows.Forms.TextBox();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.declineButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendeesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // recordNrTextBox
            // 
            this.recordNrTextBox.Location = new System.Drawing.Point(129, 12);
            this.recordNrTextBox.Name = "recordNrTextBox";
            this.recordNrTextBox.Size = new System.Drawing.Size(100, 22);
            this.recordNrTextBox.TabIndex = 0;
            // 
            // recordNrLabel
            // 
            this.recordNrLabel.AutoSize = true;
            this.recordNrLabel.Location = new System.Drawing.Point(13, 12);
            this.recordNrLabel.Name = "recordNrLabel";
            this.recordNrLabel.Size = new System.Drawing.Size(110, 17);
            this.recordNrLabel.TabIndex = 1;
            this.recordNrLabel.Text = "Record number:";
            // 
            // attendeesLabel
            // 
            this.attendeesLabel.AutoSize = true;
            this.attendeesLabel.Location = new System.Drawing.Point(13, 240);
            this.attendeesLabel.Name = "attendeesLabel";
            this.attendeesLabel.Size = new System.Drawing.Size(76, 17);
            this.attendeesLabel.TabIndex = 3;
            this.attendeesLabel.Text = "Attendees:";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(13, 50);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(47, 17);
            this.clientLabel.TabIndex = 4;
            this.clientLabel.Text = "Client:";
            // 
            // clientListBox
            // 
            this.clientListBox.FormattingEnabled = true;
            this.clientListBox.ItemHeight = 16;
            this.clientListBox.Location = new System.Drawing.Point(129, 50);
            this.clientListBox.Name = "clientListBox";
            this.clientListBox.Size = new System.Drawing.Size(120, 52);
            this.clientListBox.TabIndex = 5;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(DataTier.Client);
            // 
            // eventTypeLabel
            // 
            this.eventTypeLabel.AutoSize = true;
            this.eventTypeLabel.Location = new System.Drawing.Point(13, 119);
            this.eventTypeLabel.Name = "eventTypeLabel";
            this.eventTypeLabel.Size = new System.Drawing.Size(79, 17);
            this.eventTypeLabel.TabIndex = 7;
            this.eventTypeLabel.Text = "Event type:";
            // 
            // eventTypeTextBox
            // 
            this.eventTypeTextBox.Location = new System.Drawing.Point(129, 119);
            this.eventTypeTextBox.Name = "eventTypeTextBox";
            this.eventTypeTextBox.Size = new System.Drawing.Size(100, 22);
            this.eventTypeTextBox.TabIndex = 6;
            // 
            // attendeesNumericUpDown
            // 
            this.attendeesNumericUpDown.Location = new System.Drawing.Point(129, 240);
            this.attendeesNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.attendeesNumericUpDown.Name = "attendeesNumericUpDown";
            this.attendeesNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.attendeesNumericUpDown.TabIndex = 8;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(129, 164);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fromDateTimePicker.TabIndex = 9;
            this.fromDateTimePicker.Value = new System.DateTime(2020, 10, 11, 0, 0, 0, 0);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(13, 169);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(44, 17);
            this.fromLabel.TabIndex = 10;
            this.fromLabel.Text = "From:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(13, 207);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(29, 17);
            this.toLabel.TabIndex = 12;
            this.toLabel.Text = "To:";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(129, 202);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.toDateTimePicker.TabIndex = 11;
            this.toDateTimePicker.Value = new System.DateTime(2020, 10, 11, 0, 0, 0, 0);
            // 
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.Location = new System.Drawing.Point(13, 277);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(57, 17);
            this.budgetLabel.TabIndex = 14;
            this.budgetLabel.Text = "Budget:";
            // 
            // BudgetTextBox
            // 
            this.BudgetTextBox.Location = new System.Drawing.Point(129, 277);
            this.BudgetTextBox.Name = "BudgetTextBox";
            this.BudgetTextBox.Size = new System.Drawing.Size(100, 22);
            this.BudgetTextBox.TabIndex = 13;
            this.BudgetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BudgetTextBox_KeyPress);
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.Location = new System.Drawing.Point(0, 427);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(800, 23);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // feedbackTextBox
            // 
            this.feedbackTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feedbackTextBox.Location = new System.Drawing.Point(129, 305);
            this.feedbackTextBox.Multiline = true;
            this.feedbackTextBox.Name = "feedbackTextBox";
            this.feedbackTextBox.Size = new System.Drawing.Size(659, 93);
            this.feedbackTextBox.TabIndex = 33;
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(13, 305);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(119, 17);
            this.feedbackLabel.TabIndex = 32;
            this.feedbackLabel.Text = "Budget feedback:";
            // 
            // declineButton
            // 
            this.declineButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.declineButton.Location = new System.Drawing.Point(0, 404);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(800, 23);
            this.declineButton.TabIndex = 34;
            this.declineButton.Text = "Decline";
            this.declineButton.UseVisualStyleBackColor = true;
            this.declineButton.Click += new System.EventHandler(this.DeclineButton_Click);
            // 
            // ManageEventRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.declineButton);
            this.Controls.Add(this.feedbackTextBox);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.budgetLabel);
            this.Controls.Add(this.BudgetTextBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.attendeesNumericUpDown);
            this.Controls.Add(this.eventTypeLabel);
            this.Controls.Add(this.eventTypeTextBox);
            this.Controls.Add(this.clientListBox);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.attendeesLabel);
            this.Controls.Add(this.recordNrLabel);
            this.Controls.Add(this.recordNrTextBox);
            this.Name = "ManageEventRequestForm";
            this.Text = "Event Request";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateEventRequestForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendeesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox recordNrTextBox;
        private System.Windows.Forms.Label recordNrLabel;
        private System.Windows.Forms.Label attendeesLabel;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.ListBox clientListBox;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Label eventTypeLabel;
        private System.Windows.Forms.TextBox eventTypeTextBox;
        private System.Windows.Forms.NumericUpDown attendeesNumericUpDown;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Label budgetLabel;
        private System.Windows.Forms.TextBox BudgetTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox feedbackTextBox;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Button declineButton;
    }
}

