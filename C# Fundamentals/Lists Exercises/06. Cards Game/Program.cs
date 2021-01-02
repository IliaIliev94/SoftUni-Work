using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> deck1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> deck2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; deck1.Count != 0 && deck2.Count != 0; i++)
            {
                if (deck1[0] > deck2[0])
                {
                    deck1.Add(deck1[0]);
                    deck1.RemoveAt(0);
                    deck1.Add(deck2[0]);
                    deck2.RemoveAt(0);
                }
                else if (deck2[0] > deck1[0])
                {
                    deck2.Add(deck2[0]);
                    deck2.RemoveAt(0);
                    deck2.Add(deck1[0]);
                    deck1.RemoveAt(0);
                }
                else
                {
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                }
            }
            int sum1 = deck1.Sum();
            int sum2 = deck2.Sum();

            if (sum1 > sum2)
            {
                Console.WriteLine($"First player wins! Sum: {sum1}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {sum2}");

            }
        }
    }
}
