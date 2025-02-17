using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem_
{
    public class Employee

    {// creating private fields
        private string _employeeId;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private double _salary;



        // implementing public properties
        public string employeeId
        {
            get { return _employeeId; }
        }

        public string firstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))// for validation
                    throw new ArgumentException("First name is required");// ArgumentException for invalid inputs
            }
        }
        public string middleName
        {
            get { return _middleName; }
        }
        public string lastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Last name is required");

            }

        }
        public double salary
        {
            get { return _salary; }
            set 
            {
                if (value < 0)
                    throw new ArgumentException("Salary must not be less than zero");
            }
        
        
        }
        public Employee(string eployeeId, string firstName, string middleName, string lastName, double salary)
        { 
            _employeeId = eployeeId;
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _salary = salary;

        }

        public void salary_()
        {
            Console.WriteLine($"salary: {_salary}");
        }

        public void PrintFullName()
        {
            Console.WriteLine($"{_firstName}+{_middleName}+{_lastName}");
        
        }


        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Employee:");
            PrintFullName();
            salary_();
        
        }








    }
}