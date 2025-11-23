using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Project_SIGMA__A_Budget_Request_Application_.Resources.Admin
{
    public partial class ViewBudgetDetails : Form
    {
        private int _poaID;
        string connectionString = ConfigurationManager.ConnectionStrings["SIGMADB"].ConnectionString;
        public ViewBudgetDetails()
        {
            InitializeComponent();
        }

        public ViewBudgetDetails(int poaID)
        {
            InitializeComponent();
            _poaID = poaID;
            LoadItems();
        }

        private void ViewBudgetDetails_Load(object sender, EventArgs e)
        {
        }

        private void LoadItems()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Fetch items
                    string query = "SELECT Particulars, Quantity, UnitPrice, TotalCost FROM POABudgetItems WHERE POAID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", _poaID);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvItems.AutoGenerateColumns = true;

                        dgvItems.DataSource = dt;

                        // FORMATTING
                        dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        if (dgvItems.Columns["UnitPrice"] != null)
                            dgvItems.Columns["UnitPrice"].DefaultCellStyle.Format = "C2";
                        if (dgvItems.Columns["TotalCost"] != null)
                            dgvItems.Columns["TotalCost"].DefaultCellStyle.Format = "C2";

                        // CALCULATE TOTAL FOR DISPLAY
                        decimal total = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            total += Convert.ToDecimal(row["TotalCost"]);
                        }
                        lblTotal.Text = total.ToString("C2");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
