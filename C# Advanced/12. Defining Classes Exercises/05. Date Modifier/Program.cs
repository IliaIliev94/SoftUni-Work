using System;

namespace _05._Date_Modifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            double difference = DateModifier.Difference(date1, date2);

            Console.WriteLine(difference);
        }
    }
}
