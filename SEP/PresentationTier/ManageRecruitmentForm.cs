using BusinessTier;
using DataTier;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class ManageRecruitmentForm : Form
    {
        private readonly Form mainForm;
        public ManageRecruitmentForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            SetRecruitmentRequests();
        }

        private void ManageRecruitmentRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void CreateRecruitmentRequestButton_Click(object sender, EventArgs e)
        {
            new RecruitmentRequestForm(this).Show();
            this.Hide();
        }

        private void RecruitmentRequestDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Session.UserSession.LoggedInUser.Role == User.Roles.SeniorHRManager &&
                e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == MouseButtons.Right)
            {
                recruitmentRequestDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                ContextMenu cm = new ContextMenu();
                cm.MenuItems.Add(new MenuItem("approve", SolveFinancialRequestItem_Click));
                cm.MenuItems.Add(new MenuItem("deny", SolveFinancialRequestItem_Click));

                var relativeMousePosition = recruitmentRequestDataGrid.PointToClient(Cursor.Position);
                cm.Show(recruitmentRequestDataGrid, relativeMousePosition);
            }
        }

        private void SolveFinancialRequestItem_Click(object sender, EventArgs e)
        {
            var selectedRequest = (RecruitmentRequest)recruitmentRequestDataGrid.CurrentRow.DataBoundItem;
            RecruitmentRequestController recruitmentRequestController = new RecruitmentRequestController();
            recruitmentRequestController.SolveRecruitmentRequest(selectedRequest, (sender as MenuItem).Text);

            SetRecruitmentRequests();
        }

        public void SetRecruitmentRequests()
        {
            var recruitmentRequests = new RecruitmentRequestController().GetRecruitmentRequests();
            if (Session.UserSession.LoggedInUser.Role == User.Roles.SeniorHRManager)
            {
                recruitmentRequests = recruitmentRequests.Where(x => x.Reviewed == false).ToList();
            }
            else
            {
                recruitmentRequests = recruitmentRequests.Where(x => x.Reviewed == true &&
                    x.User == Session.UserSession.LoggedInUser).ToList();
            }
            recruitmentRequestDataGrid.DataSource = null;
            recruitmentRequestDataGrid.DataSource = recruitmentRequests;
        }

        private void RecruitmentRequestDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (Session.UserSession.LoggedInUser.Role != User.Roles.FinancialManager && e.ColumnIndex == recruitmentRequestDataGrid.Columns[6].Index)
                {
                    if (e.Value is true)
                    {
                        recruitmentRequestDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        recruitmentRequestDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
                    }
                }
            }
            catch (Exception) { }
        }
    }
}
