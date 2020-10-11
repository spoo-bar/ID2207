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
    }
}
