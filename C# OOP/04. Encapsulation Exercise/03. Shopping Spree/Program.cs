using System;
using System.Collections.Generic;

namespace _03._Shopping_Spree
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            string[] personData = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach(var person in personData)
            {
                string[] data = person.Split("=");
                string name = data[0];
                double money = double.Parse(data[1]);
                try
                {
                    people.Add(new Person(name, money));
                }
                catch(Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                    return;
                }
            }

            string[] productData = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach(var product in productData)
            {
                string[] data = product.Split("=");
                string name = data[0];
                double price = double.Parse(data[1]);
                try
                {
                    products.Add(new Product(name, price));
                }
                catch(Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                    return;
                }
            }

            string command = Console.ReadLine();

            while(!command.Equals("END"))
            {
                string[] data = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string person = data[0];
                string product = data[1];
                int personIndex = people.FindIndex(x => x.Name == person);
                int productIndex = products.FindIndex(x => x.Name == product);
                people[personIndex].Add(products[productIndex]);
                command = Console.ReadLine();
            }

            foreach(var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
