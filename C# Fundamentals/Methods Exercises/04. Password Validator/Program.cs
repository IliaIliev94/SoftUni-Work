using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool chars = hasEnoughChars(input);
            bool digits = hasTwoDigits(input);
            bool correctness = isCorrectFormat(input);

            if (chars && digits && correctness)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!chars)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!correctness)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!digits)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        static bool hasEnoughChars(string s)
        {
            int chars = 0;
            for (int i = 0; i < s.Length; i++)
            {
                chars++;
            }
            if (chars >= 6 && chars <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool hasTwoDigits(string s)
        {
            int digits = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    digits++;
                }
            }
            if (digits >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool isCorrectFormat(string s)
        {
            bool isCorrect = true;

            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsDigit(s[i]) && !Char.IsLetter(s[i]))
                {
                    isCorrect = false;
                    break;
                }
            }

            return isCorrect;
        }
    }
}
