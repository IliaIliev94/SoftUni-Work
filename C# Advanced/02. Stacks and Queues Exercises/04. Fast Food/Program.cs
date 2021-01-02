using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> orders = new Queue<int>();
            int n = int.Parse(Console.ReadLine());
            int[] order = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int max = 0;
            for (int i = 0; i < order.Length; i++)
            {
                if(order[i] > max)
                {
                    max = order[i];
                }
                orders.Enqueue(order[i]);
            }

            for(int i = 0; orders.Count > 0 && n >= orders.Peek();  i++)
            {

                int temp = orders.Dequeue();
                n -= temp;

            }
            Console.WriteLine(max);
            if(orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders.ToArray())}");
            }
        }
    }
}
