using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Wild_Farm.Models.AnimalModels
{
    public class Mouse : Mammal
    {
        protected override List<string> Foods { get; set; } = new List<string> { "Vegetable", "Fruit" };

        protected override double GrowthRate { get; set; } = 0.10;
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Squeak");
        }
    }
}
