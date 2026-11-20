using Baitap06.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Baitap06.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Genre> Genres { get; set; }
    public DbSet<Movie> Movies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>().HasData(
            new Genre { Id = 1, Name = "Hành động" },
            new Genre { Id = 2, Name = "Hoạt hình" },
            new Genre { Id = 3, Name = "Tình cảm" },
            new Genre { Id = 4, Name = "Giả tưởng" }
        );
    }
}