using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string command = Console.ReadLine();
            int carsPassed = 0;
            bool isBreak = false;
            while(!command.Equals("END"))
            {
                if(command.Equals("green"))
                {
                    int greentime = greenLightDuration;
                    while(cars.Count > 0 && greentime >= cars.Peek().Length)
                    {
                        greentime -= cars.Dequeue().Length;
                        carsPassed++;
                    }
                    if(greentime > 0 && cars.Count > 0)
                    {
                        if(greentime + freeWindowDuration >= cars.Peek().Length)
                        {
                            cars.Dequeue();
                            carsPassed++;
                        }
                        else
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{cars.Peek()} was hit at {cars.Peek()[greentime + freeWindowDuration]}.");
                            isBreak = true;
                            break;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            if(!isBreak)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
            }
        }
    }
}
