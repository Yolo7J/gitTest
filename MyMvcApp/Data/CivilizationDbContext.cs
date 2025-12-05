using Microsoft.EntityFrameworkCore;
using MyMvcApp.Models;

namespace MyMvcApp.Data
{
    public class CivilizationDbContext : DbContext
    {
        public CivilizationDbContext(DbContextOptions<CivilizationDbContext> options)
            : base(options)
        {
        }

        // Entities
        public DbSet<Civilization> Civilizations { get; set; }
        public DbSet<Leader> Leaders { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<CivicCard> CivicCards { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Wonder> Wonders { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Terrain> Terrains { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships
            modelBuilder.Entity<Leader>()
                .HasOne(l => l.Civilization)
                .WithMany(c => c.Leaders)
                .HasForeignKey(l => l.CivilizationId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<City>()
                .HasOne(c => c.Civilization)
                .WithMany()
                .HasForeignKey(c => c.CivilizationId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Building>()
                .HasOne(b => b.City)
                .WithMany(c => c.Buildings)
                .HasForeignKey(b => b.CityId)
                .OnDelete(DeleteBehavior.SetNull);

            // Add indexes for performance
            modelBuilder.Entity<Civilization>()
                .HasIndex(c => c.Name)
                .IsUnique();

            modelBuilder.Entity<Leader>()
                .HasIndex(l => l.Name);

            modelBuilder.Entity<City>()
                .HasIndex(c => c.Name);

            modelBuilder.Entity<Technology>()
                .HasIndex(t => new { t.Era, t.Name });

            modelBuilder.Entity<CivicCard>()
                .HasIndex(cc => new { cc.Era, t.Name });
        }
    }
}
