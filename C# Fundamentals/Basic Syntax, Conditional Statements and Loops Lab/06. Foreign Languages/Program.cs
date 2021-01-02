using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string language;

            if (country.Equals("USA") || country.Equals("England"))
            {
                language = "English";
            }

            else if (country.Equals("Spain") || country.Equals("Argentina") || country.Equals("Mexico"))
            {
                language = "Spanish";
            }

            else
            {
                language = "unknown";
            }

            Console.WriteLine(language);
        }
    }
}
