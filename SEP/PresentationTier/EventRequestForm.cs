using BusinessTier;
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
            //todo: remove when can move between forms

            requestDataGridView.DataSource = eventRequestController.EventRequests;
        }

        private void EventRequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
