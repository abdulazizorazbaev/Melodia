using Melodia.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Melodia.DataAccess.AppDbContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PlaylistSong>().HasKey(ps => new { ps.PlaylistId, ps.SongId });

        modelBuilder.Entity<PlaylistSong>().HasOne(ps => ps.Playlist).WithMany(p => p.PlaylistSongs).HasForeignKey(ps => ps.PlaylistId);

        modelBuilder.Entity<PlaylistSong>().HasOne(ps => ps.Song).WithMany(s => s.PlaylistSongs).HasForeignKey(ps => ps.SongId);

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Genre> Genres { get; set; }

    public DbSet<Song> Songs { get; set; }
    public DbSet<SongRating> SongRatings { get; set; }

    public DbSet<Playlist> Playlists { get; set; }
    public DbSet<PlaylistSong> PlaylistSongs { get; set; }
}
