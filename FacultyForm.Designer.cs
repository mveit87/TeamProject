namespace TeamProject
{
    partial class FacultyForm
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
            updateButton = new Button();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // updateButton
            // 
            updateButton.Location = new Point(22, 320);
            updateButton.Margin = new Padding(2, 1, 2, 1);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(235, 22);
            updateButton.TabIndex = 0;
            updateButton.Text = "Update grades and attendance";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(22, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(639, 169);
            listBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(106, 201);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(297, 23);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 209);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 3;
            label1.Text = "Select Course";
            label1.Click += label1_Click;
            // 
            // FacultyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 374);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(updateButton);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FacultyForm";
            Text = "FacultyForm";
            Load += FacultyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateButton;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private Label label1;
    }
}