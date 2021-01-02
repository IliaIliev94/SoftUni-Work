using System;

namespace _01._Square_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            try
            {
                int n;
                int.TryParse(s, out n);
                if(n < 0)
                {
                    throw new Exception();
                }
                Console.WriteLine(n);
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
