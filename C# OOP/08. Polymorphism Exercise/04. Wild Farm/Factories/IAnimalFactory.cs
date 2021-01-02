using System;
using System.Collections.Generic;
using System.Text;
using _04._Wild_Farm.Models.AnimalModels;

namespace _04._Wild_Farm.Factories
{
    public interface IAnimalFactory
    {
        IAnimal CreateAnimal(string type, string name, double weight, double wingSize);

        IAnimal CreateAnimal(string type, string name, double weight, string livingRegion);

        IAnimal CreateAnimal(string type, string name, double weight, string livingRegion, string breed);
    }
}
