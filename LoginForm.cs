using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using BCrypt.Net;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SIGMA__A_Budget_Request_Application_
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RoleSelector roleSelector = new RoleSelector();
            this.Hide();
            roleSelector.ShowDialog();
            this.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Dashboard_Form dashboard_Form = new Dashboard_Form();
            
            if (string.IsNullOrWhiteSpace(emailTxt.Text) || string.IsNullOrWhiteSpace(passwordTxt.Text))
            {
                MessageBox.Show("Please enter both email and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SIGMADB"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT PasswordHash, Role FROM Users WHERE Email = @email";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", emailTxt.Text);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHashedPassword = reader.GetString(0);
                                string userRole = reader.GetString(1);
                                if (BCrypt.Net.BCrypt.Verify(passwordTxt.Text, storedHashedPassword))
                                {
                                    this.Hide();
                                    dashboard_Form.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("User not found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to log in: " + ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
