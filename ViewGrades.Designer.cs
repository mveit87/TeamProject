namespace TeamProject
{
    partial class ViewGrades
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
            userGradesDataGridView = new DataGridView();
            userNameTextBox = new TextBox();
            findButton = new Button();
            label1 = new Label();
            label2 = new Label();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)userGradesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // userGradesDataGridView
            // 
            userGradesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userGradesDataGridView.Location = new Point(12, 165);
            userGradesDataGridView.Margin = new Padding(2, 1, 2, 1);
            userGradesDataGridView.Name = "userGradesDataGridView";
            userGradesDataGridView.RowHeadersWidth = 82;
            userGradesDataGridView.RowTemplate.Height = 41;
            userGradesDataGridView.Size = new Size(498, 115);
            userGradesDataGridView.TabIndex = 0;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(126, 41);
            userNameTextBox.Margin = new Padding(2, 1, 2, 1);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(158, 23);
            userNameTextBox.TabIndex = 1;
            // 
            // findButton
            // 
            findButton.Location = new Point(317, 38);
            findButton.Margin = new Padding(2, 1, 2, 1);
            findButton.Name = "findButton";
            findButton.Size = new Size(81, 22);
            findButton.TabIndex = 2;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 138);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 3;
            label1.Text = "Student courses and grades";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 44);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "User Name";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(435, 313);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // ViewGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 352);
            Controls.Add(exitButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(findButton);
            Controls.Add(userNameTextBox);
            Controls.Add(userGradesDataGridView);
            Margin = new Padding(2, 1, 2, 1);
            Name = "ViewGrades";
            Text = "ViewGrades";
            ((System.ComponentModel.ISupportInitialize)userGradesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView userGradesDataGridView;
        private TextBox userNameTextBox;
        private Button findButton;
        private Label label1;
        private Label label2;
        private Button exitButton;
    }
}