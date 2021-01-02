using System;
using System.Collections.Generic;
using System.Text;
using _04._Wild_Farm.Models.AnimalModels;

namespace _04._Wild_Farm.Factories
{
    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(string type, string name, double weight, double wingSize)
        {
            IAnimal animal = null;
            if(type == "Owl")
            {
                animal = new Owl(name, weight, wingSize);
            }
            else if(type == "Hen")
            {
                animal = new Hen(name, weight, wingSize);
            }
            return animal;
        }

        public IAnimal CreateAnimal(string type, string name, double weight, string livingRegion)
        {
            IAnimal animal = null;
            if(type == "Dog")
            {
                animal = new Dog(name, weight, livingRegion);
            }
            else if(type == "Mouse")
            {
                animal = new Mouse(name, weight, livingRegion);
            }
            return animal;
        }

        public IAnimal CreateAnimal(string type, string name, double weight, string livingRegion, string breed)
        {
            IAnimal animal = null;
            if(type == "Cat")
            {
                animal = new Cat(name, weight, livingRegion, breed);
            }
            else if(type == "Tiger")
            {
                animal = new Tiger(name, weight, livingRegion, breed);
            }
            return animal;
        }
    }
}
