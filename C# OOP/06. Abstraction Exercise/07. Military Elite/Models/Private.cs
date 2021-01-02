using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite
{
    public class Private: Soldier, IPrivate
    {
        public decimal Salary { get; private set; }

        public Private(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}";
        }
    }
}
