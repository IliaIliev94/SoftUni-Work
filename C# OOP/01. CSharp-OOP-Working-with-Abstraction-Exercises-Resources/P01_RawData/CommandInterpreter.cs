using P01_RawData.Entities;
using P01_RawData.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public CommandInterpreter()
        {
            carsData = new CarsRepository();
            factory = new CarFactory();
        }
        public CarsRepository carsData;
        private IFactory factory;
        public void Run()
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Car car = factory.Create(parameters);
                this.carsData.AddCar(car);
            }
            string command = Console.ReadLine();
            carsData.RetrieveCars(command);
        }
    }
}
