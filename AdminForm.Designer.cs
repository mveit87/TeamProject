namespace TeamProject
{
    partial class AdminForm
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
            updateCoursesButton = new Button();
            addFaculty = new Button();
            trackStudentButton = new Button();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // updateCoursesButton
            // 
            updateCoursesButton.Location = new Point(129, 90);
            updateCoursesButton.Name = "updateCoursesButton";
            updateCoursesButton.Size = new Size(259, 46);
            updateCoursesButton.TabIndex = 0;
            updateCoursesButton.Text = "Update Courses";
            updateCoursesButton.UseVisualStyleBackColor = true;
            updateCoursesButton.Click += updateCoursesButton_Click;
            // 
            // addFaculty
            // 
            addFaculty.Location = new Point(129, 187);
            addFaculty.Name = "addFaculty";
            addFaculty.Size = new Size(259, 46);
            addFaculty.TabIndex = 1;
            addFaculty.Text = "Add Faculty";
            addFaculty.UseVisualStyleBackColor = true;
            addFaculty.Click += addFaculty_Click;
            // 
            // trackStudentButton
            // 
            trackStudentButton.Location = new Point(129, 283);
            trackStudentButton.Name = "trackStudentButton";
            trackStudentButton.Size = new Size(259, 46);
            trackStudentButton.TabIndex = 2;
            trackStudentButton.Text = "track Student Performance";
            trackStudentButton.UseVisualStyleBackColor = true;
            trackStudentButton.Click += trackStudentButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(44, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 38);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adminstrator HomePage";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 505);
            Controls.Add(groupBox1);
            Controls.Add(trackStudentButton);
            Controls.Add(addFaculty);
            Controls.Add(updateCoursesButton);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
        }

        #endregion

        private Button updateCoursesButton;
        private Button addFaculty;
        private Button trackStudentButton;
        private GroupBox groupBox1;
    }
}