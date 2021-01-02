using System;

namespace _01._Person
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Person person = new Person(name, age);
            Console.WriteLine(person);
        }
    }
}
