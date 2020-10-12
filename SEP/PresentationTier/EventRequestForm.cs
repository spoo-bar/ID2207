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
    public partial class EventRequestForm : Form
    {
        private readonly Form mainForm;
        public EventRequestForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            EventRequestController eventRequestController = new EventRequestController();
            requestDataGridView.DataSource = eventRequestController.EventRequests;
        }

        private void EventRequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void RequestDataGridView_DoubleClick(object sender, EventArgs e)
        {
            EventRequest selected = (EventRequest)requestDataGridView.CurrentRow.DataBoundItem;
            new FinancialFeedbackForm(this, selected).Show();
            this.Hide();
        }

        private void CreateEventRequestButton_Click(object sender, EventArgs e)
        {
            new CreateEventRequestForm(this).Show();
            this.Hide();
        }
    }
}
