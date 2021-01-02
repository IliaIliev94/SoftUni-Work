using EasterRaces.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars.Entities
{
    public class SportsCar : Car, ICar
    {
        public SportsCar(string model, int horsepower)
            : base(model, horsepower, 3000)
        {

        }

        protected override int MinHorsePower => 250;

        protected override int MaxHorsePower => 450;
    }
}
