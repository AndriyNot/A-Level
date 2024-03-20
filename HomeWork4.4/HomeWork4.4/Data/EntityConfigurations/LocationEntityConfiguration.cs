using HomeWork4._4.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HomeWork4._4.Data.EntityConfigurations
{
    public class LocationEntityConfiguration : IEntityTypeConfiguration<LocationEntity>
    {
        public void Configure(EntityTypeBuilder<LocationEntity> builder)
        {
            builder.HasKey(a => a.Id); 
            builder.Property(b => b.LocationName).IsRequired();

        }
    }
}
