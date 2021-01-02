using System;

namespace _04._Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            
            var result = Morse.TextToMorse(input);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
