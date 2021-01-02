using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Prototype_Pattern
{
    public class Ingridient
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"Ingridient: {this.Name}, {this.Quantity}";
        }

        public Ingridient(string name, int quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
        }
    }
}
