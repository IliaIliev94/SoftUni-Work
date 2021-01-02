using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Vehicle.Models
{
    public interface IVehicle
    {
        double FuelQuantity { get; }
        double FuelConsumption { get; }

        void Drive(double kilometers);
        void Refuel(double liters);

        string ToString();
    }
}
