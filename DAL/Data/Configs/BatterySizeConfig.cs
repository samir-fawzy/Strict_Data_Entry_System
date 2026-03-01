using DAL.Entities.VehicleEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Data.Configs
{
    internal class BatterySizeConfig : IEntityTypeConfiguration<BatterySize>
    {
        public void Configure(EntityTypeBuilder<BatterySize> builder)
        {
            builder.ToTable("BatterySizes");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                   .IsRequired()
                   .HasMaxLength(100);
        }
    }
}
