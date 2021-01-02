using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Composite
{
    public abstract class GiftBase
    {
        public string Name { get; private set; }
        public int Price { get; private set; }

        public GiftBase(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public abstract int CalculateTotalPrice();
    }
}
