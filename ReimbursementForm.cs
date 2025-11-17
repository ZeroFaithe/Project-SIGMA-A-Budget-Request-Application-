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
        string currentUserRole = "Student";

        public ReimbursementFormAdmin()
        {
            InitializeComponent();
        }
        private void ReimbursementForm_Load(object sender, EventArgs e)
        {
            if (currentUserRole == "Student")
            {
                if (tcReimbursement.TabPages.Contains(tcAdmin))
                    tcReimbursement.TabPages.Remove(tcAdmin);

                tcReimbursement.SelectedTab = tcStudent;
            }
            else if (currentUserRole == "Admin")
            {
                if (tcReimbursement.TabPages.Contains(tcStudent))
                    tcReimbursement.TabPages.Remove(tcStudent);

                tcReimbursement.SelectedTab = tcAdmin;
            }
        }
        private void tcReimbursement_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // Prevent switching if more than one tab exists
            if (tcReimbursement.TabPages.Count == 1)
                e.Cancel = true;
        }

    }
}
