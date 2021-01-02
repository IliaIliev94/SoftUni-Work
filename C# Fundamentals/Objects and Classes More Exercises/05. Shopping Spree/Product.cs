using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Shopping_Spree
{
    class Product
    {
        public Product(string Name, int Cost)
        {
            this.Name = Name;
            this.Cost = Cost;
        }
        public string Name { get; set; }
        public int Cost { get; set; }
    }
}
