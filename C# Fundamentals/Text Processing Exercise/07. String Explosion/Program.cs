using System;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int strength = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == '>')
                {
                    strength += (int)char.GetNumericValue(input[i + 1]);
                    int index = i + 1;
                    for (int j = 0; strength > 0 && index < input.Length; j++)
                    {
                        if (input[index] != '>')
                        {
                            input = input.Remove(index, 1);
                            strength--;
                        }
                        else
                        {
                            strength += (int)char.GetNumericValue(input[index + 1]);
                            index++;
                        }
                    }
                    i = index - 1;
                }
            }
            Console.WriteLine(input);
        }
    }
}
