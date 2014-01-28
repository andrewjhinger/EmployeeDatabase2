using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeDatabase2
{
    public class Employee
    {

        private int _id;
        private string _lastName;
        private string _firstName;
        private DateTime _dateOfBirth;
        
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string LastName {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string FirstName {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        
        public Employee()
        {
            // Default constructor
        }

    }
}
