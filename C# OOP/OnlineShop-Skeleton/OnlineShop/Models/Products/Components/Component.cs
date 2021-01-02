using OnlineShop.Common.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Components
{
    public abstract class Component : Product, IComponent
    {
        public int Generation { get; private set; }


        protected virtual double OverallPerformanceMultiplyer => 1;

        public Component(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation)
            : base(id, manufacturer, model, price, overallPerformance)
        {
            this.Generation = generation;
        }

        public override double OverallPerformance { get => base.OverallPerformance * OverallPerformanceMultiplyer; }

        public override string ToString()
        {
            return $"{base.ToString()}{string.Format(SuccessMessages.ComponentToString, this.Generation)}";
        }
    }
}
