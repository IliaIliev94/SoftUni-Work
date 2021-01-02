using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public const double DefaultRaceMotorcycleFuelConsumption = 8;
        public override double FuelConsumption => DefaultRaceMotorcycleFuelConsumption;
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
    }
}
