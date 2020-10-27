using BusinessTier;
using DataTier;
using System;
using System.Drawing;
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

            SetEventRequests();
        }

        public void SetEventRequests()
        {
            requestDataGridView.DataSource = null;
            EventRequestController eventRequestController = new EventRequestController();
            requestDataGridView.DataSource = eventRequestController.GetEventRequests(Session.UserSession.LoggedInUser.Role);

            if (Session.UserSession.LoggedInUser.Role != User.Roles.CustomerService)
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

        private void RequestDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (Session.UserSession.LoggedInUser.Role != User.Roles.FinancialManager && e.ColumnIndex == requestDataGridView.Columns[6].Index)
                {
                    if ((EventRequest.States)e.Value == EventRequest.States.Finalized)
                    {
                        requestDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                    }
                }
            }
            catch (Exception) { }
        }
    }
}
