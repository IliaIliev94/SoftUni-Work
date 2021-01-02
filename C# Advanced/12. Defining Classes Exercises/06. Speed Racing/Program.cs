using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for(int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = data[0];
                double fuelAmount = double.Parse(data[1]);
                double fuelConsumption = double.Parse(data[2]);
                cars.Add(new Car(model, fuelAmount, fuelConsumption));
            }
            string command = Console.ReadLine();

            while(!command.Equals("End"))
            {
                string[] data = command.Split();
                string model = data[1];
                double distance = double.Parse(data[2]);
                foreach(var car in cars)
                {
                    if(car.Model == model)
                    {
                        car.Drive(distance);
                    }
                }
                command = Console.ReadLine();
            }
            foreach(var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
