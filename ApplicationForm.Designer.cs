namespace TeamProject
{
    partial class ApplicationForm
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
            label3 = new Label();
            label4 = new Label();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            submitButton = new Button();
            exitButton = new Button();
            uploadButton = new Button();
            groupBox1 = new GroupBox();
            userTypeTextBox = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 83);
            label3.Name = "label3";
            label3.Size = new Size(125, 32);
            label3.TabIndex = 2;
            label3.Text = "UserName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 138);
            label4.Name = "label4";
            label4.Size = new Size(111, 32);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(204, 83);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(312, 39);
            userNameTextBox.TabIndex = 6;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(204, 138);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(312, 39);
            passwordTextBox.TabIndex = 7;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(57, 296);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(150, 46);
            submitButton.TabIndex = 8;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(422, 296);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(150, 46);
            exitButton.TabIndex = 9;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // uploadButton
            // 
            uploadButton.Location = new Point(233, 296);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(150, 46);
            uploadButton.TabIndex = 10;
            uploadButton.Text = "Upload";
            uploadButton.UseVisualStyleBackColor = true;
            uploadButton.Click += uploadButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(21, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 62);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Applicant Information";
            // 
            // userTypeTextBox
            // 
            userTypeTextBox.Location = new Point(204, 199);
            userTypeTextBox.Name = "userTypeTextBox";
            userTypeTextBox.Size = new Size(297, 39);
            userTypeTextBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 202);
            label5.Name = "label5";
            label5.Size = new Size(124, 32);
            label5.TabIndex = 13;
            label5.Text = "User Type:";
            // 
            // ApplicationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 523);
            Controls.Add(label5);
            Controls.Add(userTypeTextBox);
            Controls.Add(groupBox1);
            Controls.Add(uploadButton);
            Controls.Add(exitButton);
            Controls.Add(submitButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "ApplicationForm";
            Text = "ApplicationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Button submitButton;
        private Button exitButton;
        private Button uploadButton;
        private GroupBox groupBox1;
        private TextBox userTypeTextBox;
        private Label label5;
    }
}