using HomeWork4._6.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWork4._6.Data.EntityConfigurations
{
    public class PetEntityConfiguration : IEntityTypeConfiguration<PetEntity>
    {
        public void Configure(EntityTypeBuilder<PetEntity> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(b => b.Name).IsRequired();
            builder.Property(e => e.Age).IsRequired();
            builder.Property(e => e.ImageUrl).IsRequired();
            builder.Property(e => e.Description).IsRequired();

        }
    }
}
