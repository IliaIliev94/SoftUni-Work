using P01_RawData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01_RawData
{
    public class CarsRepository
    {
        public List<Car> Cars { get; private set; } = new List<Car>();

        public void AddCar(Car car)
        {
            this.Cars.Add(car);
        }

        public void RetrieveCars(string command)
        {
            if (command == "fragile")
            {
                List<string> fragile = this.Cars
                    .Where(x => x.Cargo.CargoType == "fragile" && x.Tire.tires.Any(y => y.Key < 1))
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, fragile));
            }
            else
            {
                List<string> flamable = this.Cars
                    .Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250)
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, flamable));
            }
        }
    }
}
