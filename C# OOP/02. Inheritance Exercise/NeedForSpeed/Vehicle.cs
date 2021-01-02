using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        protected const double DefaultFuelConsumption = 1.25;
        public virtual double FuelConsumption => DefaultFuelConsumption;
        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }
        public virtual void Drive(double kilometers)
        {
            double fuelAfterDrive = this.Fuel -  kilometers* this.FuelConsumption;

            if(fuelAfterDrive >= 0)
            {
                this.Fuel = fuelAfterDrive;
            }
            Console.WriteLine(this.Fuel);
        }

    }
}
