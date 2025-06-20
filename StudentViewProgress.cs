using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
    public partial class StudentViewProgress : Form
    {
        public StudentViewProgress()
        {
            InitializeComponent();
        }

        private void reauthenticateButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            //connects to database to grab user
            Debug.WriteLine("** grabbing user info **");
            DataTable dt1 = new DataTable();
            SqlConnection sqlConnection = new(Properties.Settings.Default.connString);
            using SqlConnection conn = sqlConnection;
            using SqlDataAdapter adapter1 = new("SELECT UserID, Username, PasswordHash FROM Users WHERE Username = @username", conn);
            adapter1.SelectCommand.Parameters.AddWithValue("@username", username);
            Debug.WriteLine("** SQL results for user info **");
            adapter1.Fill(dt1);
            string usernameResult = dt1.Rows[0]["Username"].ToString();
            string passwordResult = dt1.Rows[0]["PasswordHash"].ToString();
            string userIDResult = dt1.Rows[0]["UserID"].ToString();
            Debug.WriteLine(userIDResult + " " + usernameResult + " " + passwordResult);

            //verify authentication & provide degree progress upon success
            if (password == passwordResult)
            {
                DataTable dt2 = new DataTable();
                using SqlDataAdapter adapter2 = new("SELECT TotalCredits, GraduationDate FROM DegreeAudit WHERE StudentID = @studentid", conn);
                adapter2.SelectCommand.Parameters.AddWithValue("@studentid", userIDResult);
                Debug.WriteLine("** SQL results for degree audit **");
                adapter2.Fill(dt2);
                string totalCreditsResult = dt2.Rows[0]["TotalCredits"].ToString();
                string graduationDateResult = dt2.Rows[0]["GraduationDate"].ToString();
                Debug.WriteLine(totalCreditsResult + " " + graduationDateResult);
                totalCreditsLabel.Text = totalCreditsResult;
                graduationDateLabel.Text = graduationDateResult.ToString();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
            this.Hide();
        }
    }
}
