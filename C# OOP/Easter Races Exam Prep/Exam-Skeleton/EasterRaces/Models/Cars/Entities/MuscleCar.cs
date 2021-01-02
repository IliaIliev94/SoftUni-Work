using EasterRaces.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars.Entities
{
    public class MuscleCar : Car, ICar
    {
        public MuscleCar(string model, int horsePower) : base(model, horsePower, 5000, 400, 600)
        {

        }
    }
}
