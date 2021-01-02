﻿using P03._ShoppingCart;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03._ShoppingCart_Before.Contracts
{
    public interface IAmountRules
    {
        decimal Calculate(OrderItem item);

        bool IsMatch(OrderItem item);
    }
}
