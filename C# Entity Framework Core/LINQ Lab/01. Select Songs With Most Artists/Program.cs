using _01._Select_Songs_With_Most_Artists.Models;
using System;
using System.Linq;

namespace _01._Select_Songs_With_Most_Artists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ok");
            var dbContext = new MusicXContext();
            var songs = dbContext.Songs
                .Select(s => new { s.Name, SongArtists = s.SongArtists.Select(sg => new {SongArtist = sg, sg.Artist})})
                .OrderByDescending(s => s.SongArtists.Count())
                .Take(10)
                .ToList();

            foreach(var song in songs)
            {
                Console.WriteLine($"{string.Join(" ", song.SongArtists.Select(sg => sg.Artist.Name).ToList())} - {song.Name}");
            }
        }
    }
}
