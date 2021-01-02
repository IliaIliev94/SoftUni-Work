using System;
using System.Text;

namespace _07._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());
            var message = new StringBuilder();
            char c;

            for (int i = 0; i < numberOfLines; i++)
            {
                c = (char)(Char.Parse(Console.ReadLine()) + key);
                message .Append(c);
                
            }
            Console.WriteLine(message);
        }
    }
}
