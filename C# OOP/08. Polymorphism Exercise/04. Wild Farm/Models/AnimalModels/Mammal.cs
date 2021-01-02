using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Wild_Farm.Models.AnimalModels
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; private set; }
        public Mammal(string name, double weight, string livingRegion) 
            : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
