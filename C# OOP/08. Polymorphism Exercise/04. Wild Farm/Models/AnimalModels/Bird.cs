using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Wild_Farm.Models.AnimalModels
{
    public abstract class Bird : Animal
    {
        public double WingSize { get; private set; }

        public Bird(string name, double weight, double wingSize) 
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
