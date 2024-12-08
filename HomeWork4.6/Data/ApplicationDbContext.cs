using HomeWork4._6.Data.Entities;
using HomeWork4._6.Data.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace HomeWork4._6.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<BreedEntity> Breeds { get; set; } = null!;
        public DbSet<CategoryEntity> Categories { get; set; } = null!;
        public DbSet<LocationEntity> Locations { get; set; } = null!;
        public DbSet<PetEntity> Pets { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BreedEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());
            modelBuilder.ApplyConfiguration(new LocationEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PetEntityConfiguration());
            modelBuilder.UseHiLo();
        }
    }
}
