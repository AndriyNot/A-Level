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
    public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(h => h.Id);
            builder.Property(p => p.FirstName).HasMaxLength(255);
            builder.Property(p => p.LastName).HasMaxLength(255);
        }
    }
}
