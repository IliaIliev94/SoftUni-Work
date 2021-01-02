using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Vehicle
    {
        public Vehicle(string Type, string Model, string Color, int Horsepower)
        {
            this.Type = Type[0].ToString().ToUpper() + Type.Substring(1, Type.Length - 1).ToString();
            this.Model = Model;
            this.Color = Color;
            this.Horsepower = Horsepower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public void Print()
        {
            Console.WriteLine($"Type: {this.Type}");
            Console.WriteLine($"Model: {this.Model}");
            Console.WriteLine($"Color: {this.Color}");
            Console.WriteLine($"Horsepower: {this.Horsepower}");
        }


    }
}
