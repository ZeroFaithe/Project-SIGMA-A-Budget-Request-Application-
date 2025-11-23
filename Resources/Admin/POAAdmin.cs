using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class POAAdmin : Form
    {
        private int _selectedPOAID = -1;
        string connectionString = ConfigurationManager.ConnectionStrings["SIGMADB"].ConnectionString;
        public POAAdmin()
        {
            InitializeComponent();

            // Ensure UI events are wired (Designer currently doesn't wire them)
            dgvPendingPOA.CellClick += dgvPendingPOA_CellClick;
            btnApprove.Click += btnApprove_Click;
            btnToRevise.Click += btnToRevise_Click;
            btnReject.Click += btnReject_Click;

            // Optional usability tweaks
            dgvPendingPOA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPendingPOA.MultiSelect = false;
        }


        private void LoadPendingPOA()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ID, POACode, EventName, ProposedBudget, DateSubmitted, SubmittedBy FROM POA WHERE Status = 'Pending'";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvPendingPOA.DataSource = dt;

                    // Hide ID
                    if (dgvPendingPOA.Columns["ID"] != null) dgvPendingPOA.Columns["ID"].Visible = false;

                    // Format Budget
                    if (dgvPendingPOA.Columns["ProposedBudget"] != null) dgvPendingPOA.Columns["ProposedBudget"].DefaultCellStyle.Format = "C2";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        // 2. FORM LOAD EVENT
        private void POAAdmin_Load(object sender, EventArgs e)
        {
            LoadPendingPOA(); // We just call the function here
        }

        // 3. ROW CLICK EVENT
        private void dgvPendingPOA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPendingPOA.Rows[e.RowIndex];

                // Safety check: Ensure the cell value isn't null
                if (row.Cells["ID"].Value != DBNull.Value)
                {
                    _selectedPOAID = Convert.ToInt32(row.Cells["ID"].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT * FROM POA WHERE ID = @ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", _selectedPOAID);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtEvent.Text = reader["EventName"].ToString();
                                    txtDate.Text = Convert.ToDateTime(reader["EventDate"]).ToShortDateString();
                                    txtOrganization.Text = reader["Organization"].ToString();
                                    txtParticipants.Text = reader["Participants"].ToString();
                                    txtVenue.Text = reader["VenueMode"].ToString();
                                    rtbObjectivesDescription.Text = reader["ObjectivesDescription"].ToString();

                                    // Safe Budget Conversion
                                    if (decimal.TryParse(reader["ProposedBudget"].ToString(), out decimal budget))
                                    {
                                        txtBudget.Text = budget.ToString("N2");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        // 4. MAIN PROCESS LOGIC
        private void ProcessDecision(string newStatus)
        {
            if (_selectedPOAID == -1)
            {
                MessageBox.Show("Please select a pending entry first.");
                return;
            }

            // 2. Validation: Mandatory remarks for negative actions
            if ((newStatus == "Rejected" || newStatus == "To be Revised") && string.IsNullOrWhiteSpace(rtbRemarks.Text))
            {
                MessageBox.Show("You must provide a remark explaining your decision.", "Remark Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Confirmation
            DialogResult check = MessageBox.Show($"Are you sure you want to mark this as {newStatus}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 4. Update Status in POA Table
                string updateQuery = "UPDATE POA SET Status = @Status WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.Parameters.AddWithValue("@ID", _selectedPOAID);
                    cmd.ExecuteNonQuery();
                }

                // 5. INSERT REMARK (Modified Logic)
                // We create a variable to hold the text we want to save
                string remarkToSave = rtbRemarks.Text.Trim();

                // IF the status is Approved AND they didn't type anything, auto-fill the text
                if (newStatus == "Approved" && string.IsNullOrEmpty(remarkToSave))
                {
                    remarkToSave = "Request Approved.";
                }

                // Now we insert if there is text (which is always true for Approved now)
                if (!string.IsNullOrEmpty(remarkToSave))
                {
                    string remarkQuery = "INSERT INTO POARemarks (POAID, Remark, StatusGiven, DateCreated) VALUES (@POAID, @Remark, @Status, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(remarkQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@POAID", _selectedPOAID);
                        cmd.Parameters.AddWithValue("@Remark", remarkToSave); // Use the variable, not the textbox
                        cmd.Parameters.AddWithValue("@Status", newStatus);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Entry marked as {newStatus}.");

                // 6. Clean Up
                LoadPendingPOA();
                ClearTextFields();
                _selectedPOAID = -1;
            }
        }

        // Helper to clean up the code
        private void ClearTextFields()
        {
            txtEvent.Clear();
            txtDate.Clear();
            txtBudget.Clear();
            txtOrganization.Clear();
            txtParticipants.Clear();
            txtVenue.Clear();
            rtbObjectivesDescription.Clear();
            rtbRemarks.Clear();
        }

        // 5. BUTTON CLICK EVENTS (You need to connect these in Design View!)
        private void btnApprove_Click(object sender, EventArgs e)
        {
            ProcessDecision("Approved");
        }

        private void btnToRevise_Click(object sender, EventArgs e)
        {
            ProcessDecision("To be Revised");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            ProcessDecision("Rejected");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_selectedPOAID == -1)
            {
                MessageBox.Show("Please select an entry first.");
                return;
            }

            // Open the pop-up form passing the selected ID
            ViewBudgetDetails detailsForm = new ViewBudgetDetails(_selectedPOAID);
            detailsForm.ShowDialog();
        }
    }
}
