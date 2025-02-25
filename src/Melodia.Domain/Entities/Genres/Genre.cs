using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melodia.Domain.Entities;

[Table("genres")]
public class Genre
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = String.Empty;

    [Required]
    [Column(TypeName = "timestamp")]
    public DateTime CreatedAt { get; set; }
    
    [Required]
    [Column(TypeName = "timestamp")]
    public DateTime UpdatedAt { get; set; }
}
