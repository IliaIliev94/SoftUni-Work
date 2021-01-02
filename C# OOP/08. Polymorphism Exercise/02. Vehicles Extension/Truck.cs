using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Vehicles_Extension
{
    public class Truck : Vehicle
    {
        public override double FuelConsumption => base.FuelConsumption + 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (liters + this.FuelQuantity > this.TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += liters * 0.95;
            }
        }
    }
}
