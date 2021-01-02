using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();
            bool firstEquality = false;

            for (int i = 0; i < input2.Length; i++)
            {
                for (int j = 0; j < input1.Length; j++)
                {
                    if (input1[j] == input2[i])
                    {
                        if (firstEquality)
                        {
                            Console.Write($" {input2[i]}");
                        }
                        else
                        {
                            Console.Write(input2[i]);
                        }
                        firstEquality = true;
                    }
                }
            }
        }
    }
}
