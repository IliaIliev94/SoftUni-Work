using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Vehicle.Models
{
    public class Truck : Vehicle
    {
        public override double FuelConsumption => base.FuelConsumption + 1.6;

        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {

        }

        public override void Refuel(double liters)
        {
            this.FuelQuantity += (liters * 0.95);
        }
    }
}
