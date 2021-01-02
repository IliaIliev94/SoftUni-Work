using System;

namespace Basic_Syntax__Conditional_Statements_and_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade.ToString("0.00")}");
        }
    }
}
