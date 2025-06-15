using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
    public partial class AddFacultyForm : Form
    {
        public AddFacultyForm()
        {
            InitializeComponent();
        }

        private void AddFacultyForm_Load(object sender, EventArgs e)
        {

        }
        // This method is called when the add button is clicked, it saves the new faculty member to the FacultyCourses table
        private void addButton_Click(object sender, EventArgs e)
        {
            // Saves added advisee to database
            using SqlConnection conn = new(Properties.Settings.Default.connString);
            using SqlCommand comd = new("INSERT INTO FacultyCourses(facultyName) VALUES(@facultyName)", conn);
            conn.Open();
            comd.Parameters.AddWithValue("@facultyName", facultyNameTextBox.Text);

            comd.ExecuteNonQuery();
            MessageBox.Show("Faculty Member saved.");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        // This method is called when the search button is clicked, it searches for faculty members in the FacultyCourses table based on the input from the search text box
        private void searchButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("** search button clicked, grabbing from FacultyCourses table **");
            string fName = searchTextBox.Text;
            Debug.WriteLine("text box value: " + fName);
            SqlConnection sqlConnection = new(Properties.Settings.Default.connString);
            using SqlConnection conn = sqlConnection;
            using SqlDataAdapter adapter = new("SELECT FC.FacultyName, FC.CourseName FROM FacultyCourses AS FC WHERE FacultyName LIKE @facultyName", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@facultyName", fName);
            DataTable facultyCoursesTable = new();
            adapter.Fill(facultyCoursesTable);
            Debug.WriteLine("** search results **");
            foreach (DataRow row in facultyCoursesTable.Rows)
            {
                string facultyNameResult = row["FacultyName"].ToString();
                string courseNameResult = row["CourseName"].ToString();
                Debug.WriteLine("faculty name: " + facultyNameResult);
                Debug.WriteLine("course name: " + courseNameResult);
            }
            dataGridView1.DataSource = facultyCoursesTable;
            dataGridView1.AutoResizeColumns();
        }
    }
}
