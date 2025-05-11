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
            SuspendLayout();
            // 
            // facultyNameTextBox
            // 
            facultyNameTextBox.Location = new Point(290, 216);
            facultyNameTextBox.Name = "facultyNameTextBox";
            facultyNameTextBox.Size = new Size(353, 39);
            facultyNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 216);
            label1.Name = "label1";
            label1.Size = new Size(257, 32);
            label1.TabIndex = 1;
            label1.Text = "Faculty Member Name";
            // 
            // addButton
            // 
            addButton.Location = new Point(97, 434);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 46);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(310, 434);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(150, 46);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // AddFacultyForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 680);
            Controls.Add(ExitButton);
            Controls.Add(addButton);
            Controls.Add(label1);
            Controls.Add(facultyNameTextBox);
            Name = "AddFacultyForm";
            Text = "AddFacultyForm";
            Load += AddFacultyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox facultyNameTextBox;
        private Label label1;
        private Button addButton;
        private Button ExitButton;
    }
}