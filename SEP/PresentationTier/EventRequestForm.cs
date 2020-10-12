using BusinessTier;
using DataTier;
using System;
using System.Data;
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
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            EventRequestController eventRequestController = new EventRequestController();
            if (Session.UserSession.LoggedInUser.Permissions.Any(permission => permission == Permission.ApproveEventRequest))
            {
                requestDataGridView.DataSource = eventRequestController.EventRequests.Where(eventRequest => eventRequest.State == EventRequest.States.Created).ToList();
            }
            else if (Session.UserSession.LoggedInUser.Permissions.Any(permission => permission == Permission.EditEvent))
            {
                requestDataGridView.DataSource = eventRequestController.EventRequests.Where(eventRequest => eventRequest.State == EventRequest.States.ApprovedBySCSO).ToList();
            }
            else if (Session.UserSession.LoggedInUser.Permissions.Any(permission => permission == Permission.ApproveEvent))
            {
                requestDataGridView.DataSource = eventRequestController.EventRequests.Where(eventRequest => eventRequest.State == EventRequest.States.FinancialFeedbackAdded).ToList();
            }
            else
            {
                requestDataGridView.DataSource = null;
                requestDataGridView.Hide();
            }
        }

        private void EventRequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
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
    }
}
