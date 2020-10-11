using BusinessTier;
using System;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class ClientForm : Form
    {
        private ClientController clientController;

        public ClientForm()
        {
            InitializeComponent();
            clientController = new ClientController();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            clientController.Create(firstNameTextBox.Text, lastNameTextBox.Text, phoneNrTextBox.Text);
        }
    }
}
