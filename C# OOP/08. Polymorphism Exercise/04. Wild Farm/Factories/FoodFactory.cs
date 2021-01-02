using System;
using System.Collections.Generic;
using System.Text;
using _04._Wild_Farm.Models;

namespace _04._Wild_Farm.Factories
{
    class FoodFactory : IFoodFactory
    {
        public IFood CreateFood(string type, int quantity)
        {
            IFood food = null;
            if (type == "Fruit")
            {
                food = new Fruit(type, quantity);
            }
            else if(type == "Meat")
            {
                food = new Meat(type, quantity);
            }
            else if(type == "Seeds")
            {
                food = new Seeds(type, quantity);
            }
            else if(type == "Vegetable")
            {
                food = new Vegetable(type, quantity);
            }
            return food;
        }
    }
}
