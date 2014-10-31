namespace UniversityAPP
{
    partial class Enrollment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.courcenameComboBox = new System.Windows.Forms.ComboBox();
            this.studentregnoComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.enrollButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cource Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student Reg No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date";
            // 
            // courcenameComboBox
            // 
            this.courcenameComboBox.FormattingEnabled = true;
            this.courcenameComboBox.Location = new System.Drawing.Point(266, 46);
            this.courcenameComboBox.Name = "courcenameComboBox";
            this.courcenameComboBox.Size = new System.Drawing.Size(121, 21);
            this.courcenameComboBox.TabIndex = 1;
            // 
            // studentregnoComboBox
            // 
            this.studentregnoComboBox.FormattingEnabled = true;
            this.studentregnoComboBox.Location = new System.Drawing.Point(266, 118);
            this.studentregnoComboBox.Name = "studentregnoComboBox";
            this.studentregnoComboBox.Size = new System.Drawing.Size(121, 21);
            this.studentregnoComboBox.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(266, 200);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // enrollButton
            // 
            this.enrollButton.Location = new System.Drawing.Point(210, 267);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(157, 42);
            this.enrollButton.TabIndex = 3;
            this.enrollButton.Text = "Enroll";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // Enrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 346);
            this.Controls.Add(this.enrollButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.studentregnoComboBox);
            this.Controls.Add(this.courcenameComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Enrollment";
            this.Text = "Enrollment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox courcenameComboBox;
        private System.Windows.Forms.ComboBox studentregnoComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button enrollButton;
    }
}