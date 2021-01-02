using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int raxCapacity = int.Parse(Console.ReadLine());
            int raxCount = 1;
            int sum = 0;
            while(clothes.Count != 0)
            {
                int cloth = clothes.Peek();
                if(sum + cloth <= raxCapacity)
                {
                    sum += clothes.Pop();
                }
                else
                {
                    raxCount++;
                    sum = 0;
                }
            }
            Console.WriteLine(raxCount);
        }
    }
}
