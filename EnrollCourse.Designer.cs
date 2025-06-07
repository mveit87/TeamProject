using System.Data;
using System.Data.SqlClient;

namespace TeamProject
{
    partial class EnrollCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            enrollButton = new Button();
            exitButton = new Button();
            userNameComboBox = new ComboBox();
            courseNameComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // enrollButton
            // 
            enrollButton.Location = new Point(69, 688);
            enrollButton.Name = "enrollButton";
            enrollButton.Size = new Size(150, 46);
            enrollButton.TabIndex = 3;
            enrollButton.Text = "Enroll";
            enrollButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(303, 688);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(150, 46);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // userNameComboBox
            // 
            userNameComboBox.FormattingEnabled = true;
            userNameComboBox.Location = new Point(385, 118);
            userNameComboBox.Name = "userNameComboBox";
            userNameComboBox.Size = new Size(399, 40);
            userNameComboBox.TabIndex = 5;
            // 
            // courseNameComboBox
            // 
            courseNameComboBox.FormattingEnabled = true;
            courseNameComboBox.Location = new Point(385, 253);
            courseNameComboBox.Name = "courseNameComboBox";
            courseNameComboBox.Size = new Size(399, 40);
            courseNameComboBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 122);
            label1.Name = "label1";
            label1.Size = new Size(220, 32);
            label1.TabIndex = 7;
            label1.Text = "Select Student user";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 261);
            label2.Name = "label2";
            label2.Size = new Size(159, 32);
            label2.TabIndex = 8;
            label2.Text = "Select Course";
            // 
            // EnrollCourse
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 890);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(courseNameComboBox);
            Controls.Add(userNameComboBox);
            Controls.Add(exitButton);
            Controls.Add(enrollButton);
            Name = "EnrollCourse";
            Text = "EnrollCourse";
            //Load += EnrollCourse_Load;
            ResumeLayout(false);
            PerformLayout();

            // SQL calls on initilization
            using SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString);
            conn.Open(); // Ensure the connection is open

            // Fetching courses
            using SqlDataAdapter coursesAdapter = new SqlDataAdapter("SELECT * FROM Courses", conn);
            DataTable coursesTable = new DataTable();
            coursesAdapter.Fill(coursesTable);
            courseNameComboBox.DisplayMember = "CourseName";
            courseNameComboBox.DataSource = coursesTable;

            // Fetching users
            using SqlDataAdapter usersAdapter = new SqlDataAdapter("SELECT * FROM Users", conn);
            DataTable usersTable = new DataTable();
            usersAdapter.Fill(usersTable);
            userNameComboBox.DisplayMember = "Username";
            userNameComboBox.DataSource = usersTable;
        }

        #endregion
        private Button enrollButton;
        private Button exitButton;
        private ComboBox userNameComboBox;
        private ComboBox courseNameComboBox;
        private Label label1;
        private Label label2;
    }
}