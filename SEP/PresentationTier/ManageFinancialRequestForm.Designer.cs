namespace PresentationTier
{
    partial class ManageFinancialRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageFinancialRequestForm));
            this.financialRadioButton = new System.Windows.Forms.RadioButton();
            this.serviceRadioButton = new System.Windows.Forms.RadioButton();
            this.productionRadioButton = new System.Windows.Forms.RadioButton();
            this.administrationRadioButton = new System.Windows.Forms.RadioButton();
            this.departmentGroupBox = new System.Windows.Forms.GroupBox();
            this.eventLabel = new System.Windows.Forms.Label();
            this.eventTextBox = new System.Windows.Forms.TextBox();
            this.ammountTextBox = new System.Windows.Forms.TextBox();
            this.ammountLabel = new System.Windows.Forms.Label();
            this.reasonTextBox = new System.Windows.Forms.TextBox();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.departmentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // financialRadioButton
            // 
            this.financialRadioButton.AutoSize = true;
            this.financialRadioButton.Location = new System.Drawing.Point(128, 67);
            this.financialRadioButton.Name = "financialRadioButton";
            this.financialRadioButton.Size = new System.Drawing.Size(85, 21);
            this.financialRadioButton.TabIndex = 14;
            this.financialRadioButton.TabStop = true;
            this.financialRadioButton.Text = "Financial";
            this.financialRadioButton.UseVisualStyleBackColor = true;
            // 
            // serviceRadioButton
            // 
            this.serviceRadioButton.AutoSize = true;
            this.serviceRadioButton.Location = new System.Drawing.Point(130, 40);
            this.serviceRadioButton.Name = "serviceRadioButton";
            this.serviceRadioButton.Size = new System.Drawing.Size(83, 21);
            this.serviceRadioButton.TabIndex = 13;
            this.serviceRadioButton.TabStop = true;
            this.serviceRadioButton.Text = "Services";
            this.serviceRadioButton.UseVisualStyleBackColor = true;
            // 
            // productionRadioButton
            // 
            this.productionRadioButton.AutoSize = true;
            this.productionRadioButton.Location = new System.Drawing.Point(6, 67);
            this.productionRadioButton.Name = "productionRadioButton";
            this.productionRadioButton.Size = new System.Drawing.Size(97, 21);
            this.productionRadioButton.TabIndex = 12;
            this.productionRadioButton.TabStop = true;
            this.productionRadioButton.Text = "Production";
            this.productionRadioButton.UseVisualStyleBackColor = true;
            // 
            // administrationRadioButton
            // 
            this.administrationRadioButton.AutoSize = true;
            this.administrationRadioButton.Checked = true;
            this.administrationRadioButton.Location = new System.Drawing.Point(6, 40);
            this.administrationRadioButton.Name = "administrationRadioButton";
            this.administrationRadioButton.Size = new System.Drawing.Size(118, 21);
            this.administrationRadioButton.TabIndex = 11;
            this.administrationRadioButton.TabStop = true;
            this.administrationRadioButton.Text = "Administration";
            this.administrationRadioButton.UseVisualStyleBackColor = true;
            // 
            // departmentGroupBox
            // 
            this.departmentGroupBox.Controls.Add(this.serviceRadioButton);
            this.departmentGroupBox.Controls.Add(this.financialRadioButton);
            this.departmentGroupBox.Controls.Add(this.administrationRadioButton);
            this.departmentGroupBox.Controls.Add(this.productionRadioButton);
            this.departmentGroupBox.Location = new System.Drawing.Point(12, 12);
            this.departmentGroupBox.Name = "departmentGroupBox";
            this.departmentGroupBox.Size = new System.Drawing.Size(236, 104);
            this.departmentGroupBox.TabIndex = 15;
            this.departmentGroupBox.TabStop = false;
            this.departmentGroupBox.Text = "Department";
            // 
            // eventLabel
            // 
            this.eventLabel.AutoSize = true;
            this.eventLabel.Location = new System.Drawing.Point(12, 123);
            this.eventLabel.Name = "eventLabel";
            this.eventLabel.Size = new System.Drawing.Size(89, 17);
            this.eventLabel.TabIndex = 16;
            this.eventLabel.Text = "reference to:";
            // 
            // eventTextBox
            // 
            this.eventTextBox.Enabled = false;
            this.eventTextBox.Location = new System.Drawing.Point(108, 123);
            this.eventTextBox.Name = "eventTextBox";
            this.eventTextBox.Size = new System.Drawing.Size(140, 22);
            this.eventTextBox.TabIndex = 17;
            // 
            // ammountTextBox
            // 
            this.ammountTextBox.Location = new System.Drawing.Point(108, 151);
            this.ammountTextBox.Name = "ammountTextBox";
            this.ammountTextBox.Size = new System.Drawing.Size(140, 22);
            this.ammountTextBox.TabIndex = 19;
            this.ammountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmmountTextBox_KeyPress);
            // 
            // ammountLabel
            // 
            this.ammountLabel.AutoSize = true;
            this.ammountLabel.Location = new System.Drawing.Point(12, 151);
            this.ammountLabel.Name = "ammountLabel";
            this.ammountLabel.Size = new System.Drawing.Size(71, 17);
            this.ammountLabel.TabIndex = 18;
            this.ammountLabel.Text = "Ammount:";
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reasonTextBox.Location = new System.Drawing.Point(108, 179);
            this.reasonTextBox.Multiline = true;
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(680, 242);
            this.reasonTextBox.TabIndex = 21;
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Location = new System.Drawing.Point(12, 179);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(61, 17);
            this.reasonLabel.TabIndex = 20;
            this.reasonLabel.Text = "Reason:";
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.Location = new System.Drawing.Point(0, 427);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(800, 23);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ManageFinancialRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.reasonTextBox);
            this.Controls.Add(this.reasonLabel);
            this.Controls.Add(this.ammountTextBox);
            this.Controls.Add(this.ammountLabel);
            this.Controls.Add(this.eventTextBox);
            this.Controls.Add(this.eventLabel);
            this.Controls.Add(this.departmentGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageFinancialRequestForm";
            this.Text = "Financial Request";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FinancialRequestForm_FormClosed);
            this.departmentGroupBox.ResumeLayout(false);
            this.departmentGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton financialRadioButton;
        private System.Windows.Forms.RadioButton serviceRadioButton;
        private System.Windows.Forms.RadioButton productionRadioButton;
        private System.Windows.Forms.RadioButton administrationRadioButton;
        private System.Windows.Forms.GroupBox departmentGroupBox;
        private System.Windows.Forms.Label eventLabel;
        private System.Windows.Forms.TextBox eventTextBox;
        private System.Windows.Forms.TextBox ammountTextBox;
        private System.Windows.Forms.Label ammountLabel;
        private System.Windows.Forms.TextBox reasonTextBox;
        private System.Windows.Forms.Label reasonLabel;
        private System.Windows.Forms.Button saveButton;
    }
}