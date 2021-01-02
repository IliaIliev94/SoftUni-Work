using System;

namespace _05._Convert.ToDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                double num = Convert.ToDouble(input);
                Console.WriteLine(num);
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid format.");
                throw new FormatException();
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Argument out of range");
                throw new ArgumentException();
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid input");
                throw new Exception();
            }
        }
    }
}
