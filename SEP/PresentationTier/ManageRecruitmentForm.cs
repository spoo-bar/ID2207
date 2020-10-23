using BusinessTier;
using System;
using System.Collections.Generic;
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
            var recruitmentsRequests = getRecruitmentRequests();
            this.recruitmentRequestDataGrid.DataSource = recruitmentsRequests;
        }

        private static List<DataTier.RecruitmentRequest> getRecruitmentRequests()
        {
            var recruitmentsRequestController = new RecruitmentRequestController();
            var recruitmentsRequests = recruitmentsRequestController.GetRecruitmentRequests();
            return recruitmentsRequests;
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

        public void RefreshRecruitmentDatagrid()
        {
            this.recruitmentRequestDataGrid.DataSource = null;
            this.recruitmentRequestDataGrid.DataSource = getRecruitmentRequests();
        }
    }
}
