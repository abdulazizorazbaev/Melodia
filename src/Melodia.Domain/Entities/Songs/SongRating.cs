using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melodia.Domain.Entities;

[Table("song_ratings")]
public class SongRating
{
    [Key]
    public int Id { get; set; }
    
    public int Rating { get; set; } = 0;

    [Required]
    [Column(TypeName = "timestamp")]
    public DateTime RatedAt { get; set; }

    [Required]
    [ForeignKey(nameof(User))]
    public int UserId { get; set; }
    public User User { get; set; } = null!;

    [Required]
    [ForeignKey(nameof(Song))]
    public int SongId { get; set; }
    public Song Song { get; set; } = null!;
}
