using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melodia.Domain.Entities;

[Table("users")]
public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; } = String.Empty;

    [Required]
    [MaxLength(50)]
    public string LastName { get; set; } = String.Empty;

    [Required]
    [MaxLength(50)]
    public string Username { get; set; } = String.Empty;

    [Required]
    [EmailAddress]
    [MaxLength(100)]
    public string Email { get; set; } = String.Empty;

    [Required]
    [MinLength(8)]
    public string PasswordHash { get; set; } = String.Empty;

    [Required]
    public string PasswordSalt { get; set; } = String.Empty;

    public string? ProfilePictureUrl { get; set; }

    [Required]
    [Column(TypeName = "timestamp")]
    public DateTime CreatedAt { get; set; }

    [Required]
    [Column(TypeName = "timestamp")]
    public DateTime UpdatedAt { get; set; }

    public ICollection<Playlist> Playlists { get; set; } = new List<Playlist>();
}
