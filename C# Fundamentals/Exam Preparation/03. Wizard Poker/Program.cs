using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Wizard_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(':').ToList();
            List<string> newDeck = new List<string>();
            string command = Console.ReadLine();

            while(!command.Equals("Ready"))
            {
                string[] commands = command.Split();
                
                if (commands[0].Equals("Add"))
                {
                    if (!input.Contains(commands[1]))
                    {
                        Console.WriteLine("Card not found.");
                    }
                    else
                    {
                        newDeck.Add(commands[1]);
                    }
                }
                else if (commands[0].Equals("Insert"))
                {
                    int index = int.Parse(commands[2]);
                    if (!input.Contains(commands[1]) || (index < 0 || index > newDeck.Count - 1))
                    {
                        Console.WriteLine("Error!");
                    }
                    else
                    {
                        newDeck.Insert(index, commands[1]);
                    }
                }
                else if (commands[0].Equals("Remove"))
                {
                    if  (!newDeck.Contains(commands[1]))
                    {
                        Console.WriteLine("Card not found.");
                    }
                    else
                    {
                        newDeck.Remove(commands[1]);
                    }
                }
                else if (commands[0].Equals("Swap"))
                {
                    string card1 = commands[1];
                    string card2 = commands[2];

                    int index1 = newDeck.FindIndex(x => x == card1);
                    int index2 = newDeck.FindIndex(x => x == card2);

                    string temp = newDeck[index2];
                    newDeck[index2] = newDeck[index1];
                    newDeck[index1] = temp;
                }
                else
                {
                    newDeck.Reverse();
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", newDeck));
        }
    }
}
