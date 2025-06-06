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
    public partial class ViewGrades : Form
    {
        public ViewGrades()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string studentName = userNameTextBox.Text;
            using SqlConnection conn = new(Properties.Settings.Default.connString);
            using SqlDataAdapter adapter = new($"SELECT * FROM Enrollments WHERE UserId = @userId", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@userId", "UserID"); 
            adapter.SelectCommand.Parameters.AddWithValue("@courseId", "COurseId");
            adapter.SelectCommand.Parameters.AddWithValue("@grade", "Grade");
           
            DataTable EnrollmentsTable = new(); 
            adapter.Fill(EnrollmentsTable);
            userGradesDataGridView.DataSource = EnrollmentsTable;
        }
    }
}
