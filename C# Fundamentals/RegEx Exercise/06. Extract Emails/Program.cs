using System;
using System.Text.RegularExpressions;
namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[\w]+[\-_\.]*[\w]+@([A-Za-z]+\-?[A-Za-z]+\.+)+[A-Za-z]+";
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < input.Length; i++)
            {
                if(char.IsLetterOrDigit(input[i][0]) && char.IsLetter(input[i][input[i].Length - 1]))
                {
                    Match match = Regex.Match(input[i], pattern);
                    if (match.Success == true)
                    {
                        Console.WriteLine(match);
                    }
                }
                else if (char.IsLetterOrDigit(input[i][0]) && char.IsLetter(input[i][input[i].Length - 2]) && i == input.Length - 1)
                {
                    Match match = Regex.Match(input[i], pattern);
                    if (match.Success == true)
                    {
                        Console.WriteLine(match);
                    }
                }
                else if (char.IsLetterOrDigit(input[i][0]) && char.IsLetter(input[i][input[i].Length - 2]) && input[i][input[i].Length - 1] == ',')
                {
                    Match match = Regex.Match(input[i], pattern);
                    if (match.Success == true)
                    {
                        Console.WriteLine(match);
                    }
                }

            }
        }
    }
}
