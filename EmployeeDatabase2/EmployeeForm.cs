using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeeDatabase2
{
    public partial class EmployeeForm : Form
    {
        private Employee _employeeInfo;
        public Employee EmployeeInfo
        { 
            get { return _employeeInfo; } 
        }

        private List<Employee> _employees = new List<Employee>();

        public EmployeeForm()
        {InitializeComponent();}

       
        private void okLabel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            // Increment employee counter.
            int employeeCount = _employees.Count + 1;

            // Validate date of birth.
            DateTime dateOfBirth;
            if (!DateTime.TryParse(dateOfBirthTextBox.Text, out dateOfBirth))
            {
                dateOfBirth = DateTime.MinValue;
            }

            // Use object initializers through default constructor.
            _employeeInfo = new Employee()
            {
                Id = employeeCount,
                LastName = lastNameTextBox.Text,
                FirstName = firstNameTextBox.Text,
                DateOfBirth = dateOfBirth
            };

            // Add new employee object.
            _employees.Add(_employeeInfo);
            


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void cancelLabel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        
    }
}