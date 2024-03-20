using HomeWork4._4.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWork4._4.Data.EntityConfigurations
{
    public class BreedEntityConfiguration : IEntityTypeConfiguration<BreedEntity>
    {
        public void Configure(EntityTypeBuilder<BreedEntity> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(b => b.BreedName).IsRequired();

        }
    }
}
