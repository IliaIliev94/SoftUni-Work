using System;

namespace _01._Class_Box_Data
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            try
            {
                Box myBox = new Box(a, b, c);
                Console.WriteLine(myBox);
            }
            catch(Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
        }
    }
}
