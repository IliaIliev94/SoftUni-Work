using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();
            string command = Console.ReadLine();

            while(!command.Equals("buy"))
            {
                string[] productInfo = command.Split();
                string product = productInfo[0]
;               double price = double.Parse(productInfo[1]);
                int quantity = int.Parse(productInfo[2]);
                if (products.ContainsKey(product))
                {
                    products[product][0] = price;
                    products[product][1] += quantity;
                }
                else
                {
                    double[] temp = { price, quantity };
                    products.Add(product, temp);
                }
                command = Console.ReadLine();
            }
            foreach(var item in products)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]).ToString("0.00")}");
            }
        }
    }
}
