namespace PresentationTier
{
    partial class EventTaskForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.assignedTo_Combo = new System.Windows.Forms.ComboBox();
            this.createTask_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assigned To";
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(124, 33);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(621, 340);
            this.descriptionText.TabIndex = 2;
            // 
            // assignedTo_Combo
            // 
            this.assignedTo_Combo.FormattingEnabled = true;
            this.assignedTo_Combo.Location = new System.Drawing.Point(124, 379);
            this.assignedTo_Combo.Name = "assignedTo_Combo";
            this.assignedTo_Combo.Size = new System.Drawing.Size(121, 24);
            this.assignedTo_Combo.TabIndex = 3;
            // 
            // createTask_Button
            // 
            this.createTask_Button.Location = new System.Drawing.Point(26, 415);
            this.createTask_Button.Name = "createTask_Button";
            this.createTask_Button.Size = new System.Drawing.Size(75, 23);
            this.createTask_Button.TabIndex = 4;
            this.createTask_Button.Text = "Create ";
            this.createTask_Button.UseVisualStyleBackColor = true;
            this.createTask_Button.Click += new System.EventHandler(this.CreateTask_Button_Click);
            // 
            // EventTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createTask_Button);
            this.Controls.Add(this.assignedTo_Combo);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EventTaskForm";
            this.Text = "EventTaskForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EventTaskForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.ComboBox assignedTo_Combo;
        private System.Windows.Forms.Button createTask_Button;
    }
}