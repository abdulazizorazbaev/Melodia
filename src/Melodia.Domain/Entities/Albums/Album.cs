using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melodia.Domain.Entities;

[Table("albums")]
public class Album
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = String.Empty;

    [Required]
    public DateTime ReleaseDate { get; set; }

    [Required]
    public string CoverUrl { get; set; } = String.Empty;

    [Required]
    [Column(TypeName = "timestamp")]
    public DateTime CreatedAt { get; set; }

    [Required]
    [Column(TypeName = "timestamp")]
    public DateTime UpdatedAt { get; set; }

    [Required]
    [ForeignKey(nameof(Artist))]
    public int ArtistId { get; set; }
    public Artist Artist { get; set; } = null!;

    public ICollection<Song> Songs { get; set; } = new List<Song>();
}
