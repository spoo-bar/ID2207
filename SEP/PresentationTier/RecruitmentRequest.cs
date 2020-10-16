using BusinessTier;
using DataTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void createRecruitmentButton_Click(object sender, EventArgs e)
        {
            var recruitmentRequestController = new RecruitmentRequestController();
            var contractType = this.fulltimeRadioButton.Checked ? Contractype.FullTime : Contractype.PartTime;
            var requestingDepartment = this.administrationRadioButton.Checked ? RequestingDepartment.Administration :
                this.serviceRadioButton.Checked ? RequestingDepartment.Service :
                this.productionRadioButton.Checked ? RequestingDepartment.Production : RequestingDepartment.Financial;
            var yearsOfExperience = this.yearsOfExpText.Text;
            var jobTitle = this.jobTitleText.Text;
            var jobDescription = this.jobDescText.Text;

            var recruitmentRest = recruitmentRequestController.Create(contractType, requestingDepartment, yearsOfExperience, jobTitle, jobDescription);
            this.Close();
            mainForm.Show();
        }

        private void RecruitmentRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
