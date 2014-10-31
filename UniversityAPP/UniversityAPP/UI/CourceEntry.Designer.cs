namespace UniversityAPP
{
    partial class CourceEntry
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
            this.Code = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.craditTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Code
            // 
            this.Code.AutoSize = true;
            this.Code.Location = new System.Drawing.Point(54, 39);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(32, 13);
            this.Code.TabIndex = 0;
            this.Code.Text = "Code";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(54, 124);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cradit";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(275, 39);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(275, 117);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // craditTextBox
            // 
            this.craditTextBox.Location = new System.Drawing.Point(275, 187);
            this.craditTextBox.Name = "craditTextBox";
            this.craditTextBox.Size = new System.Drawing.Size(100, 20);
            this.craditTextBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(144, 291);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // CourceEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 351);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.craditTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Code);
            
            this.Text = "CourceEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox craditTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}