using System;
using System.Collections.Generic;
using System.Text;
using _01._Vehicle.IO;
using _01._Vehicle.Factories;
using _01._Vehicle.Models;

namespace _01._Vehicle.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IVehicleFactory vehicleFactory;

        public Engine()
        {
            reader = new CustomReader();
            writer = new CustomWriter();
            vehicleFactory = new VehicleFactory();
        }
        public void Run()
        {
            string[] carData = this.reader.CustomReadLine().Split();
            string type = carData[0];
            double fuelQuantity = double.Parse(carData[1]);
            double fuelConsumption = double.Parse(carData[2]);

            IVehicle car = this.vehicleFactory.CreateVehicle(type, fuelQuantity, fuelConsumption);

            string[] truckData = this.reader.CustomReadLine().Split();
            type = truckData[0];
            fuelQuantity = double.Parse(truckData[1]);
            fuelConsumption = double.Parse(truckData[2]);

            IVehicle truck = this.vehicleFactory.CreateVehicle(type, fuelQuantity, fuelConsumption);

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                if(data[0].Equals("Drive"))
                {
                    double kilometers = double.Parse(data[2]);
                    switch (data[1])
                    {
                        
                        case "Car":
                            car.Drive(kilometers);
                            break;
                        case "Truck":
                            truck.Drive(kilometers);
                            break;
                    }
                }
                else
                {
                    double liters = double.Parse(data[2]);
                    switch(data[1])
                    {
                        case "Car":
                            car.Refuel(liters);
                            break;
                        case "Truck":
                            truck.Refuel(liters);
                            break;
                    }
                }
            }
            writer.CustomWriteLine(car.ToString());
            writer.CustomWriteLine(truck.ToString());
        }
    }
}
