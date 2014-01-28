namespace EmployeeDatabase2
{
    partial class EmployeeDatabase2Form
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
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.removeEmployeeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.employeeCountLabel = new System.Windows.Forms.Label();
            this.employeeCountValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeListBox
            // 
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.Location = new System.Drawing.Point(0, 0);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(186, 264);
            this.employeeListBox.TabIndex = 0;
            // 
            // removeEmployeeButton
            // 
            this.removeEmployeeButton.Location = new System.Drawing.Point(192, 35);
            this.removeEmployeeButton.Name = "removeEmployeeButton";
            this.removeEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.removeEmployeeButton.TabIndex = 1;
            this.removeEmployeeButton.Text = "Remove";
            this.removeEmployeeButton.UseVisualStyleBackColor = true;
            this.removeEmployeeButton.Click += new System.EventHandler(this.removeEmployeeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(192, 6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // employeeCountLabel
            // 
            this.employeeCountLabel.AutoSize = true;
            this.employeeCountLabel.Location = new System.Drawing.Point(192, 222);
            this.employeeCountLabel.Name = "employeeCountLabel";
            this.employeeCountLabel.Size = new System.Drawing.Size(87, 13);
            this.employeeCountLabel.TabIndex = 7;
            this.employeeCountLabel.Text = "Employee Count:";
            // 
            // employeeCountValueLabel
            // 
            this.employeeCountValueLabel.AutoSize = true;
            this.employeeCountValueLabel.Location = new System.Drawing.Point(217, 251);
            this.employeeCountValueLabel.Name = "employeeCountValueLabel";
            this.employeeCountValueLabel.Size = new System.Drawing.Size(13, 13);
            this.employeeCountValueLabel.TabIndex = 8;
            this.employeeCountValueLabel.Text = "0";
            // 
            // EmployeeDatabase2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.employeeCountValueLabel);
            this.Controls.Add(this.employeeCountLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeEmployeeButton);
            this.Controls.Add(this.employeeListBox);
            this.Name = "EmployeeDatabase2Form";
            this.Text = "EmployeeDatabase2Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.Button removeEmployeeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label employeeCountLabel;
        private System.Windows.Forms.Label employeeCountValueLabel;
    }
}

