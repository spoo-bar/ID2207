using BusinessTier;
using DataTier;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class EventRequestForm : Form
    {
        private readonly Form mainForm;

        public EventRequestForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            EventRequestController eventRequestController = new EventRequestController();
            requestDataGridView.DataSource = eventRequestController.GetEventRequests(Session.UserSession.LoggedInUser.Role);

            if(Session.UserSession.LoggedInUser.Role != Role.CustomerService)
            {
                createEventRequestButton.Visible = false;
            }
        }

        private void RequestDataGridView_DoubleClick(object sender, EventArgs e)
        {
            EventRequest selected = (EventRequest)requestDataGridView.CurrentRow.DataBoundItem;
            new ManageEventRequestForm(this, selected).Show();
            this.Hide();
        }

        private void CreateEventRequestButton_Click(object sender, EventArgs e)
        {
            new ManageEventRequestForm(this).Show();
            this.Hide();
        }

        private void EventRequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
