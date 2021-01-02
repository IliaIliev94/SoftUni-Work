using EasterRaces.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars.Entities
{
    public class MuscleCar : Car, ICar
    {

        public MuscleCar(string model, int horsepower) 
            : base(model, horsepower, 5000)
        {

        }

        protected override int MinHorsePower => 400;

        protected override int MaxHorsePower => 600;
    }
}
