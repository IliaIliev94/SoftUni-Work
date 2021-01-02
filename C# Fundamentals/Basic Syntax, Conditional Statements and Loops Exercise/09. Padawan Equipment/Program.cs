using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double sum = Math.Ceiling(students * 0.10 + students) * lightsaberPrice + robePrice * students + beltPrice * (students - Math.Floor(students / 6.0));

            if (money >= sum)
            {
                Console.WriteLine($"The money is enough - it would cost {sum.ToString("0.00")}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(sum - money).ToString("0.00")}lv more.");
            }
        }
    }
}
