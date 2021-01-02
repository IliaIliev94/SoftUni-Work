using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Vehicle.Models
{
    public class Car : Vehicle
    {
        public override double FuelConsumption => base.FuelConsumption + 0.9; 
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {

        }

        
    }
}
