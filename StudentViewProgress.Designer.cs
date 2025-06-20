namespace TeamProject
{
    partial class StudentViewProgress
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
            label1 = new Label();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            reauthenticateButton = new Button();
            label2 = new Label();
            label3 = new Label();
            totalCreditsLabel = new Label();
            graduationDateLabel = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(247, 15);
            label1.TabIndex = 0;
            label1.Text = "Please reauthenticate to view degree progress";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(12, 27);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.PlaceholderText = "Username";
            userNameTextBox.Size = new Size(198, 23);
            userNameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(229, 27);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(198, 23);
            passwordTextBox.TabIndex = 2;
            // 
            // reauthenticateButton
            // 
            reauthenticateButton.Location = new Point(12, 56);
            reauthenticateButton.Name = "reauthenticateButton";
            reauthenticateButton.Size = new Size(119, 23);
            reauthenticateButton.TabIndex = 3;
            reauthenticateButton.Text = "REAUTHENTICATE";
            reauthenticateButton.UseVisualStyleBackColor = true;
            reauthenticateButton.Click += reauthenticateButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 4;
            label2.Text = "Total Credits";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(229, 112);
            label3.Name = "label3";
            label3.Size = new Size(136, 21);
            label3.TabIndex = 5;
            label3.Text = "Graduation Date";
            // 
            // totalCreditsLabel
            // 
            totalCreditsLabel.AutoSize = true;
            totalCreditsLabel.Location = new Point(12, 142);
            totalCreditsLabel.Name = "totalCreditsLabel";
            totalCreditsLabel.Size = new Size(0, 15);
            totalCreditsLabel.TabIndex = 6;
            // 
            // graduationDateLabel
            // 
            graduationDateLabel.AutoSize = true;
            graduationDateLabel.Location = new Point(229, 142);
            graduationDateLabel.Name = "graduationDateLabel";
            graduationDateLabel.Size = new Size(0, 15);
            graduationDateLabel.TabIndex = 7;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(352, 211);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // StudentViewProgress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 246);
            Controls.Add(exitButton);
            Controls.Add(graduationDateLabel);
            Controls.Add(totalCreditsLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(reauthenticateButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(label1);
            Name = "StudentViewProgress";
            Text = "StudentViewProgress";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Button reauthenticateButton;
        private Label label2;
        private Label label3;
        private Label totalCreditsLabel;
        private Label graduationDateLabel;
        private Button exitButton;
    }
}