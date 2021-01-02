using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public List<IMission> Missions { get; private set; }

        public Commando(int id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = new List<IMission>();
        }

        public void Add(IMission mission)
        {
            this.Missions.Add(mission);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
            result.AppendLine($"Corps: {this.Corps}");
            result.AppendLine("Missions:");
            foreach (var mission in this.Missions)
            {
                result.AppendLine($"  {mission.ToString()}");
            }
            return result.ToString();
        }
    }
}
