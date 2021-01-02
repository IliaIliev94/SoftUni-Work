using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[0-9]*?[^|$%.\d]*(?<price>\d+\.?\d+)\$$";
            string command = Console.ReadLine();
            double total = 0;
            while(!command.Equals("end of shift"))
            {
                Regex temp = new Regex(pattern);
                if(temp.IsMatch(command))
                {
                    Match match = temp.Match(command);
                    double sum = int.Parse(match.Groups["quantity"].ToString()) * double.Parse(match.Groups["price"].ToString());
                    Console.WriteLine($"{match.Groups["name"]}: {match.Groups["product"]} - {sum.ToString("0.00")}");
                    total += sum;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {total.ToString("0.00")}");
        }
    }
}
