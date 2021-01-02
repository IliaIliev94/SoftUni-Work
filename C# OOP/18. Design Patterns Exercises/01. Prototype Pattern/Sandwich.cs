using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Prototype_Pattern
{
    public class Sandwich : SandwichPrototype
    {
        public string Bread { get; set; }
        public string Meat { get; set; }
        public string Cheese { get; set; }
        public string Veggies { get; set; }
        public Ingridient Ingridient { get; set; }

        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            this.Bread = bread;
            this.Meat = meat;
            this.Cheese = cheese;
            this.Veggies = veggies;
        }

        public override string ToString()
        {
            return $"{this.Bread}, {this.Meat}, {this.Cheese}, {this.Veggies}. {this.Ingridient}";
        }
        public override SandwichPrototype Clone()
        {
            return this.MemberwiseClone() as SandwichPrototype;
        }
    }
}
