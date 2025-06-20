namespace TeamProject
{
    partial class AddFacultyForm
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
            facultyNameTextBox = new TextBox();
            label1 = new Label();
            addButton = new Button();
            ExitButton = new Button();
            dataGridView1 = new DataGridView();
            searchTextBox = new TextBox();
            searchButton = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // facultyNameTextBox
            // 
            facultyNameTextBox.Location = new Point(97, 423);
            facultyNameTextBox.Margin = new Padding(2, 1, 2, 1);
            facultyNameTextBox.Name = "facultyNameTextBox";
            facultyNameTextBox.PlaceholderText = "New Faculty Name";
            facultyNameTextBox.Size = new Size(290, 23);
            facultyNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 395);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 1;
            label1.Text = "Add New Faculty Member";
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 424);
            addButton.Margin = new Padding(2, 1, 2, 1);
            addButton.Name = "addButton";
            addButton.Size = new Size(81, 22);
            addButton.TabIndex = 2;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(307, 471);
            ExitButton.Margin = new Padding(2, 1, 2, 1);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(81, 22);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(375, 281);
            dataGridView1.TabIndex = 4;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(94, 315);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Faculty Name";
            searchTextBox.Size = new Size(293, 23);
            searchTextBox.TabIndex = 5;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(12, 314);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 6;
            searchButton.Text = "SEARCH";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 7;
            label2.Text = "Search Faculty Member";
            // 
            // AddFacultyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 503);
            Controls.Add(label2);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(dataGridView1);
            Controls.Add(ExitButton);
            Controls.Add(addButton);
            Controls.Add(label1);
            Controls.Add(facultyNameTextBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "AddFacultyForm";
            Text = "AddFacultyForm";
            Load += AddFacultyForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox facultyNameTextBox;
        private Label label1;
        private Button addButton;
        private Button ExitButton;
        private DataGridView dataGridView1;
        private TextBox searchTextBox;
        private Button searchButton;
        private Label label2;
    }
}