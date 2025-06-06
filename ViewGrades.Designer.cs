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
            ((System.ComponentModel.ISupportInitialize)userGradesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // userGradesDataGridView
            // 
            userGradesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userGradesDataGridView.Location = new Point(22, 353);
            userGradesDataGridView.Name = "userGradesDataGridView";
            userGradesDataGridView.RowHeadersWidth = 82;
            userGradesDataGridView.RowTemplate.Height = 41;
            userGradesDataGridView.Size = new Size(924, 245);
            userGradesDataGridView.TabIndex = 0;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(234, 87);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(290, 39);
            userNameTextBox.TabIndex = 1;
            // 
            // findButton
            // 
            findButton.Location = new Point(589, 80);
            findButton.Name = "findButton";
            findButton.Size = new Size(150, 46);
            findButton.TabIndex = 2;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 295);
            label1.Name = "label1";
            label1.Size = new Size(309, 32);
            label1.TabIndex = 3;
            label1.Text = "Student courses and grades";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 94);
            label2.Name = "label2";
            label2.Size = new Size(132, 32);
            label2.TabIndex = 4;
            label2.Text = "User Name";
            // 
            // ViewGrades
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 646);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(findButton);
            Controls.Add(userNameTextBox);
            Controls.Add(userGradesDataGridView);
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
    }
}