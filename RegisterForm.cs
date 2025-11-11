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
    public partial class RegisterForm : Form
    {
        string roleQuery;
        public RegisterForm(string role)
        {
            InitializeComponent();
            roleQuery = role;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passHidden_Click(object sender, EventArgs e)
        {

        }

        private void passShown_Click(object sender, EventArgs e)
        {

        }

        private void confirmHidden_Click(object sender, EventArgs e)
        {

        }

        private void confirmShow_Click(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (usernameTxt.Text == "" || passwordTxt.Text == "" || confirmPassTxt.Text == "" || emailTxt.Text == "")
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (passwordTxt.Text != confirmPassTxt.Text)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }

                string connectionString = ConfigurationManager.ConnectionStrings["SIGMADB"].ConnectionString;
                string hashedPass = BCrypt.Net.BCrypt.HashPassword(passwordTxt.Text);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Users (Username, PasswordHash, Role, Email) VALUES (@username, @password, @role, @email)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", usernameTxt.Text);
                        command.Parameters.AddWithValue("@password", hashedPass);
                        command.Parameters.AddWithValue("@role", roleQuery);
                        command.Parameters.AddWithValue("@email", emailTxt.Text);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Registration successful!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
