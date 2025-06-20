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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrollCourse));
            enrollButton = new Button();
            exitButton = new Button();
            userNameComboBox = new ComboBox();
            usersTable = new DataTable();
            courseNameComboBox = new ComboBox();
            coursesTable = new DataTable();
            label1 = new Label();
            label2 = new Label();
            conn = new SqlConnection();
            coursesAdapter = new SqlDataAdapter();
            usersAdapter = new SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)usersTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coursesTable).BeginInit();
            SuspendLayout();
            // 
            // enrollButton
            // 
            enrollButton.Location = new Point(207, 232);
            enrollButton.Margin = new Padding(2, 1, 2, 1);
            enrollButton.Name = "enrollButton";
            enrollButton.Size = new Size(81, 22);
            enrollButton.TabIndex = 3;
            enrollButton.Text = "Enroll";
            enrollButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(343, 232);
            exitButton.Margin = new Padding(2, 1, 2, 1);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(81, 22);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // userNameComboBox
            // 
            userNameComboBox.DataSource = usersTable;
            userNameComboBox.DisplayMember = "Username";
            userNameComboBox.FormattingEnabled = true;
            userNameComboBox.Location = new Point(207, 55);
            userNameComboBox.Margin = new Padding(2, 1, 2, 1);
            userNameComboBox.Name = "userNameComboBox";
            userNameComboBox.Size = new Size(217, 23);
            userNameComboBox.TabIndex = 5;
            // 
            // usersTable
            // 
            usersTable.Namespace = "";
            // 
            // courseNameComboBox
            // 
            courseNameComboBox.DataSource = coursesTable;
            courseNameComboBox.DisplayMember = "CourseName";
            courseNameComboBox.FormattingEnabled = true;
            courseNameComboBox.Location = new Point(207, 119);
            courseNameComboBox.Margin = new Padding(2, 1, 2, 1);
            courseNameComboBox.Name = "courseNameComboBox";
            courseNameComboBox.Size = new Size(217, 23);
            courseNameComboBox.TabIndex = 6;
            // 
            // coursesTable
            // 
            coursesTable.Namespace = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 57);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 7;
            label1.Text = "Select Student user";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 122);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 8;
            label2.Text = "Select Course";
            // 
            // conn
            // 
            conn.AccessToken = null;
            conn.ConnectionString = resources.GetString("conn.ConnectionString");
            conn.Credential = null;
            conn.FireInfoMessageEventOnUserErrors = false;
            conn.StatisticsEnabled = false;
            // 
            // coursesAdapter
            // 
            coursesAdapter.DeleteCommand = null;
            coursesAdapter.InsertCommand = null;
            coursesAdapter.UpdateCommand = null;
            // 
            // usersAdapter
            // 
            usersAdapter.DeleteCommand = null;
            usersAdapter.InsertCommand = null;
            usersAdapter.UpdateCommand = null;
            // 
            // EnrollCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 285);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(courseNameComboBox);
            Controls.Add(userNameComboBox);
            Controls.Add(exitButton);
            Controls.Add(enrollButton);
            Margin = new Padding(2, 1, 2, 1);
            Name = "EnrollCourse";
            Text = "EnrollCourse";
            ((System.ComponentModel.ISupportInitialize)usersTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)coursesTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button enrollButton;
        private Button exitButton;
        private ComboBox userNameComboBox;
        private ComboBox courseNameComboBox;
        private Label label1;
        private Label label2;
        private DataTable usersTable;
        private DataTable coursesTable;
        private SqlConnection conn;
        private SqlDataAdapter coursesAdapter;
        private SqlDataAdapter usersAdapter;
    }
}