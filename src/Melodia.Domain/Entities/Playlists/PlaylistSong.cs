using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melodia.Domain.Entities;

[Table("playlist_songs")]
public class PlaylistSong
{
    [Required]
    [ForeignKey(nameof(Playlist))]
    public int PlaylistId { get; set; }
    public Playlist Playlist { get; set; } = null!;

    [Required]
    [ForeignKey(nameof(Song))]
    public int SongId { get; set; }
    public Song Song { get; set; } = null!;
}