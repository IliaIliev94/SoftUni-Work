using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public abstract class Car : ICar
    {
        public string Model { get; private set; }
        public string Color { get; private set; }


        public Car(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }
        public string Start()
        {
            return "Engine start";
        }
        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{this.Color} {this.GetType().Name} {this.Model}");
            result.AppendLine(this.Start());
            result.Append(this.Stop());
            return result.ToString();
        }
    }
}
