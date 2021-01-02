using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            while(!command.Equals("No more tires"))
            {
                string[] data = command.Split();
                Tire[] tiresData = new Tire[data.Length / 2];
                for(int i = 0, counter = 0; i < data.Length; i+=2, counter++)
                {
                    int year = int.Parse(data[i]);
                    double pressure = double.Parse(data[i]);
                    tiresData[counter] = new Tire(year, pressure);
                }
                tires.Add(tiresData);
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while(!command.Equals("Engines done"))
            {
                string[] data = command.Split();
                int horsePower = int.Parse(data[0]);
                double cubicCylinder = double.Parse(data[1]);
                engines.Add(new Engine(horsePower, cubicCylinder));
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while(!command.Equals("Show special"))
            {
                string[] data = command.Split();
                string make = data[0];
                string model = data[1];
                int year = int.Parse(data[2]);
                double fuelQuantity = double.Parse(data[3]);
                double fuelConsumption = double.Parse(data[4]);
                int engineIndex = int.Parse(data[5]);
                int tiresIndex = int.Parse(data[6]);

                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]));
                command = Console.ReadLine();
            }

            foreach(var car in cars)
            {
                if(car.Year >= 2017 && car.Engine.HorsePower > 330 && (car.TireSum() >= 9 && car.TireSum() <= 10))
                {
                    car.Drive();
                    car.PrintCar();
                }
            }
        }
    }
}
