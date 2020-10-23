using DataTier;
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
                case User.Roles.AdministrationDepartmentManager:
                    eventRequestButton.Enabled = true;
                    recruitmentButton.Enabled = true;
                    break;
                case User.Roles.SeniorCustomerServiceOfficer:
                    eventRequestButton.Enabled = true;
                    eventButton.Enabled = true;
                    break;
                case User.Roles.CustomerService:
                    eventRequestButton.Enabled = true;
                    createClientButton.Enabled = true;
                    break;
                case User.Roles.FinancialManager:
                    eventRequestButton.Enabled = true;
                    eventButton.Enabled = true;
                    recruitmentButton.Enabled = true;
                    financialRequestButton.Enabled = true;
                    break;
                case User.Roles.ProductionManager:
                    eventButton.Enabled = true;
                    assignmentButton.Enabled = true;
                    break;
                case User.Roles.Photographer:
                    assignmentButton.Enabled = true;
                    break;
                case User.Roles.GraphicDesigner:
                    assignmentButton.Enabled = true;
                    break;
                case User.Roles.ServicesDepartmentManager:
                    assignmentButton.Enabled = true;
                    eventButton.Enabled = true;
                    break;
                case User.Roles.TopChef:
                    assignmentButton.Enabled = true;
                    break;
                case User.Roles.SeniorWaitress:
                    assignmentButton.Enabled = true;
                    break;
                case User.Roles.SeniorHRManager:
                    createClientButton.Enabled = true;
                    staffButton.Enabled = true;
                    recruitmentButton.Enabled = true;
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
