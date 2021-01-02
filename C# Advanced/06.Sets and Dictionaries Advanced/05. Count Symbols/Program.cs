using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> characterOccurances = new Dictionary<char, int>();
            string characters = Console.ReadLine();

            foreach(char character in characters)
            {
                if(characterOccurances.ContainsKey(character))
                {
                    characterOccurances[character]++;
                }
                else
                {
                    characterOccurances.Add(character, 1);
                }
            }
            characterOccurances = characterOccurances.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach(var item in characterOccurances)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
