using System;

namespace _01._Experience_Gaining
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededExperience = double.Parse(Console.ReadLine());
            int battlesCount = int.Parse(Console.ReadLine());
            double sum = 0.0;
            int count = 0;
            for (int i = 1; i <= battlesCount; i++)
            {
                double exp = double.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    sum += exp * 1.15;
                }
                else if (i % 5 == 0)
                {
                    sum += exp * 0.9;
                }
                else
                {
                    sum += exp;
                }
                count++;
                if (sum >= neededExperience)
                {
                    break;
                }
                
            }
            if (sum >= neededExperience)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {count} battles.");
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {(neededExperience - sum).ToString("0.00")} more needed.");
            }
        }
    }
}
