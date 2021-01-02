using System;
using System.Collections.Generic;
using System.Text;
using _01._Vehicle.Models;

namespace _01._Vehicle.Factories
{
    public interface IVehicleFactory
    {

        IVehicle CreateVehicle(string type, double fuelQuantity, double fuelConsumption);
    }
}
