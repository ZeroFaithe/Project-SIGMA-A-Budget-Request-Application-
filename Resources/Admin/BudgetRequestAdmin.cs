using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Project_SIGMA__A_Budget_Request_Application_.Resources.Admin
{
    public partial class BudgetRequestAdmin : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SIGMADB"].ConnectionString;
        private int _selectedRequestID = -1; // Keeps track of which request we are looking at
        public BudgetRequestAdmin()
        {
            InitializeComponent();
            LoadBudgetRequests("Pending");
        }

        private void LoadBudgetRequests(string statusFilter)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // JOIN Query: Get Request info + Event Name from POA table
                    string query = @"SELECT 
                                BR.RequestID, 
                                P.EventName, 
                                BR.TotalAmount, 
                                BR.DateNeeded, 
                                BR.SubmittedBy 
                             FROM BudgetRequests BR
                             INNER JOIN POA P ON BR.POAID = P.ID
                             WHERE BR.Status = @Status"; // <--- CHANGED TO PARAMETER

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@Status", statusFilter); // <--- PASS THE FILTER

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvPendingRequests.DataSource = dt; // Note: Grid name might still be dgvPendingRequests

                    // Formatting
                    if (dgvPendingRequests.Columns["RequestID"] != null)
                        dgvPendingRequests.Columns["RequestID"].Visible = false;

                    if (dgvPendingRequests.Columns["TotalAmount"] != null)
                    {
                        dgvPendingRequests.Columns["TotalAmount"].DefaultCellStyle.Format = "C2";
                        dgvPendingRequests.Columns["TotalAmount"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-PH");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading requests: " + ex.Message);
                }
            }
        }


        // 2. LOAD MIDDLE GRID (Breakdown Items)
        // This runs when you click a row in the Top Grid

        private void LoadBreakdownItems(int requestID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT ItemName, Quantity, Amount, TotalCost, Supplier 
                                     FROM BudgetParticulars 
                                     WHERE RequestID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", requestID);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvBreakdown.DataSource = dt;

                        // Formatting
                        if (dgvBreakdown.Columns["Amount"] != null)
                        {
                            dgvBreakdown.Columns["Amount"].DefaultCellStyle.Format = "C2";
                            dgvBreakdown.Columns["Amount"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-PH");
                        }
                            
                        if (dgvBreakdown.Columns["TotalCost"] != null)
                        {
                            dgvBreakdown.Columns["TotalCost"].DefaultCellStyle.Format = "C2";
                            dgvBreakdown.Columns["TotalCost"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-PH");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading breakdown: " + ex.Message);
                }
            }
        }

        private void ProcessDecision(string newStatus)
        {
            // A. Validation
            if (_selectedRequestID == -1)
            {
                MessageBox.Show("Please select a request from the top list first.");
                return;
            }

            if ((newStatus == "Rejected" || newStatus == "To be Revised") && string.IsNullOrWhiteSpace(rtbRemarks.Text))
            {
                MessageBox.Show("Add Remarks.", "Remark Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // B. Confirmation
            if (MessageBox.Show($"Mark this request as {newStatus}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            // C. Database Update
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Update Status
                    string updateQuery = "UPDATE BudgetRequests SET Status = @Status WHERE RequestID = @ID";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Status", newStatus);
                        cmd.Parameters.AddWithValue("@ID", _selectedRequestID);
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Insert Remark
                    string remarkText = rtbRemarks.Text.Trim();
                    if (newStatus == "Approved" && string.IsNullOrEmpty(remarkText))
                        remarkText = "Budget Approved.";

                    if (!string.IsNullOrEmpty(remarkText))
                    {
                        string remarkQuery = @"INSERT INTO BudgetRemarks (RequestID, Remark, StatusGiven, DateCreated) 
                                               VALUES (@ID, @Remark, @Status, GETDATE())";
                        using (SqlCommand cmd = new SqlCommand(remarkQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ID", _selectedRequestID);
                            cmd.Parameters.AddWithValue("@Remark", remarkText);
                            cmd.Parameters.AddWithValue("@Status", newStatus);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show($"Request marked as {newStatus}.");
                    LoadBudgetRequests("Pending"); // Reload the Pending list
                    ClearDetails();

                    // D. Refresh UI
                    dgvBreakdown.DataSource = null; // Clear middle list
                    rtbRemarks.Clear();      // Clear remarks
                    _selectedRequestID = -1; // Reset selection
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error processing request: " + ex.Message);
                }
            }
        }

        private void btnToRevise_Click(object sender, EventArgs e)
        {
            ProcessDecision("To be Revised");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            ProcessDecision("Rejected");
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            ProcessDecision("Approved");
        }

        private void dgvPendingRequests_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPendingRequests.Rows[e.RowIndex];

                if (row.Cells["RequestID"].Value != DBNull.Value)
                {
                    _selectedRequestID = Convert.ToInt32(row.Cells["RequestID"].Value);
                    LoadBreakdownItems(_selectedRequestID);
                }
            }
        }

        private void btnPendingBR_Click(object sender, EventArgs e)
        {
            LoadBudgetRequests("Pending");
            ClearDetails();
        }

        private void btnApprovedBR_Click(object sender, EventArgs e)
        {
            LoadBudgetRequests("Approved");
            ClearDetails();
        }

        private void btnToReviseBR_Click(object sender, EventArgs e)
        {
            LoadBudgetRequests("To be Revised");
            ClearDetails();
        }

        private void btnRejectedBR_Click(object sender, EventArgs e)
        {
            LoadBudgetRequests("Rejected");
            ClearDetails();
        }

        private void ClearDetails()
        {
            dgvBreakdown.DataSource = null;
            rtbRemarks.Clear();
            _selectedRequestID = -1;
        }
    }
}
