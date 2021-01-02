using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _02._Composite
{
    public class CompositeGift : GiftBase, IGiftOperations
    {
        private readonly List<GiftBase> gifts;
        public CompositeGift(string name, int price)
            : base(name, price)
        {
            gifts = new List<GiftBase>();
        }

        public void Add(GiftBase gift)
        {
            this.gifts.Add(gift);
        }

        public override int CalculateTotalPrice()
        {
            int totalPrice = this.Price + this.gifts.Sum(gift => gift.CalculateTotalPrice());
            return totalPrice;
        }

        public void Remove(GiftBase gift)
        {
            this.gifts.Remove(gift);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{this.Name} contains the following products (Total price {this.CalculateTotalPrice()}) with prices:");

            foreach(var giftBase in this.gifts)
            {
                result.AppendLine("---- " + giftBase);
            }

            return result.ToString().TrimEnd();
        }
    }
}
