using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Speed_Racing
{
    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelledDistance = 0;
        }

        public void Drive(double distance)
        {
            if(this.FuelAmount >= this.FuelConsumptionPerKilometer * distance)
            {
                this.FuelAmount -= this.FuelConsumptionPerKilometer * distance;
                this.TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
