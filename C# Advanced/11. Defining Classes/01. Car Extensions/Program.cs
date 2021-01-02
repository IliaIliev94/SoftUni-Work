using System;

namespace _01._Car_Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();
            newCar.Model = "316";
            newCar.Year = 1994;
            newCar.Make = "BWM";

            Console.WriteLine(newCar.Make);
            Console.WriteLine(newCar.Model);
            Console.WriteLine(newCar.Year);
        }

    }
    public class Car
    {
        private string make;
        private string model;
        private int year;
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
    }
}
