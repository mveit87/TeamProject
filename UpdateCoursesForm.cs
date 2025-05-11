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
    public partial class UpdateCoursesForm : Form
    {
        public UpdateCoursesForm()
        {
            InitializeComponent();
        }

        private void UpdateCoursesForm_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new(Properties.Settings.Default.connString);
            using SqlConnection conn = sqlConnection;
            using SqlDataAdapter adapter = new("SELECT * FROM Courses", conn);
            DataTable coursesTable = new();
            adapter.Fill(coursesTable);
            coursesListbox.DisplayMember = "courseName";
            coursesListbox.ValueMember = "coursesId";
            coursesListbox.DataSource = coursesTable;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //saves added advisee to database
            using SqlConnection conn = new(Properties.Settings.Default.connString);
            using SqlCommand comd = new("INSERT INTO Courses(courseName, credits, semester ) VALUES(@courseName, @credits, @semester)", conn);
            conn.Open();
            comd.Parameters.AddWithValue("@courseName", courseNameTextBox.Text);
            comd.Parameters.AddWithValue("@credits", creditsTextBox.Text);
            comd.Parameters.AddWithValue("@semester", semesterOfferedTextBox.Text);
            comd.ExecuteNonQuery();
            MessageBox.Show("Course saved.");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new(Properties.Settings.Default.connString);
            using SqlCommand comd = new("DELETE FROM Courses WHERE coursesName = @courseName", conn);
            conn.Open();
            comd.Parameters.AddWithValue("@courseName", courseNameTextBox.Text);
            comd.ExecuteNonQuery();
            MessageBox.Show("Course deleted.");
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new(Properties.Settings.Default.connString);
            using SqlCommand comd = new("SELECT courseName FROM Courses WHERE courseName LIKE @courseName", conn);
            comd.Parameters.AddWithValue("@courseName", "%" + courseNameTextBox.Text + "%");
            conn.Open();
            using SqlDataReader reader = comd.ExecuteReader();
            coursesListbox.Items.Clear(); // Clear previous results
            while (reader.Read())
            {
                coursesListbox.Items.Add(reader["courseName"].ToString());
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

