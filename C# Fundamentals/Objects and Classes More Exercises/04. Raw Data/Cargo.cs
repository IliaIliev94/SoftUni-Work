using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Raw_Data
{
    class Cargo
    {
        public Cargo(int CargoWeight, string CargoType)
        {
            this.CargoWeight = CargoWeight;
            this.CargoType = CargoType;
        }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
}
