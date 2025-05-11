using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
    public partial class LoginForm : Form
    {
        // Hardcoded user credentials for demonstration
        private readonly string adminUsername = "admin";
        private readonly string adminPassword = "admin123";
        private readonly string facultyUsername = "faculty";
        private readonly string facultyPassword = "faculty123";
        private readonly string studentUsername = "student";
        private readonly string studentPassword = "student123";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            // Simulated user data for demonstration purposes
            if (username == "admin" && password == "admin123")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
            else if (username == "student" && password == "student123")
            {
                StudentForm studentForm = new StudentForm();
                studentForm.Show();
                this.Hide();
            }
            else if (username == "faculty" && password == "faculty123")
            {
                FacultyForm facultyForm = new FacultyForm();
                facultyForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    


private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        

        }
    }

