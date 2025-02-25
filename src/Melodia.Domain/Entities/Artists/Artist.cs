using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melodia.Domain.Entities;

[Table("artists")]
public class Artist
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; } = String.Empty;

    [Required]
    [MaxLength(50)]
    public string LastName { get; set; } = String.Empty;

    [MaxLength(255)]
    public string Bio { get; set; } = String.Empty;

    [MaxLength(255)]
    public string ImageUrl { get; set; } = String.Empty;

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
}
