using System;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double total = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string text = input[i];
                int number = int.Parse(text.Substring(1, text.Length - 2));
                double sum = 0;
                text = text.Remove(1, text.Length - 2);
                for (int j = 0; j < text.Length; j++)
                {
                    if(char.IsUpper(text[j]))
                    {
                        if (j == 0)
                        {
                            sum = number * 1.0 / ((int)char.ToLower(text[j]) - 96);
                        }
                        else
                        {
                            sum -= ((int)char.ToLower(text[j]) - 96);
                        }
                    }
                    else
                    {
                        if (j == 0)
                        {
                            sum = number * 1.0 * ((int)char.ToLower(text[j]) - 96);
                        }
                        else
                        {
                            sum += ((int)char.ToLower(text[j]) - 96);
                        }
                    }  
                }
                total += sum;
            }
            Console.WriteLine(total.ToString("0.00"));
        }
    }
}
