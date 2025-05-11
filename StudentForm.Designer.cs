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
            SuspendLayout();
            // 
            // enrollButton
            // 
            enrollButton.Location = new Point(100, 99);
            enrollButton.Name = "enrollButton";
            enrollButton.Size = new Size(194, 76);
            enrollButton.TabIndex = 1;
            enrollButton.Text = "Enroll in Course";
            enrollButton.UseVisualStyleBackColor = true;
            // 
            // viewGradesButton
            // 
            viewGradesButton.Location = new Point(100, 221);
            viewGradesButton.Name = "viewGradesButton";
            viewGradesButton.Size = new Size(194, 80);
            viewGradesButton.TabIndex = 2;
            viewGradesButton.Text = "View Grades";
            viewGradesButton.UseVisualStyleBackColor = true;
            // 
            // progressButton
            // 
            progressButton.Location = new Point(100, 348);
            progressButton.Name = "progressButton";
            progressButton.Size = new Size(194, 85);
            progressButton.TabIndex = 3;
            progressButton.Text = "View Progess";
            progressButton.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 754);
            Controls.Add(progressButton);
            Controls.Add(viewGradesButton);
            Controls.Add(enrollButton);
            Name = "StudentForm";
            Text = "StudentForm";
            ResumeLayout(false);
        }

        #endregion

        private Button enrollButton;
        private Button viewGradesButton;
        private Button progressButton;
    }
}