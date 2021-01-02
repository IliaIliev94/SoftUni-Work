using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());

            if (one >= two && two >= three)
            {
                Console.WriteLine(one);
                Console.WriteLine(two);
                Console.WriteLine(three);
            }
            else if (one >= three && three >= two)
            {
                Console.WriteLine(one);
                Console.WriteLine(three);
                Console.WriteLine(two);
            }
            else if (two >= one && one >= three)
            {
                Console.WriteLine(two);
                Console.WriteLine(one);
                Console.WriteLine(three);
            }
            else if (two >= three && three >= one)
            {
                Console.WriteLine(two);
                Console.WriteLine(three);
                Console.WriteLine(one);
            }
            else if (three >= one && one >= two)
            {
                Console.WriteLine(three);
                Console.WriteLine(one);
                Console.WriteLine(two);
            }
            else
            {
                Console.WriteLine(three);
                Console.WriteLine(two);
                Console.WriteLine(one);
            }
        }
    }
}
