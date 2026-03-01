using DAL.Entities.VehicleEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Data.Configs
{
    internal class TireSizeConfig : IEntityTypeConfiguration<TireSize>
    {
        public void Configure(EntityTypeBuilder<TireSize> builder)
        {
            builder.ToTable("TireSizes");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name)
                   .IsRequired()
                   .HasMaxLength(100);
        }
    }
}
