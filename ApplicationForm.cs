using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            string userType = userTypeTextBox.Text;

            if (IsValidInput(username, password, userType))
            {
                string connectionString = new(Properties.Settings.Default.connString); // Update with your connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Users (Username, PasswordHash, UserType) VALUES (@Username, @PasswordHash, @UserType)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@PasswordHash", password);
                        command.Parameters.AddWithValue("@UserType", userType);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                MessageBox.Show("User registered successfully!");
            }
            else
            {
                MessageBox.Show("Invalid input. Please check your details.");
            }
        }

        private bool IsValidInput(string username, string password, string userType)
        {
            // Add validation logic (e.g., check for empty fields, valid user type)
            return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) &&
                   (userType == "Administrator" || userType == "Faculty" || userType == "Student");
        }

        private string HashPassword(string password)
        {
            // Implement a hashing algorithm (e.g., SHA256) to hash the password (will be implemented at a later date)
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

