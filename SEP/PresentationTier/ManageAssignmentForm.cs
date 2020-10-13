using BusinessTier;
using DataTier;
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
    public partial class ManageAssignmentForm : Form
    {
        private readonly Form mainForm;
        private EventTask eventTask;

        public ManageAssignmentForm(Form mainForm, EventTask eventTask)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.eventTask = eventTask;

            planTextBox.Text = eventTask.Plan;
            commentDataGridView.DataSource = eventTask.TaskComments;

            //todo:comment later
        }

        private void AssignmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            eventTask.Plan = planTextBox.Text;
        }
    }
}
