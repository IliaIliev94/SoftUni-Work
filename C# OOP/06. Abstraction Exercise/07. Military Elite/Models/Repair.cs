using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite
{
    public class Repair : IRepair
    {
        public string Name { get; private set; }
        public int Hours { get; private set; }

        public Repair(string name, int hours)
        {
            this.Name = name;
            this.Hours = hours;
        }
        public override string ToString()
        {
            return $"Part Name: {this.Name} Hours Worked: {this.Hours}";
        }
    }
}
