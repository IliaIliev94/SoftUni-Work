using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Raw_Data
{
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tire { get; set; }


        public Car(string model, Engine engine, Cargo cargo, Tire[] tire)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tire = tire;
        }

        public bool PressureLessThanOne()
        {
            foreach(var tire in this.Tire)
            {
                if(tire.Pressure < 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
