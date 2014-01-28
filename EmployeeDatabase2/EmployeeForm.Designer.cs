namespace EmployeeDatabase2
{
    partial class EmployeeForm
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
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.dateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.address1Label = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.okLabel = new System.Windows.Forms.Button();
            this.cancelLabel = new System.Windows.Forms.Button();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.empIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(25, 33);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(26, 64);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name:";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(17, 95);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.dateOfBirthLabel.TabIndex = 2;
            this.dateOfBirthLabel.Text = "Date of Birth:";
            // 
            // dateOfBirthTextBox
            // 
            this.dateOfBirthTextBox.Location = new System.Drawing.Point(96, 88);
            this.dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            this.dateOfBirthTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateOfBirthTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(96, 61);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(96, 29);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(221, 373);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(93, 9);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(45, 13);
            this.idLabel.TabIndex = 10;
            this.idLabel.Text = "pending";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(38, 264);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(48, 13);
            this.phoneLabel.TabIndex = 12;
            this.phoneLabel.Text = "Phone#:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(61, 233);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(25, 13);
            this.zipLabel.TabIndex = 13;
            this.zipLabel.Text = "Zip:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(51, 202);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 14;
            this.stateLabel.Text = "State:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(59, 171);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 15;
            this.cityLabel.Text = "City:";
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Location = new System.Drawing.Point(41, 126);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(45, 13);
            this.address1Label.TabIndex = 16;
            this.address1Label.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(96, 119);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 17;
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(96, 145);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(100, 20);
            this.address2TextBox.TabIndex = 18;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(96, 171);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 19;
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(96, 195);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateTextBox.TabIndex = 20;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(96, 226);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(100, 20);
            this.zipTextBox.TabIndex = 21;
            // 
            // okLabel
            // 
            this.okLabel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okLabel.Location = new System.Drawing.Point(32, 346);
            this.okLabel.Name = "okLabel";
            this.okLabel.Size = new System.Drawing.Size(75, 23);
            this.okLabel.TabIndex = 22;
            this.okLabel.Text = "OK";
            this.okLabel.UseVisualStyleBackColor = true;
            this.okLabel.Click += new System.EventHandler(this.okLabel_Click);
            // 
            // cancelLabel
            // 
            this.cancelLabel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelLabel.Location = new System.Drawing.Point(121, 346);
            this.cancelLabel.Name = "cancelLabel";
            this.cancelLabel.Size = new System.Drawing.Size(75, 23);
            this.cancelLabel.TabIndex = 23;
            this.cancelLabel.Text = "Cancel";
            this.cancelLabel.UseVisualStyleBackColor = true;
            this.cancelLabel.Click += new System.EventHandler(this.cancelLabel_Click);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(96, 257);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 24;
            // 
            // empIDLabel
            // 
            this.empIDLabel.AutoSize = true;
            this.empIDLabel.Location = new System.Drawing.Point(17, 9);
            this.empIDLabel.Name = "empIDLabel";
            this.empIDLabel.Size = new System.Drawing.Size(71, 13);
            this.empIDLabel.TabIndex = 25;
            this.empIDLabel.Text = "EmpID Label:";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 408);
            this.Controls.Add(this.empIDLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.cancelLabel);
            this.Controls.Add(this.okLabel);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.address1Label);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.dateOfBirthTextBox);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.TextBox dateOfBirthTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label address1Label;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Button okLabel;
        private System.Windows.Forms.Button cancelLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label empIDLabel;
    }
}