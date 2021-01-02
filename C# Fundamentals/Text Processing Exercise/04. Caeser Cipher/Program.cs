using System;
using System.Text;
namespace _04._Caeser_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                result.Append((char)(((int)input[i] + 3) % 128));
            }
            Console.WriteLine(result);
        }
    }
}
