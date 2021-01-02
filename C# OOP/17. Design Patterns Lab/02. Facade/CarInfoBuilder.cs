﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Facade
{
    public class CarInfoBuilder : CarBuilderFacade
    {
        public CarInfoBuilder(Car car)
        {
            Car = car;
        }

        public CarInfoBuilder WithType(string type)
        {
            Car.Type = type;
            return this;
        }

        public CarInfoBuilder WithColor(string color)
        {
            Car.Color = color;
            return this;
        }

        public CarInfoBuilder WithNumberOfDoors(int numberofDoors)
        {
            Car.NumberOfDoors = numberofDoors;
            return this;
        }
    }
}
