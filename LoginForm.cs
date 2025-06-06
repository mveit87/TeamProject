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
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace TeamProject
{
    public partial class LoginForm : Form
    {
       

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            string userType = userTypeTextBox.Text;
            //connects to database to grab user
            Debug.WriteLine("** grabbing user info **");
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new(Properties.Settings.Default.connString);
            using SqlConnection conn = sqlConnection;
            using SqlDataAdapter adapter = new("SELECT Username, PasswordHash, UserType FROM Users WHERE Username = @username", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@username", username);
            Debug.WriteLine("** SQL results **");
            adapter.Fill(dt);
            int count = dt.Rows.Count;
            Debug.WriteLine("row count: " + count);
            string usernameResult = dt.Rows[0]["Username"].ToString();
            string passwordResult = dt.Rows[0]["PasswordHash"].ToString();
            string userTypeResult = dt.Rows[0]["UserType"].ToString();
            Debug.WriteLine(usernameResult);
            Debug.WriteLine(passwordResult);
            Debug.WriteLine(userTypeResult);

            // check if user can log in
            if (password == passwordResult)
            {
                if (userTypeResult == "Administrator")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();
                }
                else if (userTypeResult == "Student")
                {
                    StudentForm studentForm = new StudentForm();
                    studentForm.Show();
                    this.Hide();
                }
                else if (userTypeResult == "Faculty")
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
            else if (count < 1)
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
            else if (password != passwordResult)
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
            else 
            {
                MessageBox.Show("An issue has occured.  Please contact your administrator.");
            }
        }



        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        

        }
    }

