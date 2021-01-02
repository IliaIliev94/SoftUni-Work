using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace _02._Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<characters>\D+)(?<number>[0-9]+)";
            string input = Console.ReadLine();
            List<char> uniques = new List<char>();
            MatchCollection matches = Regex.Matches(input, pattern);
            StringBuilder result = new StringBuilder();
            foreach(Match match in matches)
            {
                

                string sequence = match.Groups["characters"].Value;
                int length = int.Parse(match.Groups["number"].Value);
                if(length > 0)
                {
                    foreach (char character in sequence)
                    {
                        if(char.IsUpper(character))
                        {
                            uniques.Add(character);
                        }
                        else
                        {
                            uniques.Add(char.ToUpper(character));
                        }  
                    }
                    
                    sequence = sequence.ToUpper();
                    for (int i = 0; i < length; i++)
                    {
                        result.Append(sequence);
                    }
                }
                
            }
            uniques = uniques.Distinct().ToList();
            Console.WriteLine($"Unique symbols used: {uniques.Count}");
            Console.WriteLine(result);
        }
    }
}
