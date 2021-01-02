using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int presents = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            string[,] neighbourHood = new string[size, size];
            bool hasBeen = false;
            int niceKids = 0;
            int[] santa = new int[2];
            for(int i = 0; i < size; i++)
            {
                string[] temp = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for(int j = 0; j < temp.Length; j++)
                {
                    neighbourHood[i, j] = temp[j];
                    if(temp[j] == "S")
                    {
                        santa[0] = i;
                        santa[1] = j;
                        neighbourHood[i, j] = "S";
                    }
                    else if(temp[j] == "V")
                    {
                        niceKids++;
                    }
                }
            }
            int totalNiceKids = niceKids;
            string command = Console.ReadLine();
            while(!command.Equals("Christmas morning"))
            {
                if(command == "up" && santa[0] - 1 >= 0)
                {
                    MoveUp(ref neighbourHood, ref santa, ref presents, ref niceKids);
                }
                else if(command == "right" && santa[1] + 1 < neighbourHood.GetLength(1))
                {
                    MoveRight(ref neighbourHood, ref santa, ref presents, ref niceKids);
                }
                else if(command == "left" && santa[1] - 1 >= 0)
                {
                    MoveLeft(ref neighbourHood, ref santa, ref presents, ref niceKids);
                }
                else if(command == "down" && santa[0] + 1 < neighbourHood.GetLength(0))
                {
                    MoveDown(ref neighbourHood, ref santa, ref presents, ref niceKids);
                }
                if(presents <= 0)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            if(presents == 0)
            {
                Console.WriteLine($"Santa ran out of presents!");
            }

            for(int i = 0; i < neighbourHood.GetLength(0); i++)
            {
                string[] temp = new string[neighbourHood.GetLength(1)];
                for(int j = 0; j < temp.Length; j++)
                {
                    temp[j] = neighbourHood[i, j];
                }
                Console.WriteLine(string.Join(" ", temp));
            }
            if(niceKids == 0)
            {
                Console.WriteLine($"Good job, Santa! {totalNiceKids} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {niceKids} nice kid/s.");
            }
        }

        public static void MoveUp(ref string[,] neighbourHood, ref int[] santa, ref int presents, ref int niceKids)
        {
 
            int position = santa[0] - 1;
            if (neighbourHood[position, santa[1]] == "V" || neighbourHood[position, santa[1]] == "X" || neighbourHood[position, santa[1]] == "-")
            {

                santa[0] = position;
                if (neighbourHood[position, santa[1]] == "V")
                {
                    presents--;
                    niceKids--;
                }
                neighbourHood[santa[0], santa[1]] = "S";
                neighbourHood[santa[0] + 1, santa[1]] = "-";



            }
            else if (neighbourHood[position, santa[1]] == "C")
            {
                santa[0] = position;
                neighbourHood[santa[0], santa[1]] = "S";
                neighbourHood[santa[0] + 1, santa[1]] = "-";
                for (int i = santa[0] - 1; i <= santa[0] + 1; i++)
                {
                    if (i == santa[0])
                    {
                        for (int j = santa[1] - 1; j <= santa[1] + 1; j++)
                        {
                            if (neighbourHood[i, j] == "X" || neighbourHood[i, j] == "V")
                            {
                                presents--;

                                if (neighbourHood[i, j] == "V")
                                {
                                    niceKids--;
                                }
                                neighbourHood[i, j] = "-";
                            }
                        }
                    }
                    else
                    {
                        if (neighbourHood[i, santa[1]] == "X" || neighbourHood[i, santa[1]] == "V")
                        {
                            presents--;

                            if (neighbourHood[i, santa[1]] == "V")
                            {
                                niceKids--;
                            }
                            neighbourHood[i, santa[1]] = "-";
                        }
                    }
                }
            }
        }

        public static void MoveDown(ref string[,] neighbourHood, ref int[] santa, ref int presents, ref int niceKids)
        {

            int position = santa[0] + 1;
            if (neighbourHood[position, santa[1]] == "V" || neighbourHood[position, santa[1]] == "X" || neighbourHood[position, santa[1]] == "-")
            {

                santa[0] = position;
                if (neighbourHood[position, santa[1]] == "V")
                {
                    presents--;
                    niceKids--;
                }
                neighbourHood[santa[0], santa[1]] = "S";
                neighbourHood[santa[0] - 1, santa[1]] = "-";



            }
            else if (neighbourHood[position, santa[1]] == "C")
            {
                santa[0] = position;
                neighbourHood[santa[0], santa[1]] = "S";
                neighbourHood[santa[0] - 1, santa[1]] = "-";
                for (int i = santa[0] - 1; i <= santa[0] + 1; i++)
                {
                    if (i == santa[0])
                    {
                        for (int j = santa[1] - 1; j <= santa[1] + 1; j++)
                        {
                            if (neighbourHood[i, j] == "X" || neighbourHood[i, j] == "V")
                            {
                                presents--;

                                if (neighbourHood[i, j] == "V")
                                {
                                    niceKids--;
                                }
                                neighbourHood[i, j] = "-";
                            }
                        }
                    }
                    else
                    {
                        if (neighbourHood[i, santa[1]] == "X" || neighbourHood[i, santa[1]] == "V")
                        {
                            presents--;

                            if (neighbourHood[i, santa[1]] == "V")
                            {
                                niceKids--;
                            }
                            neighbourHood[i, santa[1]] = "-";
                        }
                    }
                }
            }
        }

        public static void MoveLeft(ref string[,] neighbourHood, ref int[] santa, ref int presents, ref int niceKids)
        {

            int position = santa[1] - 1;
            if (neighbourHood[santa[0], position] == "V" || neighbourHood[santa[0], position] == "X" || neighbourHood[santa[0], position] == "-")
            {

                santa[1] = position;
                if (neighbourHood[santa[0], position] == "V")
                {
                    presents--;
                    niceKids--;
                }
                neighbourHood[santa[0], santa[1]] = "S";
                neighbourHood[santa[0], santa[1] + 1] = "-";



            }
            else if (neighbourHood[santa[0], position] == "C")
            {
                santa[1] = position;
                neighbourHood[santa[0], santa[1]] = "S";
                neighbourHood[santa[0], santa[1] + 1] = "-";
                for (int i = santa[0] - 1; i <= santa[0] + 1; i++)
                {
                    if (i == santa[0])
                    {
                        for (int j = santa[1] - 1; j <= santa[1] + 1; j++)
                        {
                            if (neighbourHood[i, j] == "X" || neighbourHood[i, j] == "V")
                            {
                                presents--;

                                if (neighbourHood[i, j] == "V")
                                {
                                    niceKids--;
                                }
                                neighbourHood[i, j] = "-";
                            }
                        }
                    }
                    else
                    {
                        if (neighbourHood[i, santa[1]] == "X" || neighbourHood[i, santa[1]] == "V")
                        {
                            presents--;

                            if (neighbourHood[i, santa[1]] == "V")
                            {
                                niceKids--;
                            }
                            neighbourHood[i, santa[1]] = "-";
                        }
                    }
                }
            }
        }

        public static void MoveRight(ref string[,] neighbourHood, ref int[] santa, ref int presents, ref int niceKids)
        {
            int position = santa[1] + 1;
            if (neighbourHood[santa[0], position] == "V" || neighbourHood[santa[0], position] == "X" || neighbourHood[santa[0], position] == "-")
            {

                santa[1] = position;
                if (neighbourHood[santa[0], position] == "V")
                {
                    presents--;
                    niceKids--;
                }
                neighbourHood[santa[0], santa[1]] = "S";
                neighbourHood[santa[0], santa[1] - 1] = "-";



            }
            else if (neighbourHood[santa[0], position] == "C")
            {
                santa[1] = position;
                neighbourHood[santa[0], santa[1]] = "S";
                neighbourHood[santa[0], santa[1] - 1] = "-";
                for (int i = santa[0] - 1; i <= santa[0] + 1; i++)
                {
                    if (i == santa[0])
                    {
                        for (int j = santa[1] - 1; j <= santa[1] + 1; j++)
                        {
                            if (neighbourHood[i, j] == "X" || neighbourHood[i, j] == "V")
                            {
                                presents--;

                                if (neighbourHood[i, j] == "V")
                                {
                                    niceKids--;
                                }
                                neighbourHood[i, j] = "-";
                            }
                        }
                    }
                    else
                    {
                        if (neighbourHood[i, santa[1]] == "X" || neighbourHood[i, santa[1]] == "V")
                        {
                            presents--;

                            if (neighbourHood[i, santa[1]] == "V")
                            {
                                niceKids--;
                            }
                            neighbourHood[i, santa[1]] = "-";
                        }
                    }
                }
            }
        }
    }
}
