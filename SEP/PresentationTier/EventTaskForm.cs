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
    public partial class EventTaskForm : Form
    {
        private readonly ManageEventForm mainForm;
        public EventTaskForm(ManageEventForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            var subordinates = Session.UserSession.LoggedInUser.Subordinates;
            this.assignedTo_Combo.DataSource = subordinates;
            this.assignedTo_Combo.DisplayMember = "Email";
            this.assignedTo_Combo.ValueMember = "Email";
        }

        private void createTask_Button_Click(object sender, EventArgs e)
        {
            var eventTask = new EventTask()
            {
                Description = this.descriptionText.Text,
                AssignedTo = (User)this.assignedTo_Combo.SelectedItem
            };
            var eventController = new EventController();
            eventController.CreateTask(this.mainForm.eventRecordNumber, eventTask);
            mainForm.RefreshTasks();
            this.Hide();
        }

        private void EventTaskForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
