using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Vehicles_Extension
{
    public class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            protected set
            {
                this.tankCapacity = value;
            }
        }
        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            protected set
            {
                if(value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }
        public virtual double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            protected set
            {

                this.fuelConsumption = value;
            }
        }


        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public void Drive(double kilometers)
        {
            if(this.FuelQuantity >= kilometers * this.FuelConsumption)
            {
                this.FuelQuantity -= kilometers * this.FuelConsumption;
                Console.WriteLine($"{this.GetType().Name} travelled {kilometers} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }

        public virtual void Drive(double kilometers, bool isEmpty)
        {
            if (isEmpty)
            {
                this.Drive(kilometers);
            }
            else
            {
                double result = this.FuelQuantity - kilometers * (this.FuelConsumption + 1.4);
                if(result >= 0)
                {
                    this.FuelQuantity = result;
                    Console.WriteLine($"{this.GetType().Name} travelled {kilometers} km");
                }
                else
                {
                    Console.WriteLine($"{this.GetType().Name} needs refueling");
                }
            }
        }

        public virtual void Refuel(double liters)
        {
            if(liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if(liters + this.FuelQuantity > this.TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += liters;
            }
            
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
