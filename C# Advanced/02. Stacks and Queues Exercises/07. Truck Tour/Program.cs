using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> stations = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
                stations.Enqueue(data[0] - data[1]);
            }
            
            int position = 0;
            for(int i = 0; i < n; i++)
            {
                bool isTrue = true;
                int[] temp = stations.ToArray();
                int sum = 0;
                for(int j = 0; j < temp.Length && isTrue == true; j++)
                {
                    sum += temp[j];
                    if(sum < 0)
                    {
                        isTrue = false;
                    }
                }
                if(isTrue == true)
                {
                    position = i;
                    break;
                }
                else
                {
                    stations.Enqueue(stations.Dequeue());
                }
            }
            Console.WriteLine(position);
        }
    }
}
