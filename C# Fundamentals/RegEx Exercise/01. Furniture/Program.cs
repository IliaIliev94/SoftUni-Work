using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string pattern = @">>(?<furniture>\w+)<<(?<price>\d+|\d+\.\d+)!(?<quantity>\d+)";
            List<string> furniture = new List<string>();
            double total = 0;
            while(!command.Equals("Purchase"))
            {
                bool isMatch = Regex.IsMatch(command, pattern);
                if (isMatch)
                {
                    Match temp = Regex.Match(command, pattern);
                    furniture.Add(temp.Groups["furniture"].ToString());
                    total += double.Parse(temp.Groups["price"].ToString()) * double.Parse(temp.Groups["quantity"].ToString());
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            foreach(var item in furniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {total.ToString("0.00")}");
        }
    }
}
