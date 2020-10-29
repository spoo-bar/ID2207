using System;

namespace PresentationTier
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.loggedinUserLabel = new System.Windows.Forms.Label();
            this.eventRequestButton = new System.Windows.Forms.Button();
            this.createClientButton = new System.Windows.Forms.Button();
            this.staffButton = new System.Windows.Forms.Button();
            this.eventButton = new System.Windows.Forms.Button();
            this.assignmentButton = new System.Windows.Forms.Button();
            this.recruitmentButton = new System.Windows.Forms.Button();
            this.financialRequestButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loggedinUserLabel
            // 
            this.loggedinUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loggedinUserLabel.AutoSize = true;
            this.loggedinUserLabel.Location = new System.Drawing.Point(524, 9);
            this.loggedinUserLabel.Name = "loggedinUserLabel";
            this.loggedinUserLabel.Size = new System.Drawing.Size(127, 17);
            this.loggedinUserLabel.TabIndex = 0;
            this.loggedinUserLabel.Text = "loggedinUserLabel";
            // 
            // eventRequestButton
            // 
            this.eventRequestButton.Enabled = false;
            this.eventRequestButton.Location = new System.Drawing.Point(12, 12);
            this.eventRequestButton.Name = "eventRequestButton";
            this.eventRequestButton.Size = new System.Drawing.Size(200, 23);
            this.eventRequestButton.TabIndex = 6;
            this.eventRequestButton.Text = "event requests";
            this.eventRequestButton.UseVisualStyleBackColor = true;
            this.eventRequestButton.Click += new System.EventHandler(this.EventRequestButton_Click);
            // 
            // createClientButton
            // 
            this.createClientButton.Enabled = false;
            this.createClientButton.Location = new System.Drawing.Point(12, 41);
            this.createClientButton.Name = "createClientButton";
            this.createClientButton.Size = new System.Drawing.Size(200, 23);
            this.createClientButton.TabIndex = 6;
            this.createClientButton.Text = "Create client";
            this.createClientButton.UseVisualStyleBackColor = true;
            this.createClientButton.Click += new System.EventHandler(this.CreateClientButton_Click);
            // 
            // staffButton
            // 
            this.staffButton.Enabled = false;
            this.staffButton.Location = new System.Drawing.Point(12, 70);
            this.staffButton.Name = "staffButton";
            this.staffButton.Size = new System.Drawing.Size(200, 23);
            this.staffButton.TabIndex = 6;
            this.staffButton.Text = "Review staff";
            this.staffButton.UseVisualStyleBackColor = true;
            this.staffButton.Click += new System.EventHandler(this.StaffButton_Click);
            // 
            // eventButton
            // 
            this.eventButton.Enabled = false;
            this.eventButton.Location = new System.Drawing.Point(12, 99);
            this.eventButton.Name = "eventButton";
            this.eventButton.Size = new System.Drawing.Size(200, 23);
            this.eventButton.TabIndex = 6;
            this.eventButton.Text = "Event";
            this.eventButton.UseVisualStyleBackColor = true;
            this.eventButton.Click += new System.EventHandler(this.EventButton_Click);
            // 
            // assignmentButton
            // 
            this.assignmentButton.Enabled = false;
            this.assignmentButton.Location = new System.Drawing.Point(12, 128);
            this.assignmentButton.Name = "assignmentButton";
            this.assignmentButton.Size = new System.Drawing.Size(200, 23);
            this.assignmentButton.TabIndex = 7;
            this.assignmentButton.Text = "Assignment";
            this.assignmentButton.UseVisualStyleBackColor = true;
            this.assignmentButton.Click += new System.EventHandler(this.AssignmentButton_Click);
            // 
            // recruitmentButton
            // 
            this.recruitmentButton.Enabled = false;
            this.recruitmentButton.Location = new System.Drawing.Point(12, 157);
            this.recruitmentButton.Name = "recruitmentButton";
            this.recruitmentButton.Size = new System.Drawing.Size(200, 23);
            this.recruitmentButton.TabIndex = 8;
            this.recruitmentButton.Text = "Recruitment";
            this.recruitmentButton.UseVisualStyleBackColor = true;
            this.recruitmentButton.Click += new System.EventHandler(this.RecruitmentButton_Click);
            // 
            // financialRequestButton
            // 
            this.financialRequestButton.Enabled = false;
            this.financialRequestButton.Location = new System.Drawing.Point(12, 186);
            this.financialRequestButton.Name = "financialRequestButton";
            this.financialRequestButton.Size = new System.Drawing.Size(200, 23);
            this.financialRequestButton.TabIndex = 9;
            this.financialRequestButton.Text = "Financial requests";
            this.financialRequestButton.UseVisualStyleBackColor = true;
            this.financialRequestButton.Click += new System.EventHandler(this.FinancialRequestButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.Location = new System.Drawing.Point(713, 6);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 10;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.financialRequestButton);
            this.Controls.Add(this.recruitmentButton);
            this.Controls.Add(this.assignmentButton);
            this.Controls.Add(this.loggedinUserLabel);
            this.Controls.Add(this.eventRequestButton);
            this.Controls.Add(this.createClientButton);
            this.Controls.Add(this.staffButton);
            this.Controls.Add(this.eventButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label loggedinUserLabel;
        private System.Windows.Forms.Button eventRequestButton;
        private System.Windows.Forms.Button createClientButton;
        private System.Windows.Forms.Button staffButton;
        private System.Windows.Forms.Button eventButton;
        private System.Windows.Forms.Button assignmentButton;
        private System.Windows.Forms.Button recruitmentButton;
        private System.Windows.Forms.Button financialRequestButton;
        private System.Windows.Forms.Button logoutButton;
    }
}