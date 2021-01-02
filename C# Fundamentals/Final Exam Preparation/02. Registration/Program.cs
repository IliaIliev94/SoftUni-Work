using System;
using System.Text.RegularExpressions;

namespace _02._Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"U\$(?<username>[A-Z][a-z]{2}[a-z]*)U\$P@\$(?<password>[A-Za-z]{5}[A-Za-z]*[0-9]+)P@\$";
            int n = int.Parse(Console.ReadLine());
            int successfullRegistrations = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                if (match.Success == true)
                {
                    successfullRegistrations++;
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {match.Groups["username"].Value}, Password: {match.Groups["password"].Value}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {successfullRegistrations}");
        }
    }
}
