using System;
using System.Collections.Generic;

namespace _07._Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string model = data[0];
                int engineSpeed = int.Parse(data[1]);
                int enginePower = int.Parse(data[2]);
                int cargoWeight = int.Parse(data[3]);
                string cargoType = data[4];
                Tire[] tires = new Tire[4];
                for(int j = 5, counter = 0; j < data.Length; j+= 2, counter++)
                {
                    tires[counter] = new Tire(double.Parse(data[j]), int.Parse(data[j + 1]));
                }
                cars.Add(new Car(model, new Engine(engineSpeed, enginePower), new Cargo(cargoWeight, cargoType), tires));
            }
            string command = Console.ReadLine();

            if (command.Equals("fragile"))
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.CargoType.Equals("fragile") && car.PressureLessThanOne())
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.CargoType.Equals("flamable") && car.Engine.EnginePower > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
