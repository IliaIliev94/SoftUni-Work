using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            bool notFound = false;
            double price = 0;
            string product = "";
            double sum = 0;

            while(!command.Equals("Game Time"))
            {
                switch(command)
                {
                    case "OutFall 4":
                        price = 39.99;
                        product = "OutFall 4";
                        break;
                    case "CS: OG":
                        price = 15.99;
                        product = "CS: OG";
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        product = "Zplinter Zell";
                        break;
                    case "Honored 2":
                        price = 59.99;
                        product = "Honored 2";
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        product = "RoverWatch";
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        product = "RoverWatch Origins Edition";
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        notFound = true;
                        break;
                }
                if (price > currentBalance)
                {
                    Console.WriteLine("Too Expensive");
                }
                else if (!notFound)
                {
                    currentBalance -= price;
                    sum += price;
                    Console.WriteLine($"Bought {product}");
                }
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                notFound = false;
                command = Console.ReadLine();
            }
            if (currentBalance != 0)
            {
                Console.WriteLine($"Total spent: ${sum.ToString("0.00")}. Remaining: ${currentBalance.ToString("0.00")}");
            }
            
        }
    }
}
