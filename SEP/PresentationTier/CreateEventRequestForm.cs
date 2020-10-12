using BusinessTier;
using DataTier;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class CreateEventRequestForm : Form
    {
        private readonly Form mainForm;
        public CreateEventRequestForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            ClientController clientController = new ClientController();
            clientListBox.DataSource = clientController.Clients;
            clientListBox.DisplayMember = "FirstName";
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
            if(eventRequestController.Create(
                recordNrTextBox.Text,
                clientListBox.SelectedItem as Client,
                eventTypeTextBox.Text, fromDateTimePicker.Value,
                toDateTimePicker.Value,
                attendeesNumericUpDown.Value,
                BudgetTextBox.Text) != null)
            {
                saveButton.BackColor = Color.Green;
            }
            else
            {
                saveButton.BackColor = Color.Red;
            }
        }

        private void CreateEventRequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
