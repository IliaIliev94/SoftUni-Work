using System;
using System.Collections.Generic;
using System.Text;
using _04._Wild_Farm.Models;

namespace _04._Wild_Farm.Factories
{
    public interface IFoodFactory
    {
        IFood CreateFood(string type, int quantity);
    }
}
