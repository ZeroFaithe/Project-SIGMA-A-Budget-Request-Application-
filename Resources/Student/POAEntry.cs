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
    public partial class POAEntry : Form
    {
        private bool _isEditMode = false;
        private int _poaIDToEdit = -1;
        string connectionString = ConfigurationManager.ConnectionStrings["SIGMADB"].ConnectionString;
        public POAEntry()
        {
            InitializeComponent();
            _isEditMode = false;
        }

        public POAEntry(int poaID)
        {
            InitializeComponent();
            _isEditMode = true;
            _poaIDToEdit = poaID;

            LoadDataForEdit(); // Call the helper function
        }

        private void LoadDataForEdit()
        {
            // Change Button Text to indicate we are updating
            btnSaveEntry.Text = "UPDATE ENTRY";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM POA WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", _poaIDToEdit);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // PRE-FILL THE BOXES
                            txtEventName.Text = reader["EventName"].ToString();
                            dtpEventDate.Value = Convert.ToDateTime(reader["EventDate"]);
                            cmbOrganization.Text = reader["Organization"].ToString(); // Ensure text matches list items exactly
                            txtParticipants.Text = reader["Participants"].ToString();
                            txtVenue.Text = reader["VenueMode"].ToString();
                            txtObjectives.Text = reader["ObjectivesDescription"].ToString();
                        }
                    }
                }
            }
        }

        private void btnSaveEntry_Click(object sender, EventArgs e)
        {
            // 1. CONFIRMATION
            DialogResult dialogResult = MessageBox.Show(
                "Confirm Submission: This entry will be officially submitted for Admin approval.\n\n" +
                "Note: You cannot edit this entry while it is under review.\n\n" +
                "Do you want to proceed?",
                "Confirm Entry Submission",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No) return;

            // 2. FORCE CALCULATION (Ensure the Tag has the latest total)
            CalculateRowAndTotal();

            // Safety check for the total
            if (lblTotalBudget.Tag == null) lblTotalBudget.Tag = 0;
            decimal finalBudget = Convert.ToDecimal(lblTotalBudget.Tag);

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SIGMADB"].ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    int activePOAID = 0;

                    // 3. HANDLE THE MAIN POA (Header)
                    if (_isEditMode)
                    {
                        // --- UPDATE MODE ---
                        activePOAID = _poaIDToEdit; // We use the existing ID

                        string updateQuery = @"UPDATE POA SET 
                                       EventName=@EventName, EventDate=@EventDate, Organization=@Organization, 
                                       ProposedBudget=@Total, Participants=@Participants, VenueMode=@VenueMode, 
                                       ObjectivesDescription=@ObjectivesDescription, 
                                       Status='Pending', SubmittedBy=@SubmittedBy 
                                       WHERE ID=@ID";

                        using (SqlCommand cmd = new SqlCommand(updateQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@EventName", txtEventName.Text);
                            cmd.Parameters.AddWithValue("@EventDate", dtpEventDate.Value);
                            cmd.Parameters.AddWithValue("@Organization", cmbOrganization.Text);
                            cmd.Parameters.AddWithValue("@Total", finalBudget); // New Total
                            cmd.Parameters.AddWithValue("@Participants", txtParticipants.Text);
                            cmd.Parameters.AddWithValue("@VenueMode", txtVenue.Text);
                            cmd.Parameters.AddWithValue("@ObjectivesDescription", txtObjectives.Text);
                            cmd.Parameters.AddWithValue("@SubmittedBy", UserSession.Username);
                            cmd.Parameters.AddWithValue("@ID", activePOAID);
                            cmd.ExecuteNonQuery();
                        }

                        // IMPORTANT: Delete OLD items so we can insert the NEW ones (Clean slate)
                        string deleteItemsQuery = "DELETE FROM POABudgetItems WHERE POAID = @ID";
                        using (SqlCommand cmdDelete = new SqlCommand(deleteItemsQuery, connection, transaction))
                        {
                            cmdDelete.Parameters.AddWithValue("@ID", activePOAID);
                            cmdDelete.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // --- INSERT MODE ---
                        string insertQuery = @"INSERT INTO POA 
                                       (EventName, EventDate, Organization, ProposedBudget, Participants, VenueMode, ObjectivesDescription, SubmittedBy) 
                                       VALUES 
                                       (@EventName, @EventDate, @Organization, @Total, @Participants, @VenueMode, @ObjectivesDescription, @SubmittedBy); 
                                       SELECT SCOPE_IDENTITY();"; // Get the New ID

                        using (SqlCommand cmd = new SqlCommand(insertQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@EventName", txtEventName.Text);
                            cmd.Parameters.AddWithValue("@EventDate", dtpEventDate.Value);
                            cmd.Parameters.AddWithValue("@Organization", cmbOrganization.Text);
                            cmd.Parameters.AddWithValue("@Total", finalBudget);
                            cmd.Parameters.AddWithValue("@Participants", txtParticipants.Text);
                            cmd.Parameters.AddWithValue("@VenueMode", txtVenue.Text);
                            cmd.Parameters.AddWithValue("@ObjectivesDescription", txtObjectives.Text);
                            cmd.Parameters.AddWithValue("@SubmittedBy", UserSession.Username);

                            // Execute and get the new ID
                            activePOAID = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }

                    // 4. SAVE THE BUDGET ITEMS (Loop through Grid)
                    foreach (DataGridViewRow row in dgvBudgetItems.Rows)
                    {
                        if (!row.IsNewRow) // Skip the empty bottom row
                        {
                            // Safe Data Retrieval
                            string particular = Convert.ToString(row.Cells["colParticulars"].Value);
                            decimal units = 0, price = 0, total = 0;

                            decimal.TryParse(Convert.ToString(row.Cells["colUnits"].Value), out units);
                            decimal.TryParse(Convert.ToString(row.Cells["colUnitPrice"].Value), out price);
                            decimal.TryParse(Convert.ToString(row.Cells["colTotal"].Value), out total);

                            // Insert Query
                            string itemQuery = @"INSERT INTO POABudgetItems (POAID, Particulars, Quantity, UnitPrice, TotalCost) 
                                         VALUES (@POAID, @Part, @Qty, @Price, @RowTotal)";

                            using (SqlCommand cmdItem = new SqlCommand(itemQuery, connection, transaction))
                            {
                                cmdItem.Parameters.AddWithValue("@POAID", activePOAID);
                                cmdItem.Parameters.AddWithValue("@Part", particular);
                                cmdItem.Parameters.AddWithValue("@Qty", units);
                                cmdItem.Parameters.AddWithValue("@Price", price);
                                cmdItem.Parameters.AddWithValue("@RowTotal", total);
                                cmdItem.ExecuteNonQuery();
                            }
                        }
                    }

                    // 5. COMMIT TRANSACTION (Save Everything)
                    transaction.Commit();

                    if (_isEditMode)
                        MessageBox.Show("Success! Entry updated and re-submitted.");
                    else
                        MessageBox.Show("Success! POA and Budget Breakdown Submitted.");

                    // Clear and Close
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Undo changes if error occurs
                    MessageBox.Show("Error saving data: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void POAEntry_Load(object sender, EventArgs e)
        {

        }

        private void dgvBudgetItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculateRowAndTotal();
        }

        private void CalculateRowAndTotal()
        {
            decimal grandTotal = 0;

            foreach (DataGridViewRow row in dgvBudgetItems.Rows)
            {
                // Skip the empty bottom row
                if (row.IsNewRow) continue;

                // 1. GET VALUES SAFELY
                decimal units = 0;
                decimal price = 0;

                // TryParse prevents crashing if user types letters or leaves it empty
                decimal.TryParse(Convert.ToString(row.Cells["colUnits"].Value), out units);
                decimal.TryParse(Convert.ToString(row.Cells["colUnitPrice"].Value), out price);

                // 2. CALCULATE ROW TOTAL
                decimal rowTotal = units * price;
                row.Cells["colTotal"].Value = rowTotal.ToString("N2"); // Display row total

                // 3. ADD TO GRAND TOTAL
                grandTotal += rowTotal;
            }

            // 4. DISPLAY GRAND TOTAL
            lblTotalBudget.Text = "Total Proposed Budget: " + grandTotal.ToString("C2");

            // Store the raw number in the Label's Tag so we can grab it easily for the database
            lblTotalBudget.Tag = grandTotal;
        }
    }
}
