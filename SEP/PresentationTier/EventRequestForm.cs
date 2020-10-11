using BusinessTier;
using DataTier;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class EventRequestForm : Form
    {
        public EventRequestForm()
        {
            InitializeComponent();
            ClientController clientController = new ClientController();
            //todo: remove when can move between forms
            clientController.Create("testName", "testSurname", "testPhone");

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
    }
}
