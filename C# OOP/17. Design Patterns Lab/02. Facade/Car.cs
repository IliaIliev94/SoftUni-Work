using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Facade
{
    public class Car
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }

        public string City { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"CarType: {Type}, Color: {Color}, Number of doors: {NumberOfDoors}, Manifactured in {City}, at address: {Address}";
        }
    }
}
