using HomeWork4._5.Data.Entities;
using HomeWork4._5.Data.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._5.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; } = null!;
        public DbSet<ProductEntity> Products { get; set; } = null!;
        public DbSet<OrderEntity> Orders { get; set; } = null!;
        public DbSet<OrderItemEntity> OrderItems { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemEntityConfiguration());
            modelBuilder.UseHiLo();
        }
    }
}
