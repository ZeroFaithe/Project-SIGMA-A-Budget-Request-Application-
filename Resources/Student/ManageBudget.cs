using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Project_SIGMA__A_Budget_Request_Application_.Resources.Student
{
    public partial class ManageBudget : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SIGMADB"].ConnectionString;
        private bool _isEditMode = false;
        private int _requestIDToEdit = -1;
        private int _selectedRequestID = -1;
        public ManageBudget()
        {
            InitializeComponent();
            LoadMyRequests("Approved");
        }


        private void LoadMyRequests(string statusFilter)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT 
                                        BR.RequestID, 
                                        P.EventName, 
                                        BR.TotalAmount, 
                                        BR.DateNeeded, 
                                        BR.Status 
                                     FROM BudgetRequests BR
                                     INNER JOIN POA P ON BR.POAID = P.ID
                                     WHERE BR.Status = @Status 
                                     AND BR.SubmittedBy = @User";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@Status", statusFilter);
                    adapter.SelectCommand.Parameters.AddWithValue("@User", UserSession.Username);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvMyRequests.DataSource = dt;

                    // Hide ID
                    if (dgvMyRequests.Columns["RequestID"] != null)
                        dgvMyRequests.Columns["RequestID"].Visible = false;

                    // Format Money
                    if (dgvMyRequests.Columns["TotalAmount"] != null)
                    {
                        dgvMyRequests.Columns["TotalAmount"].DefaultCellStyle.Format = "C2";
                        dgvMyRequests.Columns["TotalAmount"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-PH");
                    }    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading requests: " + ex.Message);
                }
            }
        }

        private void dgvMyRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMyRequests.Rows[e.RowIndex];

                if (row.Cells["RequestID"].Value != DBNull.Value)
                {
                    int requestID = Convert.ToInt32(row.Cells["RequestID"].Value);
                    string status = row.Cells["Status"].Value.ToString();

                    // Store ID for other logic
                    _selectedRequestID = requestID;

                    // Enable Edit Button only if "To be Revised"
                    if (status == "To be Revised")
                    {
                        btnEditRequest.Enabled = true;
                    }
                    else
                    {
                        btnEditRequest.Enabled = false;
                    }

                    // Load details
                    LoadBreakdown(requestID);
                    LoadRemarksHistory(requestID);
                }
            }
        }

        // 3. DETAIL 1: Load the Items (Bottom Left Grid)
        private void LoadBreakdown(int requestID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ItemName, Quantity, Amount, TotalCost, Supplier FROM BudgetParticulars WHERE RequestID = @ID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@ID", requestID);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvBreakdown.DataSource = dt;

                    // Formatting
                    dgvBreakdown.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                catch (Exception ex) { MessageBox.Show("Error loading items: " + ex.Message); }
            }
        }
        private void LoadRemarksHistory(int requestID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Fetch history ordered by newest first
                    string query = @"SELECT DateCreated, StatusGiven, Remark 
                                     FROM BudgetRemarks 
                                     WHERE RequestID = @ID 
                                     ORDER BY DateCreated DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@ID", requestID);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvRemarks.DataSource = dt;

                    // Formatting
                    dgvRemarks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Optional: Rename headers for better look
                    if (dgvRemarks.Columns["DateCreated"] != null)
                        dgvRemarks.Columns["DateCreated"].HeaderText = "Date";
                    if (dgvRemarks.Columns["StatusGiven"] != null)
                        dgvRemarks.Columns["StatusGiven"].HeaderText = "Status";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading remarks: " + ex.Message);
                }
            }
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            LoadMyRequests("Approved");
            ClearDetails();
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            LoadMyRequests("Pending");
            ClearDetails();
        }

        private void btnToRevise_Click(object sender, EventArgs e)
        {
            LoadMyRequests("To be Revised");
            ClearDetails();
        }

        private void btnRejected_Click(object sender, EventArgs e)
        {
            LoadMyRequests("Rejected");
            ClearDetails();
        }

        private void ClearDetails()
        {
            dgvBreakdown.DataSource = null;
            dgvRemarks.DataSource = null;
        }

        private void btnPOANewEntry_Click(object sender, EventArgs e)
        {
            BudgetRequest newRequestForm = new BudgetRequest();
            newRequestForm.ShowDialog();

            // Refresh the grid after they close the form so the new request appears immediately
            LoadMyRequests("Pending");
        }

        private void btnEditRequest_Click(object sender, EventArgs e)
        {
            if (_selectedRequestID != -1)
            {
                // Open form in Edit Mode
                BudgetRequest editForm = new BudgetRequest(_selectedRequestID);
                editForm.ShowDialog();

                // Refresh list
                LoadMyRequests("To be Revised");

                // Reset UI
                btnEditRequest.Enabled = false;
                _selectedRequestID = -1;
                dgvBreakdown.DataSource = null;
            }
        }
    }
}
