using System;
using System.Linq;
using System.Collections.Generic;


namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distancesToPokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            while(distancesToPokemons.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    index = 0;
                    int element = distancesToPokemons[index];
                    sum += element;
                    distancesToPokemons.RemoveAt(index);
                    if (distancesToPokemons.Count > 0)
                    {
                        distancesToPokemons.Insert(index, distancesToPokemons[distancesToPokemons.Count - 1]);
                    }

                    for (int i = 0; i < distancesToPokemons.Count; i++)
                    {
                        if (distancesToPokemons[i] <= element)
                        {
                            distancesToPokemons[i] += element;
                        }
                        else
                        {
                            distancesToPokemons[i] -= element;
                        }
                    }
                }
                else if (index > distancesToPokemons.Count - 1)
                {
                    index = distancesToPokemons.Count - 1;
                    int element = distancesToPokemons[index];
                    sum += element;
                    distancesToPokemons.RemoveAt(index);
                    if (distancesToPokemons.Count > 0)
                    {
                        distancesToPokemons.Insert(index, distancesToPokemons[0]);
                    }
                    
                    
                    for (int i = 0; i < distancesToPokemons.Count; i++)
                    {
                        if (distancesToPokemons[i] <= element)
                        {
                            distancesToPokemons[i] += element;
                        }
                        else
                        {
                            distancesToPokemons[i] -= element;
                        }
                    }
                }
                else
                {
                    int element = distancesToPokemons[index];
                    sum += element;
                    distancesToPokemons.RemoveAt(index);
                    for (int i = 0; i < distancesToPokemons.Count; i++)
                    {
                        if (distancesToPokemons[i] <= element)
                        {
                            distancesToPokemons[i] += element;
                        }
                        else
                        {
                            distancesToPokemons[i] -= element;
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
