using System;


namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string input;
            long num1;
            long num2;
            long sum = 0;
            for (int i = 0; i < num; i++)
            {
                input = Console.ReadLine();
                num1 = long.Parse(input.Substring(0, input.IndexOf(" ")));
                num2 = long.Parse(input.Substring(input.IndexOf(" ") + 1, (input.Length - (input.IndexOf(" ") + 1))));
                
                if (num1 > num2)
                {
                    for (long j = num1; j != 0; j /= 10)
                    {
                        if (num1 > 0)
                        {
                            sum += j % 10;
                        }
                        else
                        {
                            sum -= j % 10;
                        }
                    }
                }
                else
                {
                    for (long k = num2; k != 0; k /=10)
                    {
                        if (num2 > 0)
                        {
                            sum += k % 10;
                        }
                        else
                        {
                            sum -= k % 10;
                        }
                        
                    }
                }
                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }
}
