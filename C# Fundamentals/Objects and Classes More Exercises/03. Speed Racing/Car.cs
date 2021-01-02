using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Speed_Racing
{
    class Car
    {
        public Car(string Model, int FuelAmount, double FuelConsumption)
        {
            this.Model = Model;
            this.FuelAmount = FuelAmount;
            this.FuelConsumption = FuelConsumption;
            DistanceTraveled = 0;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public int DistanceTraveled { get; set; }

        public void Travel(int Distance)
        {
            double FuelConsumned = this.FuelConsumption * Distance;
            if (this.FuelAmount >= FuelConsumned)
            {
                this.FuelAmount -= FuelConsumned;
                this.DistanceTraveled += Distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
