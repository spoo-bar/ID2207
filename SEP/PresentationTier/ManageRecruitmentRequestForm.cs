using BusinessTier;
using DataTier;
using System;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class ManageRecruitmentRequestForm : Form
    {
        private readonly RecruitmentForm mainForm;
        public ManageRecruitmentRequestForm(RecruitmentForm mainForm)
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

            recruitmentRequestController.Create(contractType, requestingDepartment, yearsOfExperience, jobTitle, jobDescription, Session.UserSession.LoggedInUser);
            this.Close();
            mainForm.SetRecruitmentRequests();
            mainForm.Show();
        }

        private void RecruitmentRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void YearsOfExpText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
