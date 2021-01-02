using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _03._Shopping_Spree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> bag;

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

        public double Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if(value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> Bag
        {
            get
            {
                return this.bag.AsReadOnly();
            }
        }
        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }

        public void Add(Product product)
        {
            if(this.Money >= product.Cost)
            {
                this.Money -= product.Cost;
                this.bag.Add(product);
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"{this.Name} - {GetProducts()}");
            return result.ToString();
        }

        public string GetProducts()
        {
            StringBuilder result = new StringBuilder();
            if(this.bag.Count == 0)
            {
                result.Append("Nothing bought");
            }

            for(int i = 0; i < this.bag.Count; i++)
            {
                if(i == 0)
                {
                    result.Append(this.bag[i].Name);
                }
                else
                {
                    result.Append($", {this.bag[i].Name}");
                }
            }

            return result.ToString();
        }
    }
}
