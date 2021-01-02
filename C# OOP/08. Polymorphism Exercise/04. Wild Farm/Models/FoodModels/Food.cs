using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Wild_Farm.Models
{
    public abstract class Food : IFood
    {

        public string Type { get; private set; }
        public int Quantity { get; private set; }

        public Food(string type, int quantity)
        {
            this.Type = type;
            this.Quantity = quantity;
        }
    }
}
