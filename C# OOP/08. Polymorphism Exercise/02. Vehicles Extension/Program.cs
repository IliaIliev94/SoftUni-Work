using System;

namespace _02._Vehicles_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carData = Console.ReadLine().Split();
            string[] truckData = Console.ReadLine().Split();
            string[] busData = Console.ReadLine().Split();

            Car car = new Car(double.Parse(carData[1]), double.Parse(carData[2]), double.Parse(carData[3]));
            Truck truck = new Truck(double.Parse(truckData[1]), double.Parse(truckData[2]), double.Parse(truckData[3]));
            Bus bus = new Bus(double.Parse(busData[1]), double.Parse(busData[2]), double.Parse(busData[3]));

            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                if(data[1].Equals("Car"))
                {
                    switch(data[0])
                    {
                        case "Drive":
                            car.Drive(double.Parse(data[2]));
                            break;
                        case "Refuel":
                            car.Refuel(double.Parse(data[2]));
                            break;
                    }
                }
                else if(data[1].Equals("Truck"))
                {
                    switch (data[0])
                    {
                        case "Drive":
                            truck.Drive(double.Parse(data[2]));
                            break;
                        case "Refuel":
                            truck.Refuel(double.Parse(data[2]));
                            break;
                    }
                }
                else
                {
                    switch (data[0])
                    {
                        case "DriveEmpty":
                            bus.Drive(double.Parse(data[2]), true);
                            break;
                        case "Drive":
                            bus.Drive(double.Parse(data[2]), false);
                            break;
                        case "Refuel":
                            bus.Refuel(double.Parse(data[2]));
                            break;
                    }
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
