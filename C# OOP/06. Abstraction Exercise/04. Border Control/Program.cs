using System;
using System.Collections.Generic;

namespace _04._Border_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<ICitizen> citizens = new List<ICitizen>();
            while(!command.Equals("End"))
            {
                string[] data = command.Split();
                if(data.Length == 3)
                {
                    string name = data[0];
                    int age = int.Parse(data[1]);
                    string id = data[2];
                    citizens.Add(new Citizen(name, age, id));
                }
                else if(data.Length == 2)
                {
                    string model = data[0];
                    string id = data[1];
                    citizens.Add(new Robot(model, id));
                }
                command = Console.ReadLine();
            }
            string lastDigits = Console.ReadLine();
            foreach(var citizen in citizens)
            {
                if(citizen.EndsWith(lastDigits))
                {
                    Console.WriteLine(citizen.Id);
                }
            }
        }
    }
}
