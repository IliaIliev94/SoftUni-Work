using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : 
            this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, 
            Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public void PrintCar()
        {
            Console.WriteLine($"Make: {this.Make}");
            Console.WriteLine($"Model: {this.Model}");
            Console.WriteLine($"Year: {this.Year}");
            Console.WriteLine($"HorsePowers: {this.Engine.HorsePower}");
            Console.WriteLine($"FuelQuantity: {this.FuelQuantity}");
        }

        public void Drive()
        {
            this.FuelQuantity -= this.FuelConsumption / 10 * 2;
        }

        public double TireSum()
        {
            double result = 0;

            foreach(var tire in this.Tires)
            {
                result += tire.Pressure;
            }

            return result;
        }
    }
}
