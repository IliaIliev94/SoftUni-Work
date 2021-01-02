using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string dates = Console.ReadLine();
            string pattern = @"\b(?<day>\d{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})(\1)(?<year>\d{4})\b";
            MatchCollection matches = Regex.Matches(dates, pattern);
            foreach(Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}" +
                    $", Year: {match.Groups["year"]}");
            }
        }
    }
}
