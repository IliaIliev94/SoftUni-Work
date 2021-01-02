using System;

namespace _02._Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            string command = Console.ReadLine();

            while(!command.Equals("Done"))
            {
                string[] commands = command.Split();
                if (commands[0].Equals("Move"))
                {
                    if (commands[1].Equals("Right"))
                    {
                        int index = int.Parse(commands[2]);
                        if ((index >= 0 && index < input.Length) && index + 1 < input.Length)
                        {
                            string temp = input[index + 1];
                            input[index + 1] = input[index];
                            input[index] = temp;
                        }
                    }
                    else
                    {
                        int index = int.Parse(commands[2]);
                        if ((index >= 0 && index < input.Length) && index - 1 >= 0)
                        {
                            string temp = input[index - 1];
                            input[index - 1] = input[index];
                            input[index] = temp;
                        }
                    }
                }
                else if (commands[0].Equals("Check"))
                {
                    if (commands[1].Equals("Even"))
                    {
                        bool isFirst = false;
                        for (int i = 0; i < input.Length; i++)
                        {
                            if (i % 2 == 0)
                            {
                                if (!isFirst)
                                {
                                    Console.Write(input[i]);
                                    isFirst = true;
                                }
                                else
                                {
                                    Console.Write($" {input[i]}");
                                }
                            }
                        }
                        
                    }
                    else
                    {
                        bool isFirst = false;
                        for (int i = 0; i < input.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                if (!isFirst)
                                {
                                    Console.Write(input[i]);
                                    isFirst = true;
                                }
                                else
                                {
                                    Console.Write($" {input[i]}");
                                }
                            }
                        }
                    }
                    Console.WriteLine();
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"You crafted {string.Join("", input)}!");
        }
    }
}
