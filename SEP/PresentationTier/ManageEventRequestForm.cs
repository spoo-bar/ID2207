using BusinessTier;
using DataTier;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class ManageEventRequestForm : Form
    {
        private readonly Form mainForm;
        private readonly EventRequest eventRequest = null;

        public ManageEventRequestForm(Form mainForm)// create new event request
        {
            InitializeComponent();

            this.mainForm = mainForm;

            ClientController clientController = new ClientController();
            clientListBox.DataSource = clientController.Clients;
            clientListBox.DisplayMember = "FirstName";

            feedbackLabel.Hide();
            feedbackTextBox.Hide();
        }

        public ManageEventRequestForm(Form mainForm, EventRequest eventRequest) // working with existing request
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.eventRequest = eventRequest;

            #region fill info
            recordNrTextBox.Text = eventRequest.RecordNr;
            clientListBox.Items.Add(eventRequest.Client.FirstName);
            eventTypeTextBox.Text = eventRequest.EventType;
            fromDateTimePicker.Value = eventRequest.From;
            toDateTimePicker.Value = eventRequest.To;
            attendeesNumericUpDown.Text = eventRequest.Attendees.ToString();
            BudgetTextBox.Text = eventRequest.Budget.ToString();
            feedbackTextBox.Text = eventRequest.FinancialFeedback;

            recordNrTextBox.Enabled = false;
            clientListBox.Enabled = false;
            eventTypeTextBox.Enabled = false;
            fromDateTimePicker.Enabled = false;
            toDateTimePicker.Enabled = false;
            attendeesNumericUpDown.Enabled = false;
            BudgetTextBox.Enabled = false;
            #endregion

            if (eventRequest.State == EventRequest.States.Finalized)
            {
                feedbackTextBox.Enabled = false;
                saveButton.Hide();
            }
            else if (Session.UserSession.LoggedInUser.Role == User.Roles.SeniorCustomerServiceOfficer || Session.UserSession.LoggedInUser.Role == User.Roles.AdministrationDepartmentManager)
            {//if cannot edit can only approve
                feedbackTextBox.Enabled = false;
                saveButton.Text = "Approve";
            }
        }

        private void BudgetTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            EventRequestController eventRequestController = new EventRequestController();
            bool result;
            if (eventRequest == null)
            {
                result = (eventRequestController.Create(
                    recordNrTextBox.Text,
                    clientListBox.SelectedItem as Client,
                    eventTypeTextBox.Text, fromDateTimePicker.Value,
                    toDateTimePicker.Value,
                    attendeesNumericUpDown.Value,
                    BudgetTextBox.Text) != null);
            }
            else
            {
                result = eventRequestController.ChangeState(eventRequest, Session.UserSession.LoggedInUser.Role, feedbackTextBox.Text);
            }

            if (result)
            {
                this.Close();
            }
            else
            {
                //failed to do the operation
                saveButton.BackColor = Color.Red;
            }
        }

        private void CreateEventRequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
