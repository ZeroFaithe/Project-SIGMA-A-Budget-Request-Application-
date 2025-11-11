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
    public partial class RoleSelector : Form
    {
        public RoleSelector()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm("admin");
            this.Hide();
            registerForm.ShowDialog();
            this.Close();
        }

        private void repBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm("representative");    
            this.Hide();
            registerForm.ShowDialog();
            this.Close();
        }

        private void councilBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm("council");
            this.Hide();
            registerForm.ShowDialog();
            this.Close();
        }
    }
}
