using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Computers
{
    public class Laptop : Computer, IComputer
    {
        public Laptop(int id, string manufacturer, string model, decimal price)
            : base(id, manufacturer, model, price, 10)
        {

        }
    }
}
