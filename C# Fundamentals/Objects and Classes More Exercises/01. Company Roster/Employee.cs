using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Company_Roster
{
    class Employee
    {
        public Employee(string Name, double Salary, string Department)
        {
            this.Name = Name;
            this.Salary = Salary;
            this.Department = Department;
        }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

    }
}
