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
    public partial class EventForm : Form
    {
        private EventController eventController = new EventController();
        private readonly Form mainForm;
        public EventForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            eventFormGridView.DataSource = eventController.GetEvents();
        }

        private void EventDataGridView_DoubleClick(object sender, EventArgs e)
        {
            var selectedEvent = (Event)eventFormGridView.CurrentRow.DataBoundItem;
            //new ManageEventRequestForm(this, selectedEvent).Show();
            this.Hide();
        }

        private void EventForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
