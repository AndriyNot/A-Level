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
    public class OrderEntityConfiguration : IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.HasKey(h => h.Id);
            builder.Property(p => p.UserId).IsRequired();

            builder.HasOne(h => h.User)
                .WithMany(w => w.Orders)
                .HasForeignKey(h => h.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
