using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melodia.Domain.Entities;

[Table("songs")]
public class Song
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = String.Empty;

    [Required]
    public int DurationInSeconds { get; set; }

    [Required]
    public string FileUrl { get; set; } = String.Empty;

    public int PlayCount { get; set; } = 0;

    [Required]
    [Column(TypeName = "timestamp")]
    public DateTime CreatedAt { get; set; }

    [Required]
    [Column(TypeName = "timestamp")]
    public DateTime UpdatedAt { get; set; }

    [Required]
    [ForeignKey(nameof(Genre))]
    public int GenreId { get; set; }
    public Genre Genre { get; set; } = null!;

    [Required]
    [ForeignKey(nameof(Artist))]
    public int ArtistId { get; set; }
    public Artist Artist { get; set; } = null!;

    [Required]
    [ForeignKey(nameof(Album))]
    public int? AlbumId { get; set; }
    public Album Album { get; set; } = null!;

    public ICollection<PlaylistSong> PlaylistSongs { get; set; } = new List<PlaylistSong>();
}
