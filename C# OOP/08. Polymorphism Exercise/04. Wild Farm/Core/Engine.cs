using System;
using System.Collections.Generic;
using System.Text;
using _04._Wild_Farm.Factories;
using _04._Wild_Farm.Models;
using _04._Wild_Farm.Models.AnimalModels;

namespace _04._Wild_Farm.Core
{
    public class Engine : IEngine
    {
        private IAnimalFactory animalFactory;
        private IFoodFactory foodFactory;

        public void Run()
        {
            animalFactory = new AnimalFactory();
            foodFactory = new FoodFactory();
            List<IAnimal> animals = new List<IAnimal>();

            string command = Console.ReadLine();

            while(!command.Equals("End"))
            {
                string[] animalData = command.Split();
                string type = animalData[0];
                string name = animalData[1];
                double weight = double.Parse(animalData[2]);
                string[] foodData = Console.ReadLine().Split();
                string foodType = foodData[0];
                int foodQuantity = int.Parse(foodData[1]);
                IFood food = foodFactory.CreateFood(foodType, foodQuantity);
                IAnimal animal = null;
                if(type == "Owl" || type == "Hen")
                {
                    double wingSize = double.Parse(animalData[3]);
                    animal = animalFactory.CreateAnimal(type, name, weight, wingSize);
                }
                else if(type == "Dog" || type == "Mouse")
                {
                    string livingRegion = animalData[3];
                    animal = animalFactory.CreateAnimal(type, name, weight, livingRegion);
                }
                else
                {
                    string livingRegion = animalData[3];
                    string breed = animalData[4];
                    animal = animalFactory.CreateAnimal(type, name, weight, livingRegion, breed);
                }

                animal.ProduceSound();

                if(animal.DoesEat(food.Type))
                {
                    animal.Eat(food.Quantity);
                }
                else
                {
                    Console.WriteLine($"{animal.GetType().Name} does not eat {food.GetType().Name}!");
                }
                animals.Add(animal);
                command = Console.ReadLine();
            }

            foreach(var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
