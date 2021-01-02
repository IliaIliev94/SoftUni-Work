using OnlineShop.Common.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Components
{
    public abstract class Component : Product, IComponent
    {
        public int Generation { get; private set; }

        public Component(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation) : 
            base(id, manufacturer, model, price, overallPerformance)
        {
            Generation = generation;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(SuccessMessages.ComponentToString, Generation);
        }
    }
}
