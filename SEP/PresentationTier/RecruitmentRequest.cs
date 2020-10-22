﻿using BusinessTier;
using DataTier;
using System;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class RecruitmentRequest : Form
    {
        private readonly Form mainForm;
        public RecruitmentRequest(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void CreateRecruitmentButton_Click(object sender, EventArgs e)
        {
            var recruitmentRequestController = new RecruitmentRequestController();
            var contractType = fulltimeRadioButton.Checked ? Contractype.FullTime : Contractype.PartTime;
            var requestingDepartment = administrationRadioButton.Checked ? RequestingDepartment.Administration :
                serviceRadioButton.Checked ? RequestingDepartment.Service :
                productionRadioButton.Checked ? RequestingDepartment.Production : RequestingDepartment.Financial;

            var yearsOfExperience = yearsOfExpText.Text;
            var jobTitle = jobTitleText.Text;
            var jobDescription = jobDescText.Text;

            recruitmentRequestController.Create(contractType, requestingDepartment, yearsOfExperience, jobTitle, jobDescription);
            this.Close();
            mainForm.Show();
        }

        private void RecruitmentRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}