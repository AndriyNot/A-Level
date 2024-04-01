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
    public class ProductEntityConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.HasKey(h => h.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Price).IsRequired();
        }
    }
}
