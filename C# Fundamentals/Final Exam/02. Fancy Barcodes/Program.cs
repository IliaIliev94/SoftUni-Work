using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@\#+[A-Z]{1}[A-Za-z0-9]{4}[A-Za-z0-9]*[A-Z]{1}@\#+";
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                if(match.Success == true)
                {
                    string temp = new string("");
                    string compare = match.Value;
                    for(int j = 0; j < compare.Length; j++)
                    {
                        if(char.IsDigit(compare[j]))
                        {
                            temp += compare[j];
                        }
                    }
                    if(temp == "")
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {temp}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
