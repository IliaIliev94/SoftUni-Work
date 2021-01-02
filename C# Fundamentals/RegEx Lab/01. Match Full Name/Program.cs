using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string pattern = @"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(names);


            Console.WriteLine(string.Join(" ", matches));

        }
    }
}
