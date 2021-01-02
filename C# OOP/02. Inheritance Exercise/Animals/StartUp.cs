using System;
using System.Collections.Generic;
namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Animal> animals = new List<Animal>();
            while(!command.Equals("Beast!"))
            {
                if(command.Equals("Cat"))
                {
                    string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    try
                    {
                        animals.Add(new Cat(data[0], int.Parse(data[1]), data[2]));
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else if(command.Equals("Dog"))
                {
                    string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    try
                    {
                        animals.Add(new Dog(data[0], int.Parse(data[1]), data[2]));
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Invalid exception");
                    }
                }
                else if(command.Equals("Frog"))
                {
                    string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    try
                    {
                        animals.Add(new Frog(data[0], int.Parse(data[1]), data[2]));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else if(command.Equals("Kitten"))
                {
                    string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    try
                    {
                        animals.Add(new Kitten(data[0], int.Parse(data[1])));
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    try
                    {
                        animals.Add(new Tomcat(data[0], int.Parse(data[1])));
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                command = Console.ReadLine();
            }
            foreach(var item in animals)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.ProduceSound());
            }
        }
    }
}
