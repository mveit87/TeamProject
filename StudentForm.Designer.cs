namespace TeamProject
{
    partial class StudentForm
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
            viewGradesButton = new Button();
            progressButton = new Button();
            quitButton = new Button();
            SuspendLayout();
            // 
            // enrollButton
            // 
            enrollButton.Location = new Point(54, 46);
            enrollButton.Margin = new Padding(2, 1, 2, 1);
            enrollButton.Name = "enrollButton";
            enrollButton.Size = new Size(104, 36);
            enrollButton.TabIndex = 1;
            enrollButton.Text = "Enroll in Course";
            enrollButton.UseVisualStyleBackColor = true;
            enrollButton.Click += enrollButton_Click;
            // 
            // viewGradesButton
            // 
            viewGradesButton.Location = new Point(54, 104);
            viewGradesButton.Margin = new Padding(2, 1, 2, 1);
            viewGradesButton.Name = "viewGradesButton";
            viewGradesButton.Size = new Size(104, 38);
            viewGradesButton.TabIndex = 2;
            viewGradesButton.Text = "View Grades";
            viewGradesButton.UseVisualStyleBackColor = true;
            viewGradesButton.Click += viewGradesButton_Click;
            // 
            // progressButton
            // 
            progressButton.Location = new Point(54, 163);
            progressButton.Margin = new Padding(2, 1, 2, 1);
            progressButton.Name = "progressButton";
            progressButton.Size = new Size(104, 40);
            progressButton.TabIndex = 3;
            progressButton.Text = "View Progess";
            progressButton.UseVisualStyleBackColor = true;
            progressButton.Click += progressButton_Click;
            // 
            // quitButton
            // 
            quitButton.Location = new Point(215, 243);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(75, 23);
            quitButton.TabIndex = 4;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 278);
            Controls.Add(quitButton);
            Controls.Add(progressButton);
            Controls.Add(viewGradesButton);
            Controls.Add(enrollButton);
            Margin = new Padding(2, 1, 2, 1);
            Name = "StudentForm";
            Text = "StudentForm";
            ResumeLayout(false);
        }



        #endregion

        private Button enrollButton;
        private Button viewGradesButton;
        private Button progressButton;
        private Button quitButton;
    }
}