using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melodia.Domain.Entities;

[Table("playlists")]
public class Playlist
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = String.Empty;

    [Required]
    [Column(TypeName = "timestamp")]
    public DateTime CreatedAt { get; set; }

    [Required]
    [Column(TypeName = "timestamp")]
    public DateTime UpdatedAt { get; set; }

    [Required]
    [ForeignKey(nameof(User))]
    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public ICollection<PlaylistSong> PlaylistSongs { get; set; } = new List<PlaylistSong>();
}
