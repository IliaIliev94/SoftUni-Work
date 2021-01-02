using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            string pattern = @"[SsTtAaRr]";
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                MatchCollection matches = Regex.Matches(input, pattern);
                int counter = 0;
                foreach(Match match in matches)
                {
                    counter++;
                }
                string newInput = new string("");
                for (int j = 0; j < input.Length; j++)
                {
                    newInput += (char)(input[j] - counter);
                }
                string planetPattern = @"[^@\-!:>]*@(?<planet>[A-Z[a-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<type>A|D)![^@\-!:>]*->(?<soldiers>\d+)[^@\-!:>]*";
                Match planetMatch = Regex.Match(newInput, planetPattern);
                if (planetMatch.Success == true)
                {
                    if (planetMatch.Groups["type"].ToString() == "A")
                    {
                        attackedPlanets.Add(planetMatch.Groups["planet"].ToString());
                    }
                    else
                    {
                        destroyedPlanets.Add(planetMatch.Groups["planet"].ToString());
                    }
                }
            }
            attackedPlanets.Sort();
            destroyedPlanets.Sort();
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach(var planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach(var planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
