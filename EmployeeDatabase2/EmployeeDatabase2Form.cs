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
    public partial class EmployeeDatabase2Form : Form
    {
        private List<Employee> _employees = new List<Employee>();
        Employee temp = new Employee();
        public EmployeeDatabase2Form()
        {
            InitializeComponent();
            removeEmployeeButton.Enabled = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Declare an EmployeeForm variable, create an instance of the EmployeeForm Form,
            // and assign the new EmployeeForm instance object to the variable            
            EmployeeForm employeeForm = new EmployeeForm();

            // Display the employeeForm instance, and assign the return results to
            // a DialogResult variable
            DialogResult dialogResult = employeeForm.ShowDialog();

            // Check the return value, and extract any data             
            if (dialogResult == DialogResult.OK)
            {
                // Extract the employee information from the Form using the accessor
                temp = employeeForm.EmployeeInfo;
                // Update the employee ID 
                temp.Id = _employees.Count + 1;
                // Add the employee object to our List
                _employees.Add(temp);
                // Update a ListBox that displays the employee information
               // temp.Id = _employees.Count;
                displayEmployees();
            }
            

            if(employeeListBox.Items.Count >= 0){
                removeEmployeeButton.Enabled = true;
                          
            }
         }
            
        private void removeEmployeeButton_Click(object sender, EventArgs e)
                    {
                        DialogResult dialogRemove = MessageBox.Show("Delete this employee?", "Delete Employee", MessageBoxButtons.YesNo);
                        if (dialogRemove == DialogResult.Yes)
                        {
                            // Extract the employee information from the Form using the accessor
                            _employees.RemoveAt(employeeListBox.SelectedIndex);
                            employeeCountValueLabel.Text = Convert.ToString(_employees.Count);
                            // Update a ListBox that displays the employee information
                            displayEmployees();
                            // Update the employee count display
                        }
                    }

        private void displayEmployees()
        {

            employeeListBox.Items.Clear();
            for (int i = 0; i < _employees.Count; i++)
            {
                
                employeeListBox.Items.Add(Convert.ToString(_employees[i].FirstName) + " " + Convert.ToString(_employees[i].LastName) + " " + Convert.ToString(_employees[i].Id));

                employeeCountValueLabel.Text = Convert.ToString(_employees.Count);
                employeeListBox.Refresh();
            }
        }        
         

   }
}
