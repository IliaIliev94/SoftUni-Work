using System;

namespace GenericScale
{
    public class Program
    {
        static void Main(string[] args)
        {
            EqualityScale<string> test = new EqualityScale<string>("Pesho", "Pesho");

            Console.WriteLine(test.AreEqual());
        }
    }
}
