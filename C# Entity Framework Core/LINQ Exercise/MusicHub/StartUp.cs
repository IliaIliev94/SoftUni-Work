namespace MusicHub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using MusicHub.Data.Models;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            MusicHubDbContext context = 
                new MusicHubDbContext();

            DbInitializer.ResetDatabase(context);

            Console.WriteLine(ExportSongsAboveDuration(context, 4));

        }

        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            var result = new StringBuilder();

            var albums = context.Producers
                .FirstOrDefault(p => p.Id == producerId)
                .Albums
                .Select(a => new
                {
                    a.Name,
                    a.ReleaseDate,
                    ProducerName = a.Producer.Name,
                    Songs = a.Songs
                        .Select(s => new
                        {
                            s.Name,
                            s.Price,
                            WriterName = s.Writer.Name
                        })
                        .OrderByDescending(s => s.Name)
                        .ThenBy(s => s.WriterName)
                        .ToList(),
                        AlbumPrice = a.Price
                })
                .OrderByDescending(a => a.AlbumPrice)
                .ToList();

            foreach (var album in albums)
            {
                var albumInformationToPrint = new Dictionary<string, string>()
                {
                    {"-AlbumName:", album.Name},
                    {"-ReleaseDate:", album.ReleaseDate.ToString("MM/dd/yyyy")},
                    {"-ProducerName:",  album.ProducerName}
                };

                AppendValues(result, albumInformationToPrint);
                result.AppendLine($"-Songs:");

                int counter = 1;
                foreach (var song in album.Songs)
                {
                    var songInformationToPrint = new Dictionary<string, string>()
                    {
                        {"---SongName:", song.Name },
                        {"---Price:", song.Price.ToString("0.00")},
                        {"---Writer:",  song.WriterName}
                    };

                    result.AppendLine($"---#{counter}");
                    AppendValues(result, songInformationToPrint);

                    counter++;
                }
                result.AppendLine($"-AlbumPrice: {album.AlbumPrice.ToString("0.00")}");
            }
            return result.ToString().TrimEnd();
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            var result = new StringBuilder();

            var songs = context.Songs
                .Select(s => new
                {
                    s.Name,
                    Performer = s.SongPerformers.Select(x => x.Performer.FirstName + " " + x.Performer.LastName).FirstOrDefault(),
                    WriterName = s.Writer.Name,
                    ProducerName = s.Album.Producer.Name,
                    Duration = s.Duration
                })
                .OrderBy(s => s.Name)
                .ThenBy(s => s.WriterName)
                .ThenBy(s => s.Performer)
                .ToList()
                .Where(song => int.Parse(song.Duration.TotalSeconds.ToString()) > duration)
                .ToList();

            int counter = 1;

            foreach(var song in songs)
            {
                var songValues = new Dictionary<string, string>()
                    {
                        {"---SongName:", song.Name },
                        {"---Writer:",  song.WriterName},
                        {"---Performer:", song.Performer},
                        {"---AlbumProducer:", song.ProducerName},
                        {"---Duration:", song.Duration.ToString("c")}
                    };

                result.AppendLine($"-Song #{counter}");
                AppendValues(result, songValues);
                counter++;
            }

            return result.ToString().Trim();
        }

        private static void AppendValues(StringBuilder stringBuilder, Dictionary<string, string> values)
        {
            foreach(var value in values)
            {
                stringBuilder.AppendLine($"{value.Key} {value.Value}");
            }
        }

        private static string ReturnPerformerName(Performer performer)
        {
            if(performer == null)
            {
                return "";
            }
            return performer.FirstName + " " + performer.LastName;
        }
    }
}
