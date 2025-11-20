using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_SIGMA__A_Budget_Request_Application_
{
    public partial class ReimbursementFormStudent : Form
    {
        private int StudentID;
        private String fileName;
        private String fullPath;
        public ReimbursementFormStudent()
        {
            InitializeComponent();
        }

        private void ReimbursementFormStudent_Load(object sender, EventArgs e)
        {
            ReimbursementGrid();
        }
        private void ReimbursementGrid()
        {
            dgvReimbursementEntry.Columns.Clear();
            dgvReimbursementEntry.Columns.Add("FileName", "File Name");
            dgvReimbursementEntry.Columns.Add("ReceiptPath", "Receipt Path");
            dgvReimbursementEntry.Columns.Add("DateSubmitted", "Date Submitted");
            dgvReimbursementEntry.Columns.Add("Status", "Status");
            dgvReimbursementEntry.Columns["ReceiptPath"].Visible = false;
        }
        private void btnUploadReceipts_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.png";
            if (openfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = openfd.FileName;
                string fileName = System.IO.Path.GetFileName(filePath);
                // Code to handle the uploaded file
                MessageBox.Show("File uploaded: " + filePath);
                dgvReimbursementEntry.Rows.Add(fileName, fullPath,DateTime.Now.ToString("yyyy-MM-dd HH:mm"), "Pending");
            }
        }

        private void btnSubmitReport_Click(object sender, EventArgs e)
        {
            string connStr = "Server=LAPTOP-NAPN3445\\SQLEXPRESS;Database=ProjectSIGMA;Trusted_Connection=True;";
            string sql = @"INSERT INTO ReimbursementReports 
                   (POA_ID, StudentID, FileName, ReceiptPath, Status, DateSubmitted) 
                   VALUES (@POA_ID, @StudentID, @FileName, @ReceiptPath, @Status, @DateSubmitted)";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                bool hasReceipt = false;

                foreach (DataGridViewRow row in dgvReimbursementEntry.Rows)
                {
                    if (row.IsNewRow) continue;
                    var path = row.Cells["ReceiptPath"].Value?.ToString();
                    if (string.IsNullOrEmpty(path)) continue;

                    hasReceipt = true;
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@POA_ID", cmbPOA.SelectedValue);
                        cmd.Parameters.AddWithValue("@StudentID", StudentID);
                        cmd.Parameters.AddWithValue("@FileName", System.IO.Path.GetFileName(path));
                        cmd.Parameters.AddWithValue("@ReceiptPath", path);
                        cmd.Parameters.AddWithValue("@Status", "Pending");
                        cmd.Parameters.AddWithValue("@DateSubmitted", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }

                if (!hasReceipt)
                    MessageBox.Show("Upload at least one receipt before submitting.", "Warning");
                else
                    MessageBox.Show("Receipts submitted successfully!", "Success");
            }
        }
    }
}
