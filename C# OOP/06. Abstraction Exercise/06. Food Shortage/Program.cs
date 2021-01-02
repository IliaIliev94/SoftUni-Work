using System;
using System.Collections.Generic;

namespace _06._Food_Shortage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBuyer> people = new List<IBuyer>();
            int numberOfPeople = int.Parse(Console.ReadLine());
            for(int i = 0; i < numberOfPeople; i++)
            {
                string[] data = Console.ReadLine().Split();
                if(data.Length == 4)
                {
                    string name = data[0];
                    int age = int.Parse(data[1]);
                    string id = data[2];
                    string birthdate = data[3];
                    people.Add(new Citizen(name, age, id, birthdate));
                }
                else
                {
                    string name = data[0];
                    int age = int.Parse(data[1]);
                    string group = data[2];
                    people.Add(new Rebel(name, age, group));
                }
            }

            string command = Console.ReadLine();
            while(!command.Equals("End"))
            {
                int index = people.FindIndex(x => x.Name == command);
                if(index != -1)
                {
                    people[index].BuyFood();
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(SumFood(people));
        }
        public static int SumFood(List<IBuyer> people)
        {
            int sum = 0;
            foreach(var person in people)
            {
                sum += person.Food;
            }
            return sum;
        }
    }
}
