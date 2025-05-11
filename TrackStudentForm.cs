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
    public partial class TrackStudentForm : Form
    {
        public TrackStudentForm()
        {
            InitializeComponent();
        }

        private void findStudentButton_Click(object sender, EventArgs e)
        {
            string studentName = studentNameTextBox.Text;
            using SqlConnection conn = new(Properties.Settings.Default.connString);
            using SqlDataAdapter adapter = new($"SELECT * FROM Users WHERE UserType = @userType", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@userType", "Student"); // Correctly set the user type to "Student"
            DataTable userTable = new(); // Ensure the variable name matches
            adapter.Fill(userTable);
            studentDataGridView.DataSource = userTable; // Use the correct variable name
        }


        private void findCourseButton_Click(object sender, EventArgs e)
        {
            string courseName = courseNameTextBox.Text;
            using SqlConnection conn = new(Properties.Settings.Default.connString);
            using SqlDataAdapter adapter = new($"SELECT * FROM Courses WHERE CourseName = @courseName", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@courseName", courseName);
            DataTable coursesTable = new();
            adapter.Fill(coursesTable);
            studentDataGridView.DataSource = coursesTable;
        }

        private void findFacultyButton_Click(object sender, EventArgs e)
        {
            string facultyName = facultyTextBox.Text;
            using SqlConnection conn = new(Properties.Settings.Default.connString);
            using SqlDataAdapter adapter = new($"SELECT * FROM FacultyCourses WHERE FacultyName = @facultyName", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@facultyName", facultyName);
            DataTable facultyTable = new();
            adapter.Fill(facultyTable);
            studentDataGridView.DataSource = facultyTable;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear all text boxes
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
            }

            // Clear the DataGridView
            studentDataGridView.Rows.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
