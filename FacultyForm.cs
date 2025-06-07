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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TeamProject
{
    public partial class FacultyForm : Form
    {
        public FacultyForm()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string enIDstring = comboBox1.SelectedValue.ToString();
            int enID = Convert.ToInt32(enIDstring);
            string gradeValue = textBox1.Text;
            string attendanceString = textBox2.Text;
            int attendanceValue = Convert.ToInt32(attendanceString);
            Debug.WriteLine("** update button pressed; updating Enrollements table");
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new(Properties.Settings.Default.connString);
            using SqlConnection conn = sqlConnection;
            using SqlDataAdapter adapter = new("Update Enrollments SET Grade = @grade, Attendance = @attendance WHERE EnrollmentID = @enID;", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@grade", gradeValue);
            adapter.SelectCommand.Parameters.AddWithValue("@attendance", attendanceValue);
            adapter.SelectCommand.Parameters.AddWithValue("@enID", enID);
            Debug.WriteLine("** SQL results **");
            adapter.Fill(dt);
            string result = dt.ToString();
            Debug.WriteLine(result);

        }

        private void FacultyForm_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("** form load, grabbing from Enrollments table");
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new(Properties.Settings.Default.connString);
            using SqlConnection conn = sqlConnection;
            using SqlDataAdapter adapter = new("SELECT E. EnrollmentID, U.UserName, C.CourseName, E.Grade, E.Attendance FROM Users AS U INNER JOIN Enrollments AS E ON U.UserID = E.StudentID INNER JOIN Courses AS C ON E.CourseID = C.CourseID;", conn);
            DataTable courseTable = new();
            adapter.Fill(courseTable);
            dataGridView1.DataSource = courseTable;
            dataGridView1.AutoResizeColumns();
            comboBox1.DisplayMember = "EnrollmentID";
            comboBox1.ValueMember = "EnrollmentID";
            comboBox1.DataSource = courseTable;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("** refresh button clicked, grabbing latest from Enrollments table");
            SqlConnection sqlConnection = new(Properties.Settings.Default.connString);
            using SqlConnection conn = sqlConnection;
            using SqlDataAdapter adapter = new("SELECT E. EnrollmentID, U.UserName, C.CourseName, E.Grade, E.Attendance FROM Users AS U INNER JOIN Enrollments AS E ON U.UserID = E.StudentID INNER JOIN Courses AS C ON E.CourseID = C.CourseID;", conn);
            DataTable courseTable = new();
            adapter.Fill(courseTable);
            dataGridView1.DataSource = courseTable;
            dataGridView1.AutoResizeColumns();
            comboBox1.DisplayMember = "EnrollmentID";
            comboBox1.ValueMember = "EnrollmentID";
            comboBox1.DataSource = courseTable;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string enIDstring = comboBox1.SelectedValue.ToString();
            int enID = Convert.ToInt32(enIDstring);
            Debug.WriteLine("** combobox selection changed, grabbing data");
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new(Properties.Settings.Default.connString);
            using SqlConnection conn = sqlConnection;
            using SqlDataAdapter adapter = new("SELECT E.Grade, E.Attendance FROM Enrollments AS E WHERE E.EnrollmentID = @enID;", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@enID", enID);

            Debug.WriteLine("** SQL results **");
            adapter.Fill(dt);
            string gradeResult = dt.Rows[0]["Grade"].ToString();
            string attendanceResult = dt.Rows[0]["Attendance"].ToString();
            Debug.WriteLine("grade: " + gradeResult);
            Debug.WriteLine("attendance: " + attendanceResult);

            textBox1.Text = gradeResult;
            textBox2.Text = attendanceResult;
        }
    }
}