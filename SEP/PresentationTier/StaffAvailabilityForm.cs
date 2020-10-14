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
    public partial class StaffAvailabilityForm : Form
    {
        private readonly Form mainForm;

        public StaffAvailabilityForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            DateTimePicker_ValueChanged(null, null);
        }

        private void StaffAvailabilityForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            EventController eventController = new EventController();
            staffDataGridView.DataSource = eventController.GetAvailableUsers(Session.UserSession.LoggedInUser.Subordinates, fromDateTimePicker.Value, toDateTimePicker.Value);
        }
    }
}
