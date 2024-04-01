using HomeWork4._5.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._5.Data.EntityConfigurations
{
    public class OrderItemEntityConfiguration : IEntityTypeConfiguration<OrderItemEntity>
    {
        public void Configure(EntityTypeBuilder<OrderItemEntity> builder)
        {
            builder.HasKey(h => h.Id);
            builder.Property(p => p.Count).IsRequired();
            builder.Property(p => p.OrderId).IsRequired();
            builder.Property(p => p.ProductId).IsRequired();

            builder.HasOne(h => h.Order)
                .WithMany(w => w.OrderItems)
                .HasForeignKey(h => h.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(h => h.Product)
                .WithMany(w => w.OrderItems)
                .HasForeignKey(h => h.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
