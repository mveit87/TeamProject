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
    public partial class AddFacultyForm : Form
    {
        public AddFacultyForm()
        {
            InitializeComponent();
        }

        private void AddFacultyForm_Load(object sender, EventArgs e)
        {
            //connects to database to add advisee
            SqlConnection sqlConnection = new(Properties.Settings.Default.connString);
            using SqlConnection conn = sqlConnection;
            using SqlDataAdapter adapter = new("SELECT * FROM FacultyCourses", conn);
            DataTable facultyCoursesTable = new();

        }

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
    }
}
