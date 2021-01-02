using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            while(!command.Equals("end"))
            {
                string[] function = command.Split();
                if (function[0].Equals("exchange"))
                {
                    int index = int.Parse(function[1]);
                    if (index > input.Length - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        input = exchange(input, index);
                    }
                }
                else if (function[0].Equals("max"))
                {
                    if (function[1].Equals("odd"))
                    {
                        int index = maxOdd(input);
                        if (index == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                    }
                    else if (function[1].Equals("even"))
                    {
                        int index = maxEven(input);
                        if (index == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                    }
                }
                else if (function[0].Equals("min"))
                {
                    if (function[1].Equals("odd"))
                    {
                        int index = minOdd(input);
                        if (index == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                    }
                    else if (function[1].Equals("even"))
                    {
                        int index = minEven(input);
                        if (index == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                    }
                }
                else if (function[0].Equals("first"))
                {
                    if (function[2].Equals("odd"))
                    {
                        int index = int.Parse(function[1]);
                        if (index > input.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            Console.WriteLine($"[{string.Join(", ", firstOdd(input, index))}]");
                        }
                    }
                    else if (function[2].Equals("even"))
                    {
                        int index = int.Parse(function[1]);
                        if (index > input.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            Console.WriteLine($"[{string.Join(", ", firstEven(input, index))}]");
                        }
                    }
                }
                else if (function[0].Equals("last"))
                {
                    if (function[2].Equals("odd"))
                    {
                        int index = int.Parse(function[1]);
                        if (index > input.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            Console.WriteLine($"[{string.Join(", ", lastOdd(input, index))}]");
                        }
                    }
                    else if (function[2].Equals("even"))
                    {
                        int index = int.Parse(function[1]);
                        if (index > input.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            Console.WriteLine($"[{string.Join(", ", lastEven(input, index))}]");
                        }
                    }
                }
                command = Console.ReadLine();
            }


            Console.WriteLine($"[{string.Join(", ", input)}]");

        }
        static int[] exchange(int[] input, int index)
        {
            int[] newArray = new int[input.Length];
            int counter = 0;
            for (int i = index + 1; i < input.Length; i++)
            {
                newArray[counter] = input[i];
                counter++;
            }
            for (int i = 0; i <= index; i++)
            {
                newArray[counter] = input[i];
                counter++;
            }
            return newArray;
        }

        static int maxOdd(int[] input)
        {
            int maximumOdd = -1;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 != 0 && maximumOdd == -1)
                {
                    maximumOdd = i;
                }
                else if (input[i] % 2 != 0 && input[i] >= input[maximumOdd])
                {
                    maximumOdd = i;
                }
            }
            return maximumOdd;
        }
        static int maxEven(int[] input)
        {
            int maxEven = -1;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0 && maxEven == -1)
                {
                    maxEven = i;
                }
                else if (input[i] % 2 == 0 && input[i] >= input[maxEven])
                {
                    maxEven = i;
                }
            }
            return maxEven;
        }
        static int minOdd(int[] input)
        {
            int minOdd = -1;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 != 0 && minOdd == -1)
                {
                    minOdd = i;
                }
                else if (input[i] % 2 != 0 && input[i] <= input[minOdd])
                {
                    minOdd = i;
                }
            }
            return minOdd;
        }
        static int minEven(int[] input)
        {
            int minEven = -1;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0 && minEven == -1)
                {
                    minEven = i;
                }
                else if (input[i] % 2 == 0 && input[i] <= input[minEven])
                {
                    minEven = i;
                }
            }
            return minEven;
        }
        static int[] firstEven(int[] input, int count)
        {
            int[] newArray = new int[0];
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (counter < count && input[i] % 2 == 0)
                {
                    if (counter != 0)
                    {
                        int[] temp = newArray;
                        newArray = new int[counter + 1];
                        for (int j = 0; j < temp.Length; j++)
                        {
                            newArray[j] = temp[j];
                        }
                        newArray[newArray.Length - 1] = input[i];
                    }
                    else
                    {
                        newArray = new int[1];
                        newArray[0] = input[i];
                    }
                    counter++;
                }
            }
            return newArray;
        }
        static int[] firstOdd(int[] input, int count)
        {
            int[] newArray = new int[0];
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (counter < count && input[i] % 2 != 0)
                {
                    if (counter != 0)
                    {
                        int[] temp = newArray;
                        newArray = new int[counter + 1];
                        for (int j = 0; j < temp.Length; j++)
                        {
                            newArray[j] = temp[j];
                        }
                        newArray[newArray.Length - 1] = input[i];
                    }
                    else
                    {
                        newArray = new int[1];
                        newArray[0] = input[i];
                    }
                    counter++;
                }
            }
            return newArray;
        }
        static int[] lastEven(int[] input, int count)
        {
            int[] newArray = new int[0];
            int counter = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (counter < count && input[i] % 2 == 0)
                {
                    if (counter != input.Length)
                    {
                        int[] temp = newArray;
                        newArray = new int[temp.Length + 1];
                        for (int j = temp.Length - 1; j >= 0; j--)
                        {
                            newArray[j + 1] = temp[j];
                        }
                        newArray[0] = input[i];
                    }
                    else
                    {
                        newArray = new int[1];
                        newArray[0] = input[i];
                    }
                    counter++;
                }
            }
            return newArray;
        }
        static int[] lastOdd(int[] input, int count)
        {
            int[] newArray = new int[0];
            int counter = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (counter < count && input[i] % 2 != 0)
                {
                    if (counter != 0)
                    {
                        int[] temp = newArray;
                        newArray = new int[temp.Length + 1];
                        for (int j = temp.Length - 1; j >= 0; j--)
                        {
                            newArray[j + 1] = temp[j];
                        }
                        newArray[0] = input[i];
                    }
                    else
                    {
                        newArray = new int[1];
                        newArray[0] = input[i];
                    }
                    counter++;
                }
            }
            return newArray;
        }
    }
}
