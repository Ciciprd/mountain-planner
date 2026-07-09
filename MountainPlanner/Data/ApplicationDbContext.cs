using Microsoft.EntityFrameworkCore;
using MountainPlanner.Models;

namespace MountainPlanner.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Ferrata> Ferratas => Set<Ferrata>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Ferrata>()
            .HasData(
                new Ferrata
                {
                    Id = 1,
                    Name = "Johann Klettersteig",
                    Difficulty = FerrataDifficulty.D
                },
                new Ferrata
                {
                    Id = 2,
                    Name = "Donnerkogel Klettersteig",
                    Difficulty = FerrataDifficulty.C
                }
            );
    }
}