using System;
using System.Text;
namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());
            int remainder = 0;
            StringBuilder result = new StringBuilder();
            if (num2 == 0)
            {
                result.Append("0");
            }
            else
            {
                for (int i = num1.Length - 1; i >= 0; i--)
                {
                    int value = (int)char.GetNumericValue(num1[i]) * num2;
                    value += remainder;
                    remainder = 0;
                    if (value > 9)
                    {
                        result.Insert(0, value % 10);
                        remainder = value / 10;
                    }
                    else
                    {
                        result.Insert(0, value);
                    }
                    if (i == 0 && remainder > 0)
                    {
                        result.Insert(0, remainder);
                    }
                }
            }
            if (result.Length > 1 && result[0] == '0')
            {
                while(result[0] == '0')
                {

                    result.Remove(0, 1);

                }
            }
            
            Console.WriteLine(result);
        }
    }
}
