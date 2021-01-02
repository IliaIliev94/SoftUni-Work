using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Wild_Farm.Models.AnimalModels
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }
        protected abstract List<string> Foods { get; set; }
        protected abstract double GrowthRate { get; set; }

        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public bool DoesEat(string food)
        {
            if(this.Foods.Contains(food))
            {
                return true;
            }
            return false;
        }

        public void Eat(int quantity)
        {
            this.Weight += this.GrowthRate * quantity;
            this.FoodEaten += quantity;
        }

        public abstract void ProduceSound();
    }
}
