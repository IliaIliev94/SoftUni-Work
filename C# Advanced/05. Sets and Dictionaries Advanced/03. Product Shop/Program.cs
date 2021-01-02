using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
            string command = Console.ReadLine();

            while(!command.Equals("Revision"))
            {
                string[] data = command.Split(", ");
                string shop = data[0];
                string product = data[1];
                double price = double.Parse(data[2]);
                if(shops.ContainsKey(shop))
                {
                    shops[shop].Add(product, price);
                }
                else
                {
                    Dictionary<string, double> temp = new Dictionary<string, double>();
                    temp.Add(product, price);
                    shops.Add(shop, temp);

                }
                command = Console.ReadLine();
            }
            shops = shops.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach(var item in shops)
            {
                Console.WriteLine($"{item.Key}->");
                foreach(var product in item.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
