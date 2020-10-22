using BusinessTier;
using DataTier;
using System;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class AssignmentForm : Form
    {
        private readonly Form mainForm;

        public AssignmentForm(Form mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            EventController eventController = new EventController();
            assignmentDataGridView.DataSource = eventController.GetTasks(Session.UserSession.LoggedInUser);
        }

        private void AssignmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void AssignmentDataGridView_DoubleClick(object sender, EventArgs e)
        {
            EventTask selected = (EventTask)assignmentDataGridView.CurrentRow.DataBoundItem;
            new ManageAssignmentForm(this, selected).Show();
            this.Hide();
        }
    }
}
