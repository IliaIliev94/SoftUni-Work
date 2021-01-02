using System;
using System.Text;

namespace _05._Digits__Letters_and_Others
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder ints = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    ints.Append(input[i]);
                }
                else if (char.IsLetter(input[i]))
                {
                    letters.Append(input[i]);
                }
                else
                {
                    others.Append(input[i]);
                }
            }
            Console.WriteLine(ints);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
