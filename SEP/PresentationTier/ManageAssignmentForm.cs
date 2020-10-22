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
            commentDataGridView.DataSource = eventTask.TaskComments;
        }

        private void AssignmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            eventTask.Plan = planTextBox.Text;
        }
    }
}
