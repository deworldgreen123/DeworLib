using DeworLib.Dal.Models;
using Microsoft.EntityFrameworkCore;

namespace DeworLib.Dal;

public sealed class LibContext : DbContext
{
    public LibContext()
    {
        Database.EnsureCreated();
    }
    
    public LibContext(DbContextOptions<LibContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Book> Books { get; set; } = null!;
    public DbSet<Chapter> Chapters { get; set; } = null!;
    public DbSet<Genre> Genres { get; set; } = null!;
    public DbSet<Author> Authors { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasMany(c => c.Authors)
            .WithMany(s => s.Books)
            .UsingEntity(j => j.ToTable("AuthorToBook"));
    }
}