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
    public partial class LiquidationFormAdmin : Form
    {
        public LiquidationFormAdmin()
        {
            InitializeComponent();
        }

        private void dgvLiquidationReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnApproveReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liquidation Report Approved.");
            /* For datagridview
             dgvLiquidationReport.Rows[e.RowIndex].Cells["Status"].Value = "Approved";
             */
        }

        private void btnDeclineReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liquidation Report Declined.");
            /* For datagridview
             dgvLiquidationReport.Rows[e.RowIndex].Cells["Status"].Value = "Declined";
             */
        }

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
            saveFileDialog.Title = "Save Report as";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, "Report details go here...");
                MessageBox.Show("Report saved successfully 💾");
            }
        }
    }
}
