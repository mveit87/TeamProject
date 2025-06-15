using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TeamProject
{

    public partial class EnrollCourse : Form
    {
        public EnrollCourse()
        { 
            InitializeComponent(); 
        }
        // This method is called when the form loads, it populates the course and user combo boxes with data from the Courses and Users tables
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


