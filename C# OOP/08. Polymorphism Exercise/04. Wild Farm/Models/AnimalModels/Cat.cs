using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Wild_Farm.Models.AnimalModels
{
    public class Cat : Feline
    {
        protected override List<string> Foods { get; set; } = new List<string>() { "Meat", "Vegetable" };
        protected override double GrowthRate { get; set; } = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
