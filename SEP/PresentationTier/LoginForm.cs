using BusinessTier;
using BusinessTier.Exceptions;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var email = this.emailTextbox.Text;
            var password = this.passwordTextBox.Text;

            if(IsValidEmail(email))
            {
                var loginController = new LoginController();
                try
                {
                    var user = loginController.Login(email, password);
                    MessageBox.Show("Login Successfull!", "Login", MessageBoxButtons.OK);
                    Session.UserSession.LoggedInUser = user;
                    this.DialogResult = DialogResult.OK;
                }
                catch(LoginException exception)
                {
                    MessageBox.Show(exception.Message, "Login", MessageBoxButtons.OK);
                }                                
            }
            else
            {
                MessageBox.Show("Invalid email!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                        
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var mail = new MailAddress(email);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
