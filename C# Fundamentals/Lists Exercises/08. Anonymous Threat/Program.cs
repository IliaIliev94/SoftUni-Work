using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();

            while(!command.Equals("3:1"))
            {
                string[] commands = command.Split();

                if (commands[0].Equals("merge"))
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;
                    }
                    string result = "";
                    if ((startIndex >= 0 && startIndex < input.Count) && (endIndex >= 0 && endIndex < input.Count))
                    {
                            for (int i = startIndex; i <= endIndex; i++)
                            {

                                result += input[startIndex];
                                input.RemoveAt(startIndex);

                            }
                        input.Insert(startIndex, result);
                    }
                    
                }
                else
                {
                    int index = int.Parse(commands[1]);
                    int length = int.Parse(commands[2]);

                    int partition = input[index].Length / length;
                    string[] newElements = new string[length];
                    if ((double)input[index].Length / length * 1.0 != (double)partition)
                    {
                        int remainder = input[index].Length - (partition + (input[index].Length % length));
                        for (int i = 0, j = 0; j < remainder; i++, j += partition)
                        {
                            string result = input[index].Substring(j, partition);
                            newElements[i] = result;
                        }
                        newElements[newElements.Length - 1] = input[index].Substring(remainder, partition + (input[index].Length % length));
                    }
                    else
                    {
                        for (int i = 0, j = 0; j < input[index].Length; i++, j += partition)
                        {
                            string result = input[index].Substring(j, partition);
                            newElements[i] = result;
                        }
                    }
                    input.RemoveAt(index);
                    for (int i = newElements.Length - 1; i >= 0; i--)
                    {
                        input.Insert(index, newElements[i]);
                    }

                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
