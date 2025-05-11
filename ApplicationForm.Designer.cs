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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            submitButton = new Button();
            exitButton = new Button();
            uploadButton = new Button();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 79);
            label1.Name = "label1";
            label1.Size = new Size(134, 32);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 144);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 218);
            label3.Name = "label3";
            label3.Size = new Size(125, 32);
            label3.TabIndex = 2;
            label3.Text = "UserName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 299);
            label4.Name = "label4";
            label4.Size = new Size(111, 32);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(229, 79);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(302, 39);
            firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(219, 144);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(312, 39);
            lastNameTextBox.TabIndex = 5;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(219, 215);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(312, 39);
            userNameTextBox.TabIndex = 6;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(219, 292);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(312, 39);
            passwordTextBox.TabIndex = 7;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(65, 443);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(150, 46);
            submitButton.TabIndex = 8;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(271, 443);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(150, 46);
            exitButton.TabIndex = 9;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // uploadButton
            // 
            uploadButton.Location = new Point(65, 374);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(150, 46);
            uploadButton.TabIndex = 10;
            uploadButton.Text = "Upload";
            uploadButton.UseVisualStyleBackColor = true;
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
            // ApplicationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 1098);
            Controls.Add(groupBox1);
            Controls.Add(uploadButton);
            Controls.Add(exitButton);
            Controls.Add(submitButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ApplicationForm";
            Text = "ApplicationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Button submitButton;
        private Button exitButton;
        private Button uploadButton;
        private GroupBox groupBox1;
    }
}