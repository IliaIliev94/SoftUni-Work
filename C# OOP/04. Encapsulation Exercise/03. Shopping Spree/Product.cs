using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Shopping_Spree
{
    public class Product
    {
        private string name;
        private double cost;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public double Cost
        {
            get
            {
                return this.cost;
            }
            private set
            {
                if(value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }
                this.cost = value;
            }
        }

        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
    }
}
