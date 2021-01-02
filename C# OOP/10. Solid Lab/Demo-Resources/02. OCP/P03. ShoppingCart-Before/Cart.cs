using P03._ShoppingCart_Before.Contracts;
using P03._ShoppingCart_Before.Rules;
using System.Linq;
namespace P03._ShoppingCart
{
    using System.Collections.Generic;

    public class Cart
    {
        private readonly List<OrderItem> items;

        public Cart()
        {
            this.items = new List<OrderItem>();
        }

        public IEnumerable<OrderItem> Items
        {
            get { return new List<OrderItem>(this.items); }
        }

        public string CustmerEmail { get; set; }

        public void Add(OrderItem orderItem)
        {
            this.items.Add(orderItem);
        }

        public decimal TotalAmount()
        {
            decimal total = 0m;
            List<IAmountRules> amountRules = new List<IAmountRules>()
            {
                new EachAmountRule(),
                new SpecialAmountRule(),
                new WeightAmountRule()
            };
            foreach (var item in this.items)
            {
                total += amountRules.First(rule => rule.IsMatch(item)).Calculate(item);
            }

            return total; 
        }
    }
}
