using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem_
{
    public class Employee
       
    {
        private string _employeeId;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        public double _salary;

        


        public string employeeId
        {
            get { return employeeId; }
        }

        public string firstName
        {
            get { return firstName; }
        }
        public string middleName
        {
            get { return middleName; }
        }
        public string lastName
        {
            get { return lastName; }
        }

    }
}

//string.IsNullOrWhiteSpace() for 1st and last name ,,2check thay are not empty or null


//public double Balance
//{
//  get { return balance; }
//set { if (value >= 0) balance = value; }

// }