using System;
using System.Collections.Generic;

namespace _05._Birthday_Celebrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<IBirthed> birthdates = new List<IBirthed>();
            while(!command.Equals("End"))
            {
                string[] data = command.Split();
                if(data[0].Equals("Citizen"))
                {
                    string name = data[1];
                    int age = int.Parse(data[2]);
                    string id = data[3];
                    string birthDate = data[4];
                    birthdates.Add(new Citizen(name, age, id, birthDate));
                }
                else if(data[0].Equals("Pet"))
                {
                    string name = data[1];
                    string birthDate = data[2];
                    birthdates.Add(new Pet(name, birthDate));
                }
                command = Console.ReadLine();
            }
            string year = Console.ReadLine();
            foreach(var citizen in birthdates)
            {
                if(citizen.EndsWith(year))
                {
                    Console.WriteLine(citizen.Birthdate);
                }
            }
        }
    }
}
