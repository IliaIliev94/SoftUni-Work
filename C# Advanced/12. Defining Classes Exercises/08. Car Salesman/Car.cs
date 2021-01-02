using System;
using System.Collections.Generic;
using System.Text;

namespace _08._Car_Salesman
{
    class Car
    {
        public string Mode { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public Car(string mode, Engine engine)
        {
            this.Mode = mode;
            this.Engine = engine;
        }

        public Car(string mode, Engine engine, int weight = 0, string color = null) : this(mode, engine)
        {
            this.Weight = weight;
            this.Color = color;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{this.Mode}:");
            result.AppendLine($"  {this.Engine.Model}:");
            result.AppendLine($"    Power: {this.Engine.Power}");
            if(this.Engine.Displacement == 0)
            {
                result.AppendLine($"    Displacement: n/a");
            }
            else
            {
                result.AppendLine($"    Displacement: {this.Engine.Displacement}");
            }
            if (this.Engine.Efficiency == null)
            {
                result.AppendLine($"    Efficiency: n/a");
            }
            else
            {
                result.AppendLine($"    Efficiency: {this.Engine.Efficiency}");
            }
            if (this.Weight == 0)
            {
                result.AppendLine($"  Weight: n/a");
            }
            else
            {
                result.AppendLine($"  Weight: {this.Weight}");
            }
            if (this.Color == null)
            {
                result.Append($"  Color: n/a");
            }
            else
            {
                result.Append($"  Color: {this.Color}");
            }

            return result.ToString();
        }
    }
}
