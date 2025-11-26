using Microsoft.Data.SqlClient;
using Project_SIGMA__A_Budget_Request_Application_.Resources;
using Project_SIGMA__A_Budget_Request_Application_.Resources.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project_SIGMA__A_Budget_Request_Application_.BudgetRequest;
using static Project_SIGMA__A_Budget_Request_Application_.Resources.Student.ReceiptForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_SIGMA__A_Budget_Request_Application_
{
    public partial class LiquidationFormStudent : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SIGMADB"].ConnectionString;
        List<ReceiptData> _stagedReceipts = new List<ReceiptData>();
        public LiquidationFormStudent()
        {
            InitializeComponent();

            dgvSummary.ColumnCount = 6;
            dgvSummary.Columns[0].Name = "Invoice Number";
            dgvSummary.Columns[1].Name = "Supplier";
            dgvSummary.Columns[2].Name = "Category";
            dgvSummary.Columns[3].Name = "Allotted Budget";
            dgvSummary.Columns[4].Name = "Actual Expense";
            dgvSummary.Columns[5].Name = "Excess/Deficit";

            LoadApprovedBudgets();
            LoadMyLiquidations("Pending");
        }
        private void LoadApprovedBudgets()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT BR.RequestID, P.EventName, BR.RequestCode 
                                     FROM BudgetRequests BR
                                     INNER JOIN POA P ON BR.POAID = P.ID
                                     WHERE BR.Status = 'Approved' 
                                     AND BR.SubmittedBy = @User";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@User", UserSession.Username);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cmbApprovedBudgets.Items.Clear();
                            while (reader.Read())
                            {
                                ComboBoxItem item = new ComboBoxItem();
                                item.Value = Convert.ToInt32(reader["RequestID"]);
                                item.Text = $"{reader["EventName"]} ({reader["RequestCode"]})";
                                cmbApprovedBudgets.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void LiquidationFormStudent_Load(object sender, EventArgs e)
        {
            cmbApprovedBudgets.Items.AddRange(new string[]
                {

                });

        }

        private void LoadMyLiquidations(string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // We select specific columns to match your request:
                    // 1. ID (Hidden, needed for code)
                    // 2. Event Name
                    // 3. Request Type (Liquidation/Reimbursement)
                    // 4. Status (Needed for logic)
                    // 5. Date
                    string query = @"SELECT 
                                LR.LiquidationID,
                                P.EventName,
                                LR.RequestType,
                                LR.Status,
                                LR.DateSubmitted
                             FROM LiquidationRequests LR
                             INNER JOIN BudgetRequests BR ON LR.BudgetRequestID = BR.RequestID
                             INNER JOIN POA P ON BR.POAID = P.ID
                             WHERE LR.SubmittedBy = @User 
                             AND LR.Status = @Status";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@User", UserSession.Username);
                    adapter.SelectCommand.Parameters.AddWithValue("@Status", status);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvLiquidationHistory.DataSource = dt;

                    // --- COLUMN SETTINGS ---

                    // 1. Hide the ID (System needs it, User doesn't)
                    if (dgvLiquidationHistory.Columns["LiquidationID"] != null)
                        dgvLiquidationHistory.Columns["LiquidationID"].Visible = false;

                    // 2. Rename Headers to match your request
                    if (dgvLiquidationHistory.Columns["EventName"] != null)
                        dgvLiquidationHistory.Columns["EventName"].HeaderText = "Event";

                    if (dgvLiquidationHistory.Columns["RequestType"] != null)
                        dgvLiquidationHistory.Columns["RequestType"].HeaderText = "Reimbursement/Liquidation";

                    if (dgvLiquidationHistory.Columns["Status"] != null)
                        dgvLiquidationHistory.Columns["Status"].HeaderText = "Request Status";

                    if (dgvLiquidationHistory.Columns["DateSubmitted"] != null)
                        dgvLiquidationHistory.Columns["DateSubmitted"].HeaderText = "Date";

                    // 3. Visual Cleanup
                    dgvLiquidationHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading history: " + ex.Message);
                }
            }
        }

        private void btnRemoveReceipt_Click(object sender, EventArgs e)
        {

            if (dgvSummary.SelectedRows.Count > 0)
            {
                int index = dgvSummary.SelectedRows[0].Index;
                if (index < _stagedReceipts.Count)
                {
                    _stagedReceipts.RemoveAt(index); // Remove from memory
                    dgvSummary.Rows.RemoveAt(index); // Remove from screen
                    UpdateGrandTotal();
                }
            }

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void dgvSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbApprovedBudgets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbApprovedBudgets.SelectedItem == null) return;
            int requestID = ((ComboBoxItem)cmbApprovedBudgets.SelectedItem).Value;

            // Clear previous data
            _stagedReceipts.Clear();
            dgvSummary.Rows.Clear(); // Ensure this grid exists in Designer!
            UpdateGrandTotal();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Get breakdown of the Budget Request to serve as "Basis"
                string query = "SELECT ItemName, TotalCost FROM BudgetParticulars WHERE RequestID = @ID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@ID", requestID);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Fill Basis Grid
                dgvBudgetBasis.DataSource = dt; // Ensure this grid exists!
                dgvBudgetBasis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnAddReceipt_Click(object sender, EventArgs e)
        {
            if (dgvBudgetBasis.Rows.Count == 0)
            {
                MessageBox.Show("Please select an Approved Budget first.");
                return;
            }

            // A. Collect Categories from Basis Grid
            List<string> categories = new List<string>();
            foreach (DataGridViewRow row in dgvBudgetBasis.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells[0].Value != null)
                    categories.Add(row.Cells[0].Value.ToString());
            }
            categories.Add("Others");

            // B. Open Pop-up
            using (ReceiptForm frm = new ReceiptForm())
            {
                frm.SetCategories(categories); // Pass data to pop-up

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ReceiptData newReceipt = frm.OutputData;

                    // C. Find Allotted Amount for this Category (for Math)
                    decimal allotted = 0m;
                    foreach (DataGridViewRow row in dgvBudgetBasis.Rows)
                    {
                        if (row.IsNewRow) continue;                      // skip the add-new row
                        var cell0 = row.Cells[0].Value;
                        if (cell0 == null) continue;                    // skip empty cells

                        string catName = cell0.ToString().Trim();
                        if (string.Equals(catName, newReceipt.Category?.Trim(), StringComparison.OrdinalIgnoreCase))
                        {
                            var allotObj = row.Cells.Count > 1 ? row.Cells[1].Value : null;
                            if (allotObj != null && allotObj != DBNull.Value)
                            {
                                if (!decimal.TryParse(allotObj.ToString(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture, out allotted))
                                {
                                    // fallback safe conversion
                                    try { allotted = Convert.ToDecimal(allotObj); } catch { allotted = 0m; }
                                }
                            }
                            break;
                        }
                    }
                    newReceipt.AllottedBudget = allotted;

                    // D. Add to Memory & Grid
                    _stagedReceipts.Add(newReceipt);

                    decimal excessDeficit = allotted - newReceipt.TotalAmount;

                    // Show negatives with a leading minus instead of parentheses
                    string diffText = excessDeficit.ToString("N2"); // e.g. -1,234.56

                    dgvSummary.Rows.Add(
                        newReceipt.Invoice,
                        newReceipt.Supplier,
                        newReceipt.Category,
                        allotted.ToString("N2"),
                        newReceipt.TotalAmount.ToString("N2"),
                        diffText
                    );

                    UpdateGrandTotal();
                }
            }
        }
        private void UpdateGrandTotal()
        {
            decimal total = 0;
            foreach (var r in _stagedReceipts) total += r.TotalAmount;
            // Update Label (Ensure you have this label)
            // lblGrandTotal.Text = "Total: " + total.ToString("C2", new CultureInfo("en-PH")); 
        }

        // 4. SUBMIT BUTTON (Save to Database)
        private void btnSubmitReport_Click(object sender, EventArgs e)
        {
            if (_stagedReceipts.Count == 0)
            {
                MessageBox.Show("Please add at least one receipt.");
                return;
            }

            if (MessageBox.Show("Submit Liquidation Report?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    int budgetID = ((ComboBoxItem)cmbApprovedBudgets.SelectedItem).Value;
                    string type = rdoLiquidation.Checked ? "Liquidation" : "Reimbursement"; // Assuming RadioButtons

                    // Compute totals
                    decimal grandTotalExpense = 0m;
                    decimal grandTotalDifference = 0m; // AllottedBudget - ActualExpense
                    foreach (var r in _stagedReceipts)
                    {
                        grandTotalExpense += r.TotalAmount;
                        grandTotalDifference += (r.AllottedBudget - r.TotalAmount);
                    }

                    // A. INSERT HEADER (include GrandTotalDifference)
                    string headQuery = @"INSERT INTO LiquidationRequests 
                                         (BudgetRequestID, RequestType, SubmittedBy, Status, GrandTotalExpense, GrandTotalDifference)
                                         VALUES (@BID, @Type, @User, 'Pending', @Total, @Diff);
                                         SELECT SCOPE_IDENTITY();";

                    int liqID = 0;
                    using (SqlCommand cmd = new SqlCommand(headQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@BID", budgetID);
                        cmd.Parameters.AddWithValue("@Type", type);
                        cmd.Parameters.AddWithValue("@User", UserSession.Username);
                        cmd.Parameters.AddWithValue("@Total", grandTotalExpense);
                        cmd.Parameters.AddWithValue("@Diff", grandTotalDifference.ToString("N2"));

                        liqID = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // B. INSERT DETAILS (Receipts)
                    foreach (var receipt in _stagedReceipts)
                    {
                        string detQuery = @"INSERT INTO LiquidationDetails 
                                            (LiquidationID, InvoiceNumber, Supplier, ReceiptImage, BudgetParticular, AllottedBudget, ActualExpense)
                                            VALUES (@LiqID, @Inv, @Supp, @Img, @Cat, @Allot, @Actual)";

                        using (SqlCommand cmdDet = new SqlCommand(detQuery, conn, transaction))
                        {
                            cmdDet.Parameters.AddWithValue("@LiqID", liqID);
                            cmdDet.Parameters.AddWithValue("@Inv", receipt.Invoice);
                            cmdDet.Parameters.AddWithValue("@Supp", receipt.Supplier);
                            cmdDet.Parameters.AddWithValue("@Img", receipt.ReceiptImage);
                            cmdDet.Parameters.AddWithValue("@Cat", receipt.Category);
                            cmdDet.Parameters.AddWithValue("@Allot", receipt.AllottedBudget);
                            cmdDet.Parameters.AddWithValue("@Actual", receipt.TotalAmount);
                            cmdDet.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Report Submitted Successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error saving: " + ex.Message);
                }
            }
        }

        private void btnFilterApproved_Click(object sender, EventArgs e)
        {
            LoadMyLiquidations("Approved");
        }

        private void btnFilterPending_Click(object sender, EventArgs e)
        {
            LoadMyLiquidations("Pending");
        }

        private void btnFilterToRevise_Click(object sender, EventArgs e)
        {
            LoadMyLiquidations("To be Revised");
        }

        private void btnFilterRejected_Click(object sender, EventArgs e)
        {
            LoadMyLiquidations("Rejected");
        }

    }
}
