using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Raw_Data
{
    class Car
    {
        public Car(string Model, Engine Engine, Cargo Cargo)
        {
            this.Model = Model;
            this.Engine = new Engine(Engine.EngineSpeed, Engine.EnginePower);
            this.Cargo = new Cargo(Cargo.CargoWeight, Cargo.CargoType);
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

    }
}
