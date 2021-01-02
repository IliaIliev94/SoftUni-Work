using System;
using System.Collections.Generic;

namespace _03._Speed_Racing
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
                string name = carData[0];
                int fuelAmount = int.Parse(carData[1]);
                double fuelConsumption = double.Parse(carData[2]);
                cars.Add(new Car(name, fuelAmount, fuelConsumption));
            }

            string command = Console.ReadLine();

            while(!command.Equals("End"))
            {
                string[] carData = command.Split();
                string name = carData[1];
                int km = int.Parse(carData[2]);
                if (carData[0].Equals("Drive"))
                {
                    int index = cars.FindIndex(x => x.Model == name);
                    cars[index].Travel(km);
                }
                command = Console.ReadLine();
            }

            foreach(var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount.ToString("0.00")} {item.DistanceTraveled}");
            }
        }
    }

}
