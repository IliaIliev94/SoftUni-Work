using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Wild_Farm.Models.AnimalModels
{
    public class Tiger : Feline
    {
        protected override List<string> Foods { get; set; } = new List<string>() { "Meat" };
        protected override double GrowthRate { get; set; } = 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("ROAR!!!");
        }
    }
}
