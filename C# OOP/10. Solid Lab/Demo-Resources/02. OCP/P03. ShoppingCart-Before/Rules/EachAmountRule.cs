using P03._ShoppingCart;
using P03._ShoppingCart_Before.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03._ShoppingCart_Before.Rules
{
    class EachAmountRule : IAmountRules
    {
        public decimal Calculate(OrderItem item)
        {
            return item.Quantity * 5m;
        }

        bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("EACH");
        }
    }
}
