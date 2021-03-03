using _01._Get_Songs_and_Artists.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Get_Songs_and_Artists
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new MusicXContext();

            Console.WriteLine(dbContext.Songs.Count());
            Console.WriteLine(dbContext.Artists.Count());

            var songsOfEminem = dbContext.Songs.Where(song => song.SongArtists.Any(sg => sg.Artist.Name == "Eminem"))
                .Select(s => new {Name = s.Name, Artists = string.Join(", ", s.SongArtists.Select(sg => sg.Artist.Name))});

            foreach(var song in songsOfEminem)
            {
                Console.WriteLine($"{song.Artists} - {song.Name}");
            }

        }
    }
}
 