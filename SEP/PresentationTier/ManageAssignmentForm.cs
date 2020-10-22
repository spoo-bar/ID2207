using DataTier;
using System;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class ManageAssignmentForm : Form
    {
        private readonly Form mainForm;
        private readonly EventTask eventTask;

        public ManageAssignmentForm(Form mainForm, EventTask eventTask)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.eventTask = eventTask;

            planTextBox.Text = eventTask.Plan;

            Refresh();
        }

        private void Refresh()
        {
            commentDataGridView.Rows.Clear();
            foreach (TaskComment comment in eventTask.TaskComments)
            {
                commentDataGridView.Rows.Add(comment.Comment, comment.CommentBy.Email);
            }
        }

        private void AssignmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            eventTask.Plan = planTextBox.Text;
            foreach(DataGridViewRow row in commentDataGridView.Rows)
            {
                if(row.Cells[1].Value == null && row.Cells[0].Value != null)
                {
                    eventTask.TaskComments.Add(new TaskComment(row.Cells[0].Value.ToString(), Session.UserSession.LoggedInUser));
                }
            }
            Refresh();
        }
    }
}
