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
        // This method is called when the form loads, it initializes the form components and allows user to search for students, courses, or faculty
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

        // This method is called when the find course button is clicked, it retrieves courses based on the course name entered in the text box
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
        // This method is called when the find faculty button is clicked, it retrieves faculty courses based on the faculty name entered in the text box
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
        // This method is called when the clear button is clicked, it clears the text boxes and the DataGridView
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear specific text boxes
            studentNameTextBox.Text = string.Empty;
            courseNameTextBox.Text = string.Empty;
            facultyTextBox.Text = string.Empty;

            // Clear the DataGridView
            studentDataGridView.Rows.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }
    }
}
