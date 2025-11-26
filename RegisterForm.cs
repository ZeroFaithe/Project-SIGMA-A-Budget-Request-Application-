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
using System.Text.RegularExpressions;
using System.Net.Mail;

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
            passHidden.Hide();
            passHidden.Enabled = false;
            passwordTxt.UseSystemPasswordChar = false;
            passShown.Show();
            passShown.Enabled = true;
        }

        private void passShown_Click(object sender, EventArgs e)
        {
            passShown.Hide();
            passShown.Enabled = false;
            passwordTxt.UseSystemPasswordChar = true;
            passHidden.Show();
            passHidden.Enabled = true;
        }

        private void confirmHidden_Click(object sender, EventArgs e)
        {
            confirmHidden.Hide();
            confirmHidden.Enabled = false;
            confirmPassTxt.UseSystemPasswordChar = false;
            confirmShow.Show();
            confirmShow.Enabled = true;
        }

        private void confirmShow_Click(object sender, EventArgs e)
        {
            confirmShow.Hide();
            confirmShow.Enabled = false;
            confirmPassTxt.UseSystemPasswordChar = true;
            confirmHidden.Show();
            confirmHidden.Enabled = true;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameTxt.Text?.Trim() ?? string.Empty;
                string password = passwordTxt.Text ?? string.Empty;
                string confirm = confirmPassTxt.Text ?? string.Empty;
                string email = emailTxt.Text?.Trim() ?? string.Empty;

                if (username == "" || password == "" || confirm == "" || email == "")
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (password != confirm)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }

                // Password minimum length
                if (password.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters long.");
                    return;
                }

                // Email format validation
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Please enter a valid email address (must contain @ and a domain).");
                    return;
                }

                // When creating an admin account require an @auf.edu.ph address
                if (string.Equals(roleQuery, "admin"))
                {
                    if (!email.EndsWith("@auf.edu.ph", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Admin accounts must use an @auf.edu.ph email address.");
                        return;
                    }
                }

                // When creating a student account require an @student.auf.edu.ph address
                if (string.Equals(roleQuery, "council") || string.Equals(roleQuery, "representative"))
                {
                    if (!email.EndsWith("@student.auf.edu.ph", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Student accounts must use an @student.auf.edu.ph email address.");
                        return;
                    }
                    
                }

                string connectionString = ConfigurationManager.ConnectionStrings["SIGMADB"].ConnectionString;
                string hashedPass = BCrypt.Net.BCrypt.HashPassword(password);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Users (Username, PasswordHash, Role, Email) VALUES (@username, @password, @role, @email)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", hashedPass);
                        command.Parameters.AddWithValue("@role", roleQuery);
                        command.Parameters.AddWithValue("@email", email);
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

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Quick regex check to rule out obvious invalid values, then use MailAddress for stronger validation
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return false;

            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}