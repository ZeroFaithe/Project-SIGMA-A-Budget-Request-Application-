using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SIGMA__A_Budget_Request_Application_
{
    public partial class ReimbursementFormAdmin : Form
    {
        private DataTable ReimbursementReviewTable;
        public ReimbursementFormAdmin()
        {
            InitializeComponent();
        }
    private void ReimbursementReviewGrid()
        {
            dgvReimbursements.Columns.Clear();
            dgvReimbursements.Columns.Add("FileName", "File");
            dgvReimbursements.Columns.Add("Date Submitted", "Date Submitted");
            dgvReimbursements.Columns.Add("Status", "Status");
            dgvReimbursements.Columns.Add("FilePath", "File Path");

            dgvReimbursements.DataSource = dgvReimbursements;
            dgvReimbursements.Columns["FilePath"].Visible = false;
        }
    private void Filters()
        {
            cmbPOA.Items.AddRange(new string[]
            {"All","Pending","Approved","Rejected"});

            /* using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT POA_Name FROM POA_Details", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbStatusFilter.Items.Add(reader["POA_Name"].ToString());
                }
            }*/
            cmbPOA.SelectedIndex = 0;
        }
        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbPOA.SelectedItem.ToString();

            // Status filter
            if (selected == "All" || selected == "Pending" || selected == "Approved" || selected == "Declined")
            {
                LoadReimbursementsByStatus(selected);
            }

            // POA filter (future logic)
            /*
            else
            {
                LoadReimbursementsByPOA(selected);
            }
            */
        }
        private void LoadReimbursementsByStatus(string status)
        {
           /* using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Reimbursements WHERE Status = @Status", conn);
                cmd.Parameters.AddWithValue("@Status", status);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReimbursementReview.DataSource = dt;
            }*/
        }

        private void LoadReimbursementsByPOA(string poaName)
        {
          /*  using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Reimbursements WHERE POA_Name = @POA", conn);
                cmd.Parameters.AddWithValue("@POA", poaName);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReimbursementReview.DataSource = dt;
            } */
        }


    }
}
