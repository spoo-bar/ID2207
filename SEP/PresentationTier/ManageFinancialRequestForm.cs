using BusinessTier;
using DataTier;
using System;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class ManageFinancialRequestForm : Form
    {
        private readonly Form mainForm;
        private readonly Event requestEvent;

        public ManageFinancialRequestForm(Form mainForm, Event requestEvent)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.requestEvent = requestEvent;

            eventTextBox.Text = requestEvent.RecordNr;
        }

        private void FinancialRequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var requestingDepartment = administrationRadioButton.Checked ? RequestingDepartment.Administration :
                serviceRadioButton.Checked ? RequestingDepartment.Service :
                productionRadioButton.Checked ? RequestingDepartment.Production : RequestingDepartment.Financial;

            FinancialRequestController financialRequestController = new FinancialRequestController();
            financialRequestController.AddFinancialRequest(requestingDepartment, requestEvent, ammountTextBox.Text, reasonTextBox.Text, Session.UserSession.LoggedInUser);
            this.Close();
        }

        private void AmmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
