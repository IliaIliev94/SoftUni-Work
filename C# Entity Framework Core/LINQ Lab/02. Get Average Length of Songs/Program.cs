using _01._Select_Songs_With_Most_Artists.Models;
using System;
using System.Linq;

namespace _02._Get_Average_Length_of_Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new MusicXContext();
            var artists = dbContext.Artists
                .Select(a => new 
                { 
                    Artist = a.Name, 
                    Average = Math.Round(a.SongArtists
                        .Select(s => s.Song.Name.Length).Average()) 
                })
                .ToList();

            foreach(var artist in artists)
            {
                Console.WriteLine($"{artist.Artist} - {artist.Average}");
            }
        }
    }
}
