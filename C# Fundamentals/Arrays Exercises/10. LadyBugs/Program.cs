using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] initialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] ladybugs = new int[fieldSize];
            for (int i = 0; i < initialIndexes.Length; i++)
            {
                if (initialIndexes[i] >= 0 && initialIndexes[i] < ladybugs.Length)
                {
                    ladybugs[initialIndexes[i]] = 1;
                }

            }
            string[] commands = new string[3];
            if (ladybugs.Length > 0)
            {
                for (string command = Console.ReadLine(); !command.Equals("end"); command = Console.ReadLine())
                {
                    commands = command.Split();
                    int startIndex = int.Parse(commands[0]);
                    int ladyBug = startIndex;
                    string direction = commands[1];
                    int flyLengthInitial = int.Parse(commands[2]);
                    int flyLength = flyLengthInitial;
                    if (flyLength < 0)
                    {
                        if (direction.Equals("right"))
                        {
                            direction = "left";
                        }
                        else
                        {
                            direction = "right";
                        }
                        flyLengthInitial = (int)Math.Abs(flyLength);
                        flyLength = flyLengthInitial;
                    }
                    if ((startIndex >= 0 && startIndex < ladybugs.Length) && direction.Equals("right") && ladybugs[startIndex] != 0)
                    {
                        while (flyLength != 0)
                        {
                            ladyBug += flyLength;
                            flyLength = 0;
                            if (ladyBug > ladybugs.Length - 1)
                            {
                                ladybugs[startIndex] = 0;
                                break;
                            }
                            else if (ladybugs[ladyBug] == 1)
                            {
                                flyLength = flyLengthInitial;
                            }
                            else if (flyLength == 0)
                            {
                                ladybugs[ladyBug] = ladybugs[startIndex];
                                ladybugs[startIndex] = 0;
                            }
                        }

                    }
                    else if ((startIndex >= 0 && startIndex < ladybugs.Length) && direction.Equals("left") && ladybugs[startIndex] != 0)
                    {
                        while (flyLength != 0)
                        {
                            ladyBug -= flyLength;
                            flyLength = 0;
                            if (ladyBug < 0)
                            {
                                ladybugs[startIndex] = 0;
                                break;
                            }
                            else if (ladybugs[ladyBug] == 1)
                            {
                                flyLength = flyLengthInitial;
                            }
                            else if (flyLength == 0)
                            {
                                ladybugs[ladyBug] = ladybugs[startIndex];
                                ladybugs[startIndex] = 0;
                            }
                        }

                    }
                }
            }
            Console.WriteLine(string.Join(" ", ladybugs));
        } 
    }
}
