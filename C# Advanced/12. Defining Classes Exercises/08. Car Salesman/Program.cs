using System;
using System.Collections.Generic;

namespace _08._Car_Salesman
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = data[0];
                int power = int.Parse(data[1]);
                int displacement = 0;
                string efficiency = null;
                if (data.Length >= 3)
                {
                    if (data.Length >= 4)
                    {
                        displacement = int.Parse(data[2]);
                        efficiency = data[3];
                    }
                    else
                    {
                        if (char.IsDigit(data[2][0]))
                        {
                            displacement = int.Parse(data[2]);
                        }
                        else
                        {
                            efficiency = data[2];
                        }
                    }
                }
                engines.Add(model, new Engine(model, power, displacement, efficiency));
            }

            n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = data[0];
                string engine = data[1];
                int weight = 0;
                string color = null;
                if (data.Length >= 3)
                {
                    if (data.Length >= 4)
                    {
                        weight = int.Parse(data[2]);
                        color = data[3];
                    }
                    else
                    {
                        if (char.IsDigit(data[2][0]))
                        {
                            weight = int.Parse(data[2]);
                        }
                        else
                        {
                            color = data[2];
                        }
                    }

                }
                cars.Add(new Car(model, engines[engine], weight, color));
            }
            foreach(var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
