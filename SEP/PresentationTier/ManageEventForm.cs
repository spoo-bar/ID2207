using DataTier;
using System;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class ManageEventForm : Form
    {
        private readonly Form mainForm;
        private readonly Event evnt;

        public ManageEventForm(Form mainForm, Event ev)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            evnt = ev;

            #region assign values
            this.eventRecordText.Text = evnt.RecordNr;
            this.eventClientText.Text = evnt.Client.FirstName + " " + evnt.Client.LastName;
            this.eventTypeText.Text = evnt.EventType;
            this.descriptionText.Text = evnt.Description;
            this.attendeesText.Text = evnt.Attendees.ToString();
            this.budgetText.Text = evnt.Budget.ToString();
            this.fromDatePicker.Value = evnt.From;
            this.toDatePicker.Value = evnt.To;

            this.decorationsText.Text = evnt.Decorations;
            this.foodText.Text = evnt.FoodAndDrinks;
            this.filmingText.Text = evnt.Filming;
            this.musicText.Text = evnt.Music;
            this.postersText.Text = evnt.Posters;
            this.computerText.Text = evnt.ComputerRelatedIssues;
            this.otherText.Text = evnt.OtherNeeds;

            RefreshTasks();
            if (evnt.Status != null)
            {
                this.statusComboBox.SelectedItem = evnt.Status;
            }
            else
            {
                this.statusComboBox.SelectedIndex = 0;
            }
            #endregion
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            var eventTaskForm = new EventTaskForm(this, evnt);
            eventTaskForm.Show(this);
        }

        private void ManageEventForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        public void RefreshTasks()
        {
            eventTasksDataGrid.DataSource = null;
            eventTasksDataGrid.DataSource = evnt.Tasks;
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            evnt.Status = statusComboBox.Text;
        }

        private void EventTasksDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EventTask selected = (EventTask)eventTasksDataGrid.CurrentRow.DataBoundItem;
            new ManageAssignmentForm(this, selected).Show();
            this.Hide();
        }
    }
}
