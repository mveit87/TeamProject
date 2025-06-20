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
        // This method is called when the form loads, it initializes the form components
        private void submitButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            string userType = userTypeTextBox.Text;

            if (IsValidInput(username, password, userType))
            {
                string connectionString = new(Properties.Settings.Default.connString); 
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
      
            return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) &&
                   (userType == "Administrator" || userType == "Faculty" || userType == "Student");
        }

        private string HashPassword(string password)
        {
           
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        // This method is called when the upload button is clicked, it opens a file dialog to select a file and uploads it to the specified project folder
        private void uploadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.Title = "Select a File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    MessageBox.Show("File selected: " + filePath);

                    // Define the destination path in the project folder
                    string projectFolder = @"C:\C:\Users\merrick\Desktop\ASP\Dropbox06\bin\Debug\net8.0\"; 
                    string fileName = Path.GetFileName(filePath);
                    string destinationPath = Path.Combine(projectFolder, fileName);

                    // Copy the file to the project folder
                    File.Copy(filePath, destinationPath, true); 
                    MessageBox.Show("File uploaded to: " + destinationPath);
                }
            }
            }
        }
    }



