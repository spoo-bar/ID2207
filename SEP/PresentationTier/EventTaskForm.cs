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

            var eventController = new EventController();
            this.assignedTo_Combo.DataSource = eventController.GetAvailableUsers(Session.UserSession.LoggedInUser.Subordinates, ev.From, ev.To);
            this.assignedTo_Combo.DisplayMember = "Email";
        }

        private void CreateTask_Button_Click(object sender, EventArgs e)
        {
            User user = (User)this.assignedTo_Combo.SelectedItem;
            if (user != null)
            {
                var eventTask = new EventTask(this.descriptionText.Text, user);
                var eventController = new EventController();
                eventController.CreateTask(evnt.RecordNr, eventTask);
                mainForm.RefreshTasks();
                this.Hide();
            }
        }

        private void EventTaskForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
            mainForm.RefreshTasks();
        }
    }
}
