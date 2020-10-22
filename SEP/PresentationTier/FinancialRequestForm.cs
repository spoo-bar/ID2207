using BusinessTier;
using DataTier;
using System;
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

            financialRequestDataGridView.DataSource = new FinancialRequestController().GetFinancialRequests();
        }

        private void FinancialRequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void FinancialRequestDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == MouseButtons.Right)
            {
                financialRequestDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                ContextMenu cm = new ContextMenu();
                cm.MenuItems.Add(new MenuItem("approved", SolveFinancialRequestItem_Click));
                cm.MenuItems.Add(new MenuItem("deny", SolveFinancialRequestItem_Click));

                var relativeMousePosition = financialRequestDataGridView.PointToClient(Cursor.Position);
                cm.Show(financialRequestDataGridView, relativeMousePosition);
            }
        }

        private void SolveFinancialRequestItem_Click(object sender, EventArgs e)
        {
            var selectedRequest = (FinancialRequest)financialRequestDataGridView.CurrentRow.DataBoundItem;
            FinancialRequestController financialRequestController = new FinancialRequestController();
            financialRequestController.SolveFinancialRequest(selectedRequest);

            financialRequestDataGridView.DataSource = null;
            financialRequestDataGridView.DataSource = financialRequestController.GetFinancialRequests();
        }
    }
}
