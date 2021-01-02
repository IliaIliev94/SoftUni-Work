using P03._ShoppingCart;
using P03._ShoppingCart_Before.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03._ShoppingCart_Before.Rules
{
    public class SpecialAmountRule : IAmountRules
    {
        public decimal Calculate(OrderItem item)
        {
            return item.Quantity * .4m - item.Quantity / 3 * .2m;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("SPECIAL");
        }
    }
}
