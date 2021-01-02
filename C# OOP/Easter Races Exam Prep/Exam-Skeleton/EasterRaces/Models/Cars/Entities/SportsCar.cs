using EasterRaces.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars.Entities
{
    public class SportsCar : Car, ICar
    {
        public SportsCar(string model, int horsePower) : base(model, horsePower, 3000, 250, 450)
        {

        }
    }
}
