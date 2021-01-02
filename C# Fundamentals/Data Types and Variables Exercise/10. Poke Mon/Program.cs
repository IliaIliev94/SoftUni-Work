using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int num = N;
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int targetsPoked = 0;

            while (num >= M)
            {

                if (num * 2 == N)
                {
                    if (Y != 0)
                    {
                        num /= Y;
                    }
                    
                }
                if (num >= M)
                {
                    num -= M;
                    targetsPoked++;
                }
            }
            Console.WriteLine(num);
            Console.WriteLine(targetsPoked);
        }
    }
}
