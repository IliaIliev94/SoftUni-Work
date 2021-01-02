using System;

namespace Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            double days = Math.Floor(years * 365.2422);
            double hours = days * 24;
            double minutes = hours * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days.ToString("0")} days = {hours.ToString("0")} hours = {minutes.ToString("0")} minutes");
        }
    }
}
