using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public List<IPrivate> Privates { get; private set; }
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
            this.Privates = new List<IPrivate>();
        }
        public void Add(IPrivate @private)
        {
            this.Privates.Add(@private);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
            result.AppendLine("Privates:");
            foreach(var myPrivate in this.Privates)
            {
                result.AppendLine(myPrivate.ToString());
            }
            return result.ToString();
        }
    }
}
