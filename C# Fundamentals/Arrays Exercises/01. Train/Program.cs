using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] people = new int[input];
            int sum = 0;
            for (int i = 0; i < input; i++)
            {
                int n = int.Parse(Console.ReadLine());
                people[i] = n;
                sum += people[i];
            }
            for (int i = 0; i < people.Length; i++)
            {
                if (i != people.Length - 1)
                {
                    Console.Write($"{people[i]} ");
                }
                else
                {
                    Console.WriteLine(people[i]);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
