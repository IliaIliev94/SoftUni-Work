using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Shopping_Spree
{
    class Person
    {
        public Person (string Name, int Money)
        {
            this.Name = Name;
            this.Money = Money;
            Products = new List<Product>();
        }
        public string Name { get; set; }
        public int Money { get; set; }
        public List<Product> Products { get; set; }

        public void AddProduct(Product Product)
        {
            if (Money >= Product.Cost)
            {
                Products.Add(Product);
                Money -= Product.Cost;
                Console.WriteLine($"{Name} bought {Product.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {Product.Name}");
            }
        }

        public void Print()
        {
            if (Products.Count > 0)
            {
                Console.Write($"{Name} - ");
                for (int i = 0; i < Products.Count; i++)
                {
                    if (i != 0)
                    {
                        Console.Write($", {Products[i].Name}");
                    }
                    else
                    {
                        Console.Write(Products[i].Name);
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{Name} - Nothing bought");
            }
        }
    }
}
