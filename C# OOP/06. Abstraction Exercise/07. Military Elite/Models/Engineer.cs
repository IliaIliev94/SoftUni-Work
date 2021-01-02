using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public List<IRepair> Repairs { get; set; }

        public Engineer(int id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = new List<IRepair>();
        }

        public void Add(IRepair repair)
        {
            this.Repairs.Add(repair);
        }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
            result.AppendLine($"Corps: {this.Corps}");
            result.AppendLine("Repairs:");
            foreach (var repair in this.Repairs)
            {
                result.AppendLine($"  {repair.ToString()}");
            }
            return result.ToString();
        }

    }
}
