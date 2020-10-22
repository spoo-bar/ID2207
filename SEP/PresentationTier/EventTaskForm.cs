using BusinessTier;
using DataTier;
using System;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class EventTaskForm : Form
    {
        private readonly ManageEventForm mainForm;
        private readonly Event evnt;
        public EventTaskForm(ManageEventForm mainForm, Event ev)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            evnt = ev;

            this.assignedTo_Combo.DataSource = Session.UserSession.LoggedInUser.Subordinates;
            this.assignedTo_Combo.DisplayMember = "Email";
        }

        private void CreateTask_Button_Click(object sender, EventArgs e)
        {
            var eventTask = new EventTask()
            {
                Description = this.descriptionText.Text,
                AssignedTo = (User)this.assignedTo_Combo.SelectedItem
            };
            var eventController = new EventController();
            eventController.CreateTask(evnt.RecordNr, eventTask);
            mainForm.RefreshTasks();
            this.Hide();
        }

        private void EventTaskForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
            mainForm.RefreshTasks();
        }
    }
}
