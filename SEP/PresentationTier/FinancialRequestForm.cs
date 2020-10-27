using BusinessTier;
using DataTier;
using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class FinancialRequestForm : Form
    {
        private readonly Form mainForm;
        public FinancialRequestForm(Form mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            SetFinancialRequests();
        }

        private void SetFinancialRequests()
        {
            var financialRequest = new FinancialRequestController().GetFinancialRequests();
            if (Session.UserSession.LoggedInUser.Role == User.Roles.FinancialManager)
            {
                financialRequest = financialRequest.Where(x => x.Reviewed == false).ToList();
            }
            else
            {
                financialRequest = financialRequest.Where(x => x.Reviewed == true &&
                    x.User == Session.UserSession.LoggedInUser).ToList();
            }
            financialRequestDataGridView.DataSource = null;
            financialRequestDataGridView.DataSource = financialRequest;
        }

        private void FinancialRequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void FinancialRequestDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Session.UserSession.LoggedInUser.Role == User.Roles.FinancialManager && 
                e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == MouseButtons.Right)
            {
                financialRequestDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                ContextMenu cm = new ContextMenu();
                cm.MenuItems.Add(new MenuItem("approve", SolveFinancialRequestItem_Click));
                cm.MenuItems.Add(new MenuItem("deny", SolveFinancialRequestItem_Click));

                var relativeMousePosition = financialRequestDataGridView.PointToClient(Cursor.Position);
                cm.Show(financialRequestDataGridView, relativeMousePosition);
            }
        }

        private void SolveFinancialRequestItem_Click(object sender, EventArgs e)
        {
            var selectedRequest = (FinancialRequest)financialRequestDataGridView.CurrentRow.DataBoundItem;
            FinancialRequestController financialRequestController = new FinancialRequestController();
            financialRequestController.SolveFinancialRequest(selectedRequest, (sender as MenuItem).Text);

            SetFinancialRequests();
        }

        private void FinancialRequestDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (Session.UserSession.LoggedInUser.Role != User.Roles.FinancialManager && e.ColumnIndex == financialRequestDataGridView.Columns[5].Index)
                {
                    if (e.Value is true)
                    {
                        financialRequestDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        financialRequestDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
                    }
                }
            }
            catch (Exception) { }
        }
    }
}
