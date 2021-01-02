using System;
using System.Linq;
using System.Collections.Generic;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int bulletsUsed = 0;
            int intelligence = int.Parse(Console.ReadLine());
            int counter = 0;
            while(bullets.Count != 0 && locks.Count != 0)
            {
                if(bullets.Pop() <= locks.Peek())
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                bulletsUsed++;
                counter++;
                if(counter == gunBarrelSize && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    counter = 0;
                }
            }
            if(locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligence - (bulletsUsed * bulletPrice)}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
