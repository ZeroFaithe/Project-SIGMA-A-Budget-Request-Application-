using System;
using System.Data;
using System.Drawing;
using System.IO; // Required for Image handling
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Project_SIGMA__A_Budget_Request_Application_.Resources.Admin
{
    public partial class LiquidationAdmin : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SIGMADB"].ConnectionString;
        private int _selectedLiquidationID = -1;

        public LiquidationAdmin()
        {
            InitializeComponent();
            LoadRequests("Pending"); // Default View
        }

        // 1. LOAD REQUESTS (Top Grid)
        private void LoadRequests(string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // We show the "GrandTotalDifference" so Admin sees the Deficit/Excess immediately
                    string query = @"SELECT 
                                        LR.LiquidationID,
                                        P.EventName,
                                        LR.RequestType,
                                        LR.GrandTotalExpense,
                                        LR.GrandTotalDifference,
                                        LR.SubmittedBy,
                                        LR.DateSubmitted
                                     FROM LiquidationRequests LR
                                     INNER JOIN BudgetRequests BR ON LR.BudgetRequestID = BR.RequestID
                                     INNER JOIN POA P ON BR.POAID = P.ID
                                     WHERE LR.Status = @Status";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@Status", status);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvRequests.DataSource = dt;

                    // Hide ID
                    if (dgvRequests.Columns["LiquidationID"] != null)
                        dgvRequests.Columns["LiquidationID"].Visible = false;

                    // Format Money Columns
                    if (dgvRequests.Columns["GrandTotalExpense"] != null)
                        dgvRequests.Columns["GrandTotalExpense"].DefaultCellStyle.Format = "C2";
                    if (dgvRequests.Columns["GrandTotalDifference"] != null)
                        dgvRequests.Columns["GrandTotalDifference"].DefaultCellStyle.Format = "C2";
                }
                catch (Exception ex) { MessageBox.Show("Error loading data: " + ex.Message); }
            }
        }

        // 2. CLICK TOP ROW -> LOAD RECEIPTS (Bottom Left)
        private void dgvRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRequests.Rows[e.RowIndex];
                if (row.Cells["LiquidationID"].Value != DBNull.Value)
                {
                    _selectedLiquidationID = Convert.ToInt32(row.Cells["LiquidationID"].Value);
                    LoadReceipts(_selectedLiquidationID);

                    // Clear previous image since we changed reports
                    pbReceipt.Image = null;
                }
            }
        }

        private void LoadReceipts(int liquidationID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // We need DetailID to fetch the image later
                string query = @"SELECT DetailID, InvoiceNumber, Supplier, BudgetParticular, ActualExpense 
                                 FROM LiquidationDetails 
                                 WHERE LiquidationID = @ID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@ID", liquidationID);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvReceipts.DataSource = dt;

                // Hide DetailID
                if (dgvReceipts.Columns["DetailID"] != null)
                    dgvReceipts.Columns["DetailID"].Visible = false;

                // Format Money
                if (dgvReceipts.Columns["ActualExpense"] != null)
                    dgvReceipts.Columns["ActualExpense"].DefaultCellStyle.Format = "C2";
            }
        }

        // 3. CLICK RECEIPT ROW -> SHOW IMAGE (Bottom Right)
        private void dgvReceipts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvReceipts.Rows[e.RowIndex];

                if (row.Cells["DetailID"].Value != DBNull.Value)
                {
                    int detailID = Convert.ToInt32(row.Cells["DetailID"].Value);
                    ShowReceiptImage(detailID);
                }
            }
        }

        private void ShowReceiptImage(int detailID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ReceiptImage FROM LiquidationDetails WHERE DetailID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", detailID);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        byte[] imageBytes = (byte[])result;

                        // Convert Bytes back to Image
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pbReceipt.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pbReceipt.Image = null; // No image found
                    }
                }
            }
        }

        // 4. APPROVAL LOGIC (Standard)
        private void ProcessDecision(string newStatus)
        {
            if (_selectedLiquidationID == -1) { MessageBox.Show("Select a report first."); return; }

            if ((newStatus == "Rejected" || newStatus == "To be Revised") && string.IsNullOrWhiteSpace(rtbRemarks.Text))
            {
                MessageBox.Show("Remarks are required for Rejection/Revision."); return;
            }

            if (MessageBox.Show($"Mark report as {newStatus}?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Update Status
                    string updateQuery = "UPDATE LiquidationRequests SET Status = @Status WHERE LiquidationID = @ID";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Status", newStatus);
                        cmd.Parameters.AddWithValue("@ID", _selectedLiquidationID);
                        cmd.ExecuteNonQuery();
                    }

                    // Insert Remark
                    string remarkText = string.IsNullOrWhiteSpace(rtbRemarks.Text) ? "Processed." : rtbRemarks.Text;
                    string remQuery = @"INSERT INTO LiquidationRemarks (LiquidationID, Remark, StatusGiven) 
                                        VALUES (@ID, @Rem, @Stat)";

                    using (SqlCommand cmdRem = new SqlCommand(remQuery, conn, transaction))
                    {
                        cmdRem.Parameters.AddWithValue("@ID", _selectedLiquidationID);
                        cmdRem.Parameters.AddWithValue("@Rem", remarkText);
                        cmdRem.Parameters.AddWithValue("@Stat", newStatus);
                        cmdRem.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Success!");

                    // Reset UI
                    LoadRequests("Pending");
                    dgvReceipts.DataSource = null;
                    pbReceipt.Image = null;
                    rtbRemarks.Clear();
                    _selectedLiquidationID = -1;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // 5. BUTTON LINKS
        private void btnPending_Click(object sender, EventArgs e) { LoadRequests("Pending"); }
        private void btnApproved_Click(object sender, EventArgs e) { LoadRequests("Approved"); }
        private void btnRevise_Click(object sender, EventArgs e) { LoadRequests("To be Revised"); }
        private void btnRejected_Click(object sender, EventArgs e) { LoadRequests("Rejected"); }

        private void btnApprove_Click(object sender, EventArgs e) { ProcessDecision("Approved"); }
        private void btnReject_Click(object sender, EventArgs e) { ProcessDecision("Rejected"); }
        private void btnReviseAction_Click(object sender, EventArgs e) { ProcessDecision("To be Revised"); }

        private void pbReceipt_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.WindowState = FormWindowState.Maximized;

            PictureBox pb = new PictureBox();
            pb.Dock = DockStyle.Fill;
            pb.Image = pbReceipt.Image;
            pb.SizeMode = PictureBoxSizeMode.Zoom;

            f.Controls.Add(pb);
            f.ShowDialog();

        }
    }
}
