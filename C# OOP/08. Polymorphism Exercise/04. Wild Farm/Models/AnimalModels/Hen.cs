using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Wild_Farm.Models.AnimalModels
{
    public class Hen : Bird
    {
        protected override List<string> Foods { get; set; } = new List<string> { "Meat", "Fruit", "Vegetable", "Seeds" };

        protected override double GrowthRate { get; set; } = 0.35;

        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
            
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }
    }
}
