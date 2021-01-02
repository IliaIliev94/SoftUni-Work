using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Ivan", 20);
            Person person2 = new Person();
            person2.Name = "Gosho";
            person2.Age = 25;
        }


    }
}
