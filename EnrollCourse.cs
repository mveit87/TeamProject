using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TeamProject
{

    public partial class EnrollCourse : Form
    {
        private void InitializeComponent()
        {
            using SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString);
            conn.Open(); // Ensure the connection is open

            // Fetching courses
            using SqlDataAdapter coursesAdapter = new SqlDataAdapter("SELECT * FROM Courses", conn);
            DataTable coursesTable = new DataTable();
            coursesAdapter.Fill(coursesTable);
            courseNameComboBox.DisplayMember = "CourseName";
            courseNameComboBox.DataSource = coursesTable;

            // Fetching users
            using SqlDataAdapter usersAdapter = new SqlDataAdapter("SELECT * FROM Users", conn);
            DataTable usersTable = new DataTable();
            usersAdapter.Fill(usersTable);
            userNameComboBox.DisplayMember = "Username";
            userNameComboBox.DataSource = usersTable;
        }
        private void enrollButton_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString);
            conn.Open(); // Ensure the connection is open
            // Get selected course and user
            string courseName = courseNameComboBox.Text;
            string userName = userNameComboBox.Text;
            // Insert enrollment record
            using SqlCommand cmd = new SqlCommand("INSERT INTO Enrollments (CourseName, Username) VALUES (@CourseName, @Username)", conn);
            cmd.Parameters.AddWithValue("@CourseName", courseName);
            cmd.Parameters.AddWithValue("@Username", userName);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Enrollment successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error enrolling in course: {ex.Message}");
            }
        }

    }
}


