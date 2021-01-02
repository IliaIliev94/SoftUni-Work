using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double coin;
            double sum = 0;
            while (!command.Equals("Start"))
            {
                coin = double.Parse(command);
                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    sum += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (!command.Equals("End"))
            {
                double price = 0;
                string product = "";
                if (command.Equals("Nuts"))
                {
                    price = 2;
                    product = "Nuts";
                }
                else if (command.Equals("Water"))
                {
                    price = 0.7;
                    product = "Water";
                }
                else if (command.Equals("Crisps"))
                {
                    price = 1.5;
                    product = "Crisps";
                }
                else if (command.Equals("Soda"))
                {
                    price = 0.8;
                    product = "Soda";
                }
                else if (command.Equals("Coke"))
                {
                    price = 1;
                    product = "Coke";
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                if (price != 0 && sum >= price)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    sum -= price;
                }
                else if (sum < price)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum.ToString("0.00")}");
        }
    }
}
