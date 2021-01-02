using System;
using System.Collections.Generic;

namespace _05._Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peopleData = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            string[] productsData = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            for (int i = 0; i < peopleData.Length; i++)
            {
                string[] personData = peopleData[i].Split('=');
                string Name = personData[0];
                int Money = int.Parse(personData[1]);
                people.Add(new Person(Name, Money));
            }

            for (int i = 0; i < productsData.Length; i++)
            {
                string[] productData = productsData[i].Split('=');
                string Name = productData[0];
                int Cost = int.Parse(productData[1]);
                products.Add(new Product(Name, Cost));
            }

            string command = Console.ReadLine();
            while(!command.Equals("END"))
            {
                string[] buyData = command.Split();
                string person = buyData[0];
                string product = buyData[1];
                int personIndex = people.FindIndex(x => x.Name == person);
                int productIndex = products.FindIndex(x => x.Name == product);
                people[personIndex].AddProduct(products[productIndex]);
                command = Console.ReadLine();
            }

            foreach(var person in people)
            {
                person.Print();
            }
        }
    }

}
