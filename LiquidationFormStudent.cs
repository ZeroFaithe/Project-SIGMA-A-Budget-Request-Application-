using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace Project_SIGMA__A_Budget_Request_Application_
{
    public partial class LiquidationFormStudent : Form
    {
        private DataTable liquidationTable;
        public LiquidationFormStudent()
        {
            InitializeComponent();
        }

        private void LoadBudgetSummary()
        {
          /*  using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT RequestID, EventTitle, ApprovedBudget, DateRequested FROM BudgetRequests WHERE Status = 'Approved' AND StudentID = @StudentID", conn);

                da.SelectCommand.Parameters.AddWithValue("@StudentID", currentStudentID); // pass this in from login/session
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBudgetSummary.DataSource = dt;
                dgvBudgetSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            } */
        }
        private void LiquidationFormStudent_Load(object sender, EventArgs e)
        {
            liquidationTable = new DataTable();
            liquidationTable.Columns.Add("FileName");
            liquidationTable.Columns.Add("FilePath");
            liquidationTable.Columns.Add("DateSubmitted");
            liquidationTable.Columns.Add("Status");

            dgvLiquidationSummary.DataSource = liquidationTable;            
            dgvLiquidationSummary.Columns["FilePath"].Visible = false;
            cmbPOA.Items.AddRange(new string[]
                {
                    "Tech Talk",        
                    "Hackathon 2025",
                    "College Week"
                });
            /*  using (SqlConnection conn = new SqlConnection(connectionString))
              {
                  conn.Open();
                  SqlCommand cmd = new SqlCommand("SELECT POA_Name FROM POA_Details", conn);
                  SqlDataReader reader = cmd.ExecuteReader();

                  while (reader.Read())
                  {
                      cmbPOA.Items.Add(reader["POA_Name"].ToString());
                  }
              }

              */
        }

        private void btnUploadReceipts_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFile.Multiselect = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFile.FileNames)
                {
                    string fileName = Path.GetFileName(file);
                    dgvLiquidationSummary.Rows.Add(fileName, file, DateTime.Now.ToString("yyyy-MM-dd HH:mm"), "Pending");
                }
            }
        }

        private void btnSubmitReport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbPOA.SelectedItem?.ToString()))
            {
                MessageBox.Show("Please select from POA before submitting.");
                return;
            }
            if (dgvLiquidationSummary.Rows.Count == 0 || 
                dgvLiquidationSummary.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
            {
                MessageBox.Show("Please files before submitting.");
                return;
            }



                /*using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    foreach (DataGridViewRow row in dgvLiquidationSummary.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            // Insert logic here
                        }
                    }
                }*/
                MessageBox.Show("Liquidation report submitted successfully!");
        }

        private void LiquidationGrid()
        {
            dgvLiquidationSummary.Columns.Clear();
            dgvLiquidationSummary.Columns.Add("FileName", "File Name");
            dgvLiquidationSummary.Columns.Add("FilePath", "File Path");
            dgvLiquidationSummary.Columns.Add("DateSubmitted", "Date Uploaded");
            dgvLiquidationSummary.Columns.Add("Status", "Status");

            dgvLiquidationSummary.Columns["FilePath"].Visible = false;
        
        }
    }
}
