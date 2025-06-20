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
            quitButton = new Button();
            SuspendLayout();
            // 
            // updateCoursesButton
            // 
            updateCoursesButton.Location = new Point(69, 42);
            updateCoursesButton.Margin = new Padding(2, 1, 2, 1);
            updateCoursesButton.Name = "updateCoursesButton";
            updateCoursesButton.Size = new Size(139, 22);
            updateCoursesButton.TabIndex = 0;
            updateCoursesButton.Text = "Update Courses";
            updateCoursesButton.UseVisualStyleBackColor = true;
            updateCoursesButton.Click += updateCoursesButton_Click;
            // 
            // addFaculty
            // 
            addFaculty.Location = new Point(69, 88);
            addFaculty.Margin = new Padding(2, 1, 2, 1);
            addFaculty.Name = "addFaculty";
            addFaculty.Size = new Size(139, 22);
            addFaculty.TabIndex = 1;
            addFaculty.Text = "Search or Add Faculty";
            addFaculty.UseVisualStyleBackColor = true;
            addFaculty.Click += addFaculty_Click;
            // 
            // trackStudentButton
            // 
            trackStudentButton.Location = new Point(69, 133);
            trackStudentButton.Margin = new Padding(2, 1, 2, 1);
            trackStudentButton.Name = "trackStudentButton";
            trackStudentButton.Size = new Size(139, 22);
            trackStudentButton.TabIndex = 2;
            trackStudentButton.Text = "Track Student Performance";
            trackStudentButton.UseVisualStyleBackColor = true;
            trackStudentButton.Click += trackStudentButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(24, 13);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(215, 18);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adminstrator Home Page";
            // 
            // quitButton
            // 
            quitButton.Location = new Point(229, 202);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(75, 23);
            quitButton.TabIndex = 4;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 237);
            Controls.Add(quitButton);
            Controls.Add(groupBox1);
            Controls.Add(trackStudentButton);
            Controls.Add(addFaculty);
            Controls.Add(updateCoursesButton);
            Margin = new Padding(2, 1, 2, 1);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
        }

        #endregion

        private Button updateCoursesButton;
        private Button addFaculty;
        private Button trackStudentButton;
        private GroupBox groupBox1;
        private Button quitButton;
    }
}