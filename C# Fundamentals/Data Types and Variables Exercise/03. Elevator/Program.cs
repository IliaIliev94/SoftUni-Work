using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int courses = 0;
            for (int i = people; i >= elevatorCapacity; i -= elevatorCapacity)
            {
                courses++;
            }
            int additional = (int) Math.Ceiling((people - courses * elevatorCapacity) * 1.0 / elevatorCapacity);
            courses += additional;

            Console.WriteLine(courses);
        }
    }
}
