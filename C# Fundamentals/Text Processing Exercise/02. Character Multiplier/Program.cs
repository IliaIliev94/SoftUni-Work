using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int result = charMultiplier(input[0], input[1]);
            Console.WriteLine(result);
        }
        static int charMultiplier(string s1, string s2)
        {
            int sum = 0;

            for (int i = 0; i < Math.Max(s1.Length, s2.Length); i++)
            {
                if (i > s1.Length - 1)
                {
                    sum += (int)s2[i];
                }
                else if (i > s2.Length - 1)
                {
                    sum += (int)s1[i];
                }
                else
                {
                    int multiply = (int)s1[i] * (int)s2[i];
                    sum += multiply;
                }
                
            }
            return sum;
        }
    }
}
