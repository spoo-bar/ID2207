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
    public partial class ManageEventForm : Form
    {
        private readonly Form mainForm;
        public string eventRecordNumber;
        private Event evnt;

        public ManageEventForm(Form mainForm, Event ev)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            evnt = ev;

            this.eventRecordNumber = ev.RecordNr;
            this.eventRecordText.Text = ev.RecordNr;
            this.eventRecordText.Enabled = false;
            this.eventClientText.Text = ev.Client.FirstName + " " + ev.Client.LastName;
            this.eventClientText.Enabled = false;
            this.eventTypeText.Text = ev.EventType;
            this.eventTypeText.Enabled = false;
            this.descriptionText.Text = ev.Description;
            this.descriptionText.Enabled = false;
            this.attendeesText.Text = ev.Attendees.ToString();
            this.attendeesText.Enabled = false;
            this.budgetText.Text = ev.Budget.ToString();
            this.budgetText.Enabled = false;
            this.fromDatePicker.Value = ev.From;
            this.fromDatePicker.Enabled = false;
            this.toDatePicker.Value = ev.To;
            this.toDatePicker.Enabled = false;


            this.decorationsText.Text = ev.Decorations;
            this.foodText.Text = ev.FoodAndDrinks;
            this.filmingText.Text = ev.Filming;
            this.musicText.Text = ev.Music;
            this.postersText.Text = ev.Posters;
            this.computerText.Text = ev.ComputerRelatedIssues;
            this.otherText.Text = ev.OtherNeeds;
            this.eventTasksDataGrid.DataSource = ev.Tasks;
            if (ev.Status != null)
            {
                this.statusComboBox.SelectedItem = ev.Status;
            }
            else
            {
                this.statusComboBox.SelectedIndex = 0;
            }
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            var eventTaskForm = new EventTaskForm(this);
            eventTaskForm.Show(this);
        }

        private void ManageEventForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        public void RefreshTasks()
        {
            //TODO : refersh the tasks datagrid.
            var updatedEvent = new EventController().GetEvents().First(e => e.RecordNr == this.eventRecordNumber);
            this.eventTasksDataGrid.DataSource = updatedEvent;
            this.eventTasksDataGrid.Update();
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            evnt.Status = statusComboBox.Text;
        }
    }
}
