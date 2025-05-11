using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void updateCoursesButton_Click(object sender, EventArgs e)
        {
            UpdateCoursesForm updateCoursesForm = new UpdateCoursesForm();
            updateCoursesForm.ShowDialog();
        }

        private void addFaculty_Click(object sender, EventArgs e)
        {
            AddFacultyForm addFacultyForm = new AddFacultyForm();
            addFacultyForm.ShowDialog();
        }

        private void trackStudentButton_Click(object sender, EventArgs e)
        {
           TrackStudentForm trackStudentForm = new TrackStudentForm();
            trackStudentForm.ShowDialog();
        }
    }
}
