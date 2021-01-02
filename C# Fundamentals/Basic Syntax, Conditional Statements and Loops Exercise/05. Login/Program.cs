using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string passwordReversed = Console.ReadLine();
            string password = "";
            for (int i = passwordReversed.Length - 1; i >= 0; i--)
            {
                password += passwordReversed[i];
            }
            string input = Console.ReadLine();

            int counter = 1;
            while (!input.Equals(password) && counter < 4)
            {
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
                counter++;
                if (counter > 3)
                {
                    break;
                }
            }

            if (counter < 4)
            {
                Console.WriteLine($"User {passwordReversed} logged in.");
            }
            else
            {
                Console.WriteLine($"User {passwordReversed} blocked!");
            }
            
        }
    }
}
