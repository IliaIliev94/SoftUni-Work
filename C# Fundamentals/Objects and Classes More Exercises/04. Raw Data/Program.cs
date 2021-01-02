using System;
using System.Collections.Generic;

namespace _04._Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] carData = Console.ReadLine().Split();
                string model = carData[0];
                int engineSpeed = int.Parse(carData[1]);
                int enginePower = int.Parse(carData[2]);
                int cargoWeight = int.Parse(carData[3]);
                string cargoType = carData[4];
                cars.Add(new Car(model, new Engine(engineSpeed, enginePower), new Cargo(cargoWeight, cargoType)));
            }
            string command = Console.ReadLine();

            if (command.Equals("fragile"))
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].Cargo.CargoType == "fragile" && cars[i].Cargo.CargoWeight < 1000)
                    {
                        Console.WriteLine($"{cars[i].Model}");
                    }
                }
            }
            else
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].Cargo.CargoType == "flamable" && cars[i].Engine.EnginePower > 250)
                    {
                        Console.WriteLine($"{cars[i].Model}");
                    }
                }
            }
        }
    }

}
