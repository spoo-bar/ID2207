using System;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            if (Session.UserSession.LoggedInUser == null)
            {
                ShowLogin();
            }
            else
            {
                SetLoginInUserLabel();
            }
        }

        private void ShowLogin()
        {
            var loginForm = new LoginForm();
            switch (loginForm.ShowDialog(this))
            {
                case DialogResult.OK:
                    SetLoginInUserLabel();
                    DisableButtonsWithoutPermission();
                    break;
                case DialogResult.Cancel:
                    this.Close();
                    break;
                default:
                    MessageBox.Show("Login Necessary", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShowLogin();
                    break;
            }
        }

        private void SetLoginInUserLabel()
        {
            loggedinUserLabel.Text =  "Logged In : " + Session.UserSession.LoggedInUser.Email;
            loggedinUserLabel.Refresh();
        }

        private void DisableButtonsWithoutPermission()
        {
            var userRole = Session.UserSession.LoggedInUser.Role;
            switch (userRole)
            {
                case DataTier.Role.AdministrationDepartmentManager:
                    eventRequestButton.Enabled = true;
                    recruitmentButton.Enabled = false;
                    break;
                case DataTier.Role.SeniorCustomerServiceOfficer:
                    eventRequestButton.Enabled = true;
                    eventButton.Enabled = true;
                    break;
                case DataTier.Role.CustomerService:
                    eventRequestButton.Enabled = true;
                    createClientButton.Enabled = true;
                    break;
                case DataTier.Role.FinancialManager:
                    eventRequestButton.Enabled = true;
                    eventButton.Enabled = true;
                    recruitmentButton.Enabled = false;
                    financialRequestButton.Enabled = true;
                    break;
                case DataTier.Role.ProductionManager:
                    eventButton.Enabled = true;
                    assignmentButton.Enabled = true;
                    break;
                case DataTier.Role.Photographer:
                    assignmentButton.Enabled = true;
                    break;
                case DataTier.Role.GraphicDesigner:
                    assignmentButton.Enabled = true;
                    break;
                case DataTier.Role.ServicesDepartmentManager:
                    assignmentButton.Enabled = true;
                    eventButton.Enabled = true;
                    break;
                case DataTier.Role.TopChef:
                    assignmentButton.Enabled = true;
                    break;
                case DataTier.Role.SeniorWaitress:
                    assignmentButton.Enabled = true;
                    break;
                case DataTier.Role.SeniorHRManager:
                    createClientButton.Enabled = true;
                    staffButton.Enabled = true;
                    recruitmentButton.Enabled = false;
                    break;
            }
        }

        private void EventRequestButton_Click(object sender, EventArgs e)
        {
            new EventRequestForm(this).Show();
            this.Hide();
        }

        private void CreateClientButton_Click(object sender, EventArgs e)
        {
            new ClientForm(this).Show();
            this.Hide();
        }

        private void StaffButton_Click(object sender, EventArgs e)
        {
            new StaffAvailabilityForm(this).Show();
            this.Hide();
        }

        private void EventButton_Click(object sender, EventArgs e)
        {
            new EventForm(this).Show();
            this.Hide();
        }

        private void AssignmentButton_Click(object sender, EventArgs e)
        {
            new AssignmentForm(this).Show();
            this.Hide();
        }

        private void RecruitmentButton_Click(object sender, EventArgs e)
        {
            new ManageRecruitmentForm(this).Show();
            this.Hide();
        }

        private void FinancialRequestButton_Click(object sender, EventArgs e)
        {
            new FinancialRequestForm(this).Show();
            this.Hide();
        }
    }
}
