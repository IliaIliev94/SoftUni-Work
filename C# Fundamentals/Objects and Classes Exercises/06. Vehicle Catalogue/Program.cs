using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string command = Console.ReadLine();

            while(!command.Equals("End"))
            {
                string[] vehicleData = command.Split();
                vehicles.Add(new Vehicle(vehicleData[0], vehicleData[1], vehicleData[2], int.Parse(vehicleData[3])));
                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while(!command.Equals("Close the Catalogue"))
            {

                string[] vehicleData = command.Split();
                for (int i = 0; i < vehicles.Count; i++)
                {
                    if (vehicles[i].Model == command)
                    {
                        vehicles[i].Print();
                    }
                }
                command = Console.ReadLine();
            }

            List<Vehicle> cars = vehicles.Where(x => x.Type == "Car").ToList();
            List<Vehicle> trucks = vehicles.Where(x => x.Type == "Truck").ToList();

            int carsHorsePower = cars.Sum(x => x.Horsepower);
            int trucksHorsePower = trucks.Sum(x => x.Horsepower);

            if (cars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {(carsHorsePower * 1.0 / cars.Count).ToString("0.00")}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }

            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {(trucksHorsePower * 1.0 / trucks.Count).ToString("0.00")}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }
    
}
