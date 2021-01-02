using System;

namespace _01._Ages
{
    class Ages
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string person;

            if (age >= 0 && age < 3)
            {
                person = "baby";
            }
            else if (age >= 3 && age < 14)
            {
                person = "child";
            }
            else if (age >= 14 && age < 20)
            {
                person = "teenager";
            }
            else if (age >= 20 && age < 66)
            {
                person = "adult";
            }
            else
            {
                person = "elder";
            }

            Console.WriteLine(person);
        }
    }
}
