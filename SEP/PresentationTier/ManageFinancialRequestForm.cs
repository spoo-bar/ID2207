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
        private readonly FinancialRequestController financialRequestController = new FinancialRequestController();

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
            financialRequestController.AddFinancialRequest(requestingDepartment, requestEvent, ammountTextBox.Text, reasonTextBox.Text);
            this.Close();
        }
    }
}
