using BusinessTier;
using DataTier;
using System;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class FinancialFeedbackForm : Form
    {
        private readonly Form mainForm;
        private EventRequest eventRequest;

        public FinancialFeedbackForm(Form mainForm, EventRequest eventRequest)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            this.eventRequest = eventRequest;
            recordNrTextBox.Text = eventRequest.RecordNr;
            clientTextBox.Text = eventRequest.Client.FirstName;
            eventTypeTextBox.Text = eventRequest.EventType;
            fromDateTimePicker.Value = eventRequest.From;
            toDateTimePicker.Value = eventRequest.To;
            attendeesTextBox.Text = eventRequest.Attendees.ToString();
            BudgetTextBox.Text = eventRequest.Budget.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            EventRequestController eventRequestController = new EventRequestController();
            eventRequestController.AddFeedback(feedbackTextBox.Text, eventRequest);
        }

        private void FinancialFeedbackForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
