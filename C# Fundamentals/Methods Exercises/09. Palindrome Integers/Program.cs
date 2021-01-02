using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while(!command.Equals("END"))
            {
                int num = int.Parse(command);
                Console.WriteLine(isPalindrome(num).ToString().ToLower());
                command = Console.ReadLine();
            }
        }
        static bool isPalindrome(int a)
        {
            string reversedNumber = "";
            int counter = 0;
            for (int i = a; i != 0; i /= 10)
            {
                int num = i % 10;
                reversedNumber += num;
                counter++;
            }
            int result = int.Parse(reversedNumber);
            if (result == a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
