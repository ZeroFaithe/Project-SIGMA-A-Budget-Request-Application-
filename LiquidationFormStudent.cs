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
        public LiquidationFormStudent()
        {
            InitializeComponent();
        }

        private void LiquidationFormStudent_Load(object sender, EventArgs e)
        {
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
                    // You can add logic to preview or store the file paths, FOR LATER
                    MessageBox.Show($"Uploaded: {Path.GetFileName(file)}");
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
            MessageBox.Show("Liquidation report submitted successfully!");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
           
        }
    }
}
