namespace UniversityAPP
{
    partial class MainUI
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
            this.courseentryButton = new System.Windows.Forms.Button();
            this.studententryButton = new System.Windows.Forms.Button();
            this.enrollmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // courseentryButton
            // 
            this.courseentryButton.Location = new System.Drawing.Point(186, 42);
            this.courseentryButton.Name = "courseentryButton";
            this.courseentryButton.Size = new System.Drawing.Size(149, 48);
            this.courseentryButton.TabIndex = 0;
            this.courseentryButton.Text = "CourseEntry";
            this.courseentryButton.UseVisualStyleBackColor = true;
            this.courseentryButton.Click += new System.EventHandler(this.courseentryButton_Click);
            // 
            // studententryButton
            // 
            this.studententryButton.Location = new System.Drawing.Point(186, 141);
            this.studententryButton.Name = "studententryButton";
            this.studententryButton.Size = new System.Drawing.Size(149, 43);
            this.studententryButton.TabIndex = 1;
            this.studententryButton.Text = "StudentEntry";
            this.studententryButton.UseVisualStyleBackColor = true;
            this.studententryButton.Click += new System.EventHandler(this.studententryButton_Click);
            // 
            // enrollmentButton
            // 
            this.enrollmentButton.Location = new System.Drawing.Point(186, 254);
            this.enrollmentButton.Name = "enrollmentButton";
            this.enrollmentButton.Size = new System.Drawing.Size(149, 40);
            this.enrollmentButton.TabIndex = 2;
            this.enrollmentButton.Text = "Enrollment";
            this.enrollmentButton.UseVisualStyleBackColor = true;
            this.enrollmentButton.Click += new System.EventHandler(this.enrollmentButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 364);
            this.Controls.Add(this.enrollmentButton);
            this.Controls.Add(this.studententryButton);
            this.Controls.Add(this.courseentryButton);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button courseentryButton;
        private System.Windows.Forms.Button studententryButton;
        private System.Windows.Forms.Button enrollmentButton;
    }
}

