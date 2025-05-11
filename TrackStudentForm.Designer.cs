namespace TeamProject
{
    partial class TrackStudentForm
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
            studentDataGridView = new DataGridView();
            studentNameTextBox = new TextBox();
            label1 = new Label();
            findStudentButton = new Button();
            label2 = new Label();
            courseNameTextBox = new TextBox();
            findCourseButton = new Button();
            facultyTextBox = new TextBox();
            label3 = new Label();
            findFacultyButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // studentDataGridView
            // 
            studentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentDataGridView.Location = new Point(63, 422);
            studentDataGridView.Name = "studentDataGridView";
            studentDataGridView.RowHeadersWidth = 82;
            studentDataGridView.RowTemplate.Height = 41;
            studentDataGridView.Size = new Size(881, 300);
            studentDataGridView.TabIndex = 0;
            // 
            // studentNameTextBox
            // 
            studentNameTextBox.Location = new Point(278, 51);
            studentNameTextBox.Name = "studentNameTextBox";
            studentNameTextBox.Size = new Size(296, 39);
            studentNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 54);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 2;
            label1.Text = "Student Name";
            // 
            // findStudentButton
            // 
            findStudentButton.Location = new Point(660, 44);
            findStudentButton.Name = "findStudentButton";
            findStudentButton.Size = new Size(176, 46);
            findStudentButton.TabIndex = 3;
            findStudentButton.Text = "Find Student";
            findStudentButton.UseVisualStyleBackColor = true;
            findStudentButton.Click += findStudentButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 140);
            label2.Name = "label2";
            label2.Size = new Size(159, 32);
            label2.TabIndex = 4;
            label2.Text = "Course Name";
            // 
            // courseNameTextBox
            // 
            courseNameTextBox.Location = new Point(278, 140);
            courseNameTextBox.Name = "courseNameTextBox";
            courseNameTextBox.Size = new Size(296, 39);
            courseNameTextBox.TabIndex = 5;
            // 
            // findCourseButton
            // 
            findCourseButton.Location = new Point(660, 136);
            findCourseButton.Name = "findCourseButton";
            findCourseButton.Size = new Size(150, 46);
            findCourseButton.TabIndex = 6;
            findCourseButton.Text = "Find Course";
            findCourseButton.UseVisualStyleBackColor = true;
            findCourseButton.Click += findCourseButton_Click;
            // 
            // facultyTextBox
            // 
            facultyTextBox.Location = new Point(278, 216);
            facultyTextBox.Name = "facultyTextBox";
            facultyTextBox.Size = new Size(296, 39);
            facultyTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 216);
            label3.Name = "label3";
            label3.Size = new Size(159, 32);
            label3.TabIndex = 8;
            label3.Text = "Faculty Name";
            // 
            // findFacultyButton
            // 
            findFacultyButton.Location = new Point(660, 216);
            findFacultyButton.Name = "findFacultyButton";
            findFacultyButton.Size = new Size(150, 46);
            findFacultyButton.TabIndex = 9;
            findFacultyButton.Text = "Find Faculty";
            findFacultyButton.UseVisualStyleBackColor = true;
            findFacultyButton.Click += findFacultyButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(63, 329);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(150, 46);
            clearButton.TabIndex = 10;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(264, 329);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(150, 46);
            exitButton.TabIndex = 11;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // TrackStudentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 752);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(findFacultyButton);
            Controls.Add(label3);
            Controls.Add(facultyTextBox);
            Controls.Add(findCourseButton);
            Controls.Add(courseNameTextBox);
            Controls.Add(label2);
            Controls.Add(findStudentButton);
            Controls.Add(label1);
            Controls.Add(studentNameTextBox);
            Controls.Add(studentDataGridView);
            Name = "TrackStudentForm";
            Text = "TrackStudentForm";
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView studentDataGridView;
        private TextBox studentNameTextBox;
        private Label label1;
        private Button findStudentButton;
        private Label label2;
        private TextBox courseNameTextBox;
        private Button findCourseButton;
        private TextBox facultyTextBox;
        private Label label3;
        private Button findFacultyButton;
        private Button clearButton;
        private Button exitButton;
    }
}