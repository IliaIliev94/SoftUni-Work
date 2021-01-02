using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public decimal Salary { get; private set; }
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public void IncreaseSalary(decimal percentage)
        {

            decimal salaryModifier = percentage;
            if (Age < 30)
            {
                salaryModifier /= 2;
            }
            Salary += this.Salary * salaryModifier / 100;

        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} recieves {this.Salary:F2} leva.";
        }
    }
}
