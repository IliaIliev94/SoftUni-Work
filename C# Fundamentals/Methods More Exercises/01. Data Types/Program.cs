using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string input = Console.ReadLine();
            dataTypes(command, input);

        }
        static void dataTypes(string s, string data)
        {
            if (s.Equals("int"))
            {
                int result = int.Parse(data) * 2;
                Console.WriteLine(result);
            }
            else if (s.Equals("real"))
            {
                double result = double.Parse(data) * 1.5;
                Console.WriteLine(result.ToString("0.00"));
            }
            else
            {
                Console.WriteLine($"${data}$");
            }
        }
    }
}
