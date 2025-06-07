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
    public partial class StudentForm: Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            EnrollCourse enrollCourse = new EnrollCourse();
            enrollCourse.Show();
            this.Hide();
        }

        private void viewGradesButton_Click(Object sender, EventArgs e)
        {
            ViewGrades viewGrades = new ViewGrades();
            viewGrades.Show();
            this.Hide();
        }

        private void progressButton_Click(Object sender, EventArgs e)
        {
            StudentViewProgress studentViewProgress = new StudentViewProgress();
            studentViewProgress.Show();
            this.Hide();
        }
    }
}
