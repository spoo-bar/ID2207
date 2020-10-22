using BusinessTier;
using System;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class ManageRecruitmentForm : Form
    {
        private readonly Form mainForm;
        public ManageRecruitmentForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            var recruitmentsRequestController = new RecruitmentRequestController();
            var recruitmentsRequests = recruitmentsRequestController.GetRecruitmentRequests();
            this.recruitmentRequestDataGrid.DataSource = recruitmentsRequests;
        }

        private void ManageRecruitmentRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void CreateRecruitmentRequestButton_Click(object sender, EventArgs e)
        {
            new RecruitmentRequest(this).Show();
            this.Hide();
        }
    }
}
