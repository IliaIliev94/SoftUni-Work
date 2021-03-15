using _01._Select_Songs_With_Most_Artists.Models;
using System;
using System.Linq;
using System.Text;

namespace _03._Get_Min_and_Max_Artist_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var dbContext = new MusicXContext();
            var artists = dbContext.Artists.
                            GroupBy(a => a.Name.Substring(0, 1))
                            .Select(a => new
                            {
                                Artist = a.Key,
                                Min = a.Min(x => x.Name),
                                Max = a.Max(x => x.Name)
                            })
                            .OrderBy(a => a.Artist)
                            .ToList();

            foreach(var artist in artists)
            {
                Console.WriteLine(artist);
            }

        }
    }
}
