using Microsoft.Data.SqlClient;
using Project_SIGMA__A_Budget_Request_Application_.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SIGMA__A_Budget_Request_Application_
{
    public partial class ManagePOA : Form
    {
        private int _selectedPOAID = -1;
        string connectionString = ConfigurationManager.ConnectionStrings["SIGMADB"].ConnectionString;
        public ManagePOA()
        {
            InitializeComponent();

            // Ensure events are wired (Designer currently doesn't wire them)
            this.Load += ManagePOA_Load;
            btnApprovedPOA.Click += btnApprovedPOA_Click;
            btnPendingPOA.Click += btnPendingPOA_Click;
            btnToRevisePOA.Click += btnToRevisePOA_Click;
            btnRejectedPOA.Click += btnRejectedPOA_Click;
        }

        private void LoadPOAData(string statusToFilter)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SIGMADB"].ConnectionString))
            {
                try
                {
                    connection.Open();

                    // CHANGE: I added ", Status" to the SELECT list below
                    string query = @"SELECT ID, EventName, EventDate, ProposedBudget, VenueMode, Participants, Status 
                             FROM POA 
                             WHERE Status = @Status AND SubmittedBy = @SubmittedBy";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Status", statusToFilter);
                        cmd.Parameters.AddWithValue("@SubmittedBy", UserSession.Username);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvPOASummary.DataSource = dt;

                        // Hide ID (Technical column)
                        if (dgvPOASummary.Columns["ID"] != null)
                        {
                            dgvPOASummary.Columns["ID"].Visible = false;
                        }

                        // Hide Status (Optional: Hide it because the buttons already tell you the status)
                        // But the data is still there for the code to read!
                        if (dgvPOASummary.Columns["Status"] != null)
                        {
                            dgvPOASummary.Columns["Status"].Visible = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }




        private void LoadRemarks(int poaID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // We order by Date DESC so the latest remark is at the top
                    string query = @"SELECT DateCreated, StatusGiven, Remark 
                             FROM POARemarks 
                             WHERE POAID = @POAID 
                             ORDER BY DateCreated DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@POAID", poaID);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvRemarks.DataSource = dt;

                        // Optional: Make it look nice
                        dgvRemarks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvRemarks.Columns["DateCreated"].HeaderText = "Date";
                        dgvRemarks.Columns["StatusGiven"].HeaderText = "Status Set";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading remarks: " + ex.Message);
                }
            }
        }

        private void ManagePOA_Load(object sender, EventArgs e)
        {
            // By default, show Approved entries as you requested
            LoadPOAData("Approved");
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            POAEntry entryForm = new POAEntry();
            entryForm.ShowDialog();
        }

        private void btnApprovedPOA_Click(object sender, EventArgs e)
        {
            LoadPOAData("Approved");
        }

        private void btnPendingPOA_Click(object sender, EventArgs e)
        {
            LoadPOAData("Pending");
        }

        private void btnToRevisePOA_Click(object sender, EventArgs e)
        {
            // Make sure this spelling matches your Check Constraint in the DB exactly
            LoadPOAData("To be Revised");
        }

        private void btnRejectedPOA_Click(object sender, EventArgs e)
        {
            LoadPOAData("Rejected");
        }

        private void dgvPOASummary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPOASummary.Rows[e.RowIndex];

                // 1. Get ID (Existing logic)
                if (row.Cells["ID"].Value != DBNull.Value)
                {
                    int selectedID = Convert.ToInt32(row.Cells["ID"].Value);
                    LoadRemarks(selectedID); // Existing logic

                    // 2. CHECK STATUS FOR EDIT BUTTON
                    // Make sure your query in LoadPOAData actually includes "Status"
                    string status = row.Cells["Status"].Value.ToString();

                    if (status == "To be Revised")
                    {
                        btnEdit.Enabled = true;
                        _selectedPOAID = selectedID; // Save ID to a variable in ManagePOA class
                    }
                    else
                    {
                        btnEdit.Enabled = false;
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedPOAID != -1)
            {
                // Open POAEntry using the NEW Constructor (Edit Mode)
                POAEntry editForm = new POAEntry(_selectedPOAID);
                editForm.ShowDialog();

                // Refresh the list after they close the form to see changes
                LoadPOAData("To be Revised");

                // Reset
                btnEdit.Enabled = false;
                _selectedPOAID = -1;
            }
        }

    }
}
