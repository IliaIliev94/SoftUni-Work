using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Composite
{
    public class SingleGift : GiftBase
    {
        public SingleGift(string name, int price)
            : base(name, price)
        {

        }

        public override int CalculateTotalPrice()
        {
            return this.Price;
        }

        public override string ToString()
        {
            return $"{this.Name} with the price {this.Price}";
        }
    }
}
