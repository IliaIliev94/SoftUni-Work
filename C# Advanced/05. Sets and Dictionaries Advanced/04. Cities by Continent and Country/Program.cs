using System;
using System.Collections.Generic;


namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> countries = new Dictionary<string, Dictionary<string, List<string>>>();

            for(int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string continent = data[0];
                string country = data[1];
                string city = data[2];

                if(countries.ContainsKey(continent))
                {
                    if(countries[continent].ContainsKey(country))
                    {
                        countries[continent][country].Add(city);
                    }
                    else
                    {
                        Dictionary<string, List<string>> temp = new Dictionary<string, List<string>>();
                        countries[continent].Add(country, new List<string> { city });
                    }
                }
                else
                {
                    Dictionary<string, List<string>> temp = new Dictionary<string, List<string>>();
                    temp.Add(country, new List<string> { city });
                    countries.Add(continent, temp);
                }
            }
            foreach(var item in countries)
            {
                Console.WriteLine($"{item.Key}:");

                foreach(var country in item.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
