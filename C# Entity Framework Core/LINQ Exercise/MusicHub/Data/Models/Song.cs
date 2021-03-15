using MusicHub.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MusicHub.Data.Models
{
    public class Song
    {
        public Song()
        {
            SongPerformers = new HashSet<SongPerformer>();
        }
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [Column(TypeName="Date")]
        public DateTime CreatedOn { get; set; }

        [Required]
        public Genre Genre { get; set; }

        public int? AlbumId { get; set; }

        public Album Album { get; set; }

        public int WriterId { get; set; }

        public Writer Writer { get; set; }

        public decimal Price { get; set; }

        public ICollection<SongPerformer> SongPerformers { get; set; }
    }
}
