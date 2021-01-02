using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
namespace _03._Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");
            string firstPattern = @"([#$%*&]{1})(?<letters>[A-Z]+)(\1)";
            Match capitalLetters = Regex.Match(input[0], firstPattern);
            Dictionary<char, int> letters = new Dictionary<char, int>();
            foreach(var letter in capitalLetters.Groups["letters"].Value)
            {
                letters.Add(letter, 0);
            }
            string secondPattern = @"(?<character>[0-9]{2}):(?<length>[0-9]{2})";
            MatchCollection lettersCount = Regex.Matches(input[1], secondPattern); 
            foreach(Match match in lettersCount)
            {
                char letter = (char)int.Parse(match.Groups["character"].Value);
                if (letters.ContainsKey(letter))
                {
                    letters[letter] = int.Parse(match.Groups["length"].Value);
                }
            }
            foreach(var item in letters)
            {
                string finalPattern = @"" + "(?<![!-z])" + item.Key + "[!-z]" + "{" + item.Value + "}" + "(?![!-z])";
                Match temp = Regex.Match(input[2], finalPattern);
                Console.WriteLine(temp);
            }
        }
    }
}
