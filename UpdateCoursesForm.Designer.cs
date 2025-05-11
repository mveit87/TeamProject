namespace TeamProject
{
    partial class UpdateCoursesForm
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
            courseNameTextBox = new TextBox();
            creditsTextBox = new TextBox();
            semesterOfferedTextBox = new TextBox();
            coursesListbox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            findButton = new Button();
            addButton = new Button();
            deleteButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // courseNameTextBox
            // 
            courseNameTextBox.Location = new Point(245, 85);
            courseNameTextBox.Name = "courseNameTextBox";
            courseNameTextBox.Size = new Size(200, 39);
            courseNameTextBox.TabIndex = 0;
            // 
            // creditsTextBox
            // 
            creditsTextBox.Location = new Point(245, 188);
            creditsTextBox.Name = "creditsTextBox";
            creditsTextBox.Size = new Size(200, 39);
            creditsTextBox.TabIndex = 1;
            // 
            // semesterOfferedTextBox
            // 
            semesterOfferedTextBox.Location = new Point(245, 287);
            semesterOfferedTextBox.Name = "semesterOfferedTextBox";
            semesterOfferedTextBox.Size = new Size(200, 39);
            semesterOfferedTextBox.TabIndex = 2;
            // 
            // coursesListbox
            // 
            coursesListbox.FormattingEnabled = true;
            coursesListbox.ItemHeight = 32;
            coursesListbox.Location = new Point(56, 523);
            coursesListbox.Name = "coursesListbox";
            coursesListbox.Size = new Size(1038, 164);
            coursesListbox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 4;
            label1.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 191);
            label2.Name = "label2";
            label2.Size = new Size(169, 32);
            label2.TabIndex = 5;
            label2.Text = "Course Credits";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 290);
            label3.Name = "label3";
            label3.Size = new Size(202, 32);
            label3.TabIndex = 6;
            label3.Text = "Semester Offered";
            // 
            // findButton
            // 
            findButton.Location = new Point(512, 81);
            findButton.Name = "findButton";
            findButton.Size = new Size(150, 46);
            findButton.TabIndex = 7;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(31, 386);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 46);
            addButton.TabIndex = 8;
            addButton.Text = "Add Course";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(222, 386);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 46);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Delete Course";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(423, 386);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(150, 46);
            exitButton.TabIndex = 10;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // UpdateCoursesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 772);
            Controls.Add(exitButton);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(findButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(coursesListbox);
            Controls.Add(semesterOfferedTextBox);
            Controls.Add(creditsTextBox);
            Controls.Add(courseNameTextBox);
            Name = "UpdateCoursesForm";
            Text = "UpdateCoursesForm";
            Load += UpdateCoursesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox courseNameTextBox;
        private TextBox creditsTextBox;
        private TextBox semesterOfferedTextBox;
        private ListBox coursesListbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button findButton;
        private Button addButton;
        private Button deleteButton;
        private Button exitButton;
    }
}