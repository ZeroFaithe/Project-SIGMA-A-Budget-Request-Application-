using BCrypt.Net;
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

        private void loginBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn.PerformClick();
            }
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            AdminFrame adminFrame = new AdminFrame();
            StudentFrame studentFrame = new StudentFrame();

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

                    // 1. UPDATED QUERY: We now select 'Username' as well
                    string query = "SELECT PasswordHash, Role, Username FROM Users WHERE Email = @email";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", emailTxt.Text);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHashedPassword = reader.GetString(0); // Index 0: PasswordHash
                                string userRole = reader.GetString(1);             // Index 1: Role
                                string dbUsername = reader.GetString(2);           // Index 2: Username (NEW)

                                // Verify Password
                                if (BCrypt.Net.BCrypt.Verify(passwordTxt.Text, storedHashedPassword))
                                {
                                    // 2. SAVE TO SESSION (This is the crucial part!)
                                    // Now any other form (like POAEntry) can access these variables.
                                    UserSession.Username = dbUsername;
                                    UserSession.Email = emailTxt.Text;
                                    UserSession.Role = userRole;

                                    // 3. NAVIGATE BASED ON ROLE
                                    if (userRole == "admin")
                                    {
                                        this.Hide();
                                        adminFrame.ShowDialog();
                                        this.Close();
                                    }
                                    else if (userRole == "representative" || userRole == "council")
                                    {
                                        // Combined these since they both go to StudentFrame
                                        this.Hide();
                                        studentFrame.ShowDialog();
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Role not recognized.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("User not found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to log in: " + ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
