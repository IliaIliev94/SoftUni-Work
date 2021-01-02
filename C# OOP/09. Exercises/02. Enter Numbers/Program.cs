using System;

namespace _02._Enter_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                try
                {
                    Console.WriteLine(ReadNumber(1, 100));
                    i++;
                }
                catch(ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Enter a number between 1 and 100");
                    i = 0;
                }
                catch(Exception)
                {
                    Console.WriteLine("Enter a valid number");
                    i = 0;
                }
            }
        }

        public static int ReadNumber(int start, int end)
        {
            int n = int.Parse(Console.ReadLine());
            if(n < start || n > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            return n;
        }
    }
}
