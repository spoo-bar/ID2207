using BusinessTier;
using System;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class ClientForm : Form
    {
        private readonly Form mainForm;

        public ClientForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ClientController clientController = new ClientController();
            clientController.Create(firstNameTextBox.Text, lastNameTextBox.Text, phoneNrTextBox.Text);
            this.Close();
        }

        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
