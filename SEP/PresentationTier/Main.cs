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
            if (loginForm.ShowDialog(this) == DialogResult.OK)
            {
                SetLoginInUserLabel();
                DisableButtonsWithoutPermission();
            }
            else
            {
                MessageBox.Show("Login Necessary", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowLogin();
            }
        }

        private void SetLoginInUserLabel()
        {
            loggedinUserLabel.Text =  "Logged In : " + Session.UserSession.LoggedInUser.Email;
            loggedinUserLabel.Refresh();
        }

        private void DisableButtonsWithoutPermission()
        {
            //todo: could be placed in designer
            this.eventRequestButton.Enabled = false;
            this.createClientButton.Enabled = false;
            this.staffButton.Enabled = false;
            this.eventButton.Enabled = false;
            this.assignmentButton.Enabled = false;
            this.recruitmentButton.Enabled = false;

            var userRole = Session.UserSession.LoggedInUser.Role;
            switch (userRole)
            {
                case DataTier.Role.AdministrationDepartmentManager:
                    this.eventRequestButton.Enabled = true;
                    this.recruitmentButton.Enabled = true;
                    break;
                case DataTier.Role.SeniorCustomerServiceOfficer:
                    this.eventRequestButton.Enabled = true;
                    this.eventButton.Enabled = true;
                    break;
                case DataTier.Role.CustomerService:
                    this.eventRequestButton.Enabled = true;
                    this.createClientButton.Enabled = true;
                    break;
                case DataTier.Role.FinancialManager:
                    this.eventRequestButton.Enabled = true;
                    this.eventButton.Enabled = true;
                    this.recruitmentButton.Enabled = false;
                    break;
                case DataTier.Role.ProductionManager:
                    this.eventButton.Enabled = true;
                    this.assignmentButton.Enabled = true;
                    break;
                case DataTier.Role.Photographer:
                    this.assignmentButton.Enabled = true;
                    break;
                case DataTier.Role.GraphicDesigner:
                    this.assignmentButton.Enabled = true;
                    break;
                case DataTier.Role.ServicesDepartmentManager:
                    this.assignmentButton.Enabled = true;
                    this.eventButton.Enabled = true;
                    break;
                case DataTier.Role.TopChef:
                    this.assignmentButton.Enabled = true;
                    break;
                case DataTier.Role.SeniorWaitress:
                    this.assignmentButton.Enabled = true;
                    break;
                case DataTier.Role.SeniorHRManager:
                    this.createClientButton.Enabled = true;
                    this.staffButton.Enabled = true;
                    this.recruitmentButton.Enabled = true;
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

        private void recruitmentButton_Click(object sender, EventArgs e)
        {
            new ManageRecruitmentForm(this).Show();
            this.Hide();
        }

        private void financialRequestButton_Click(object sender, EventArgs e)
        {
            new FinancialRequestForm(this).Show();
            this.Hide();
        }
    }
}
