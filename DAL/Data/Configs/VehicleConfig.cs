using DAL.Entities.VehicleEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Data.Configs
{
    internal class VehicleConfig : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("Vehicles");

            builder.HasKey(v => v.Id);

            builder.Property(v => v.VehicleNumber)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(v => v.ChassisNumber)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(v => v.BatteryNumber)
                   .IsRequired();

            builder.Property(v => v.AirConditioning)
                   .IsRequired();

            builder.Property(v => v.Fuel)
                   .IsRequired();

            builder.Property(v => v.Gearbox)
                   .IsRequired();

            builder.Property(v => v.Cabin)
                   .IsRequired();

            builder.HasOne(v => v.Model)
                   .WithMany()
                   .HasForeignKey(v => v.ModelId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(v => v.Engine)
                   .WithMany()
                   .HasForeignKey(v => v.EngineId)
                   .OnDelete(DeleteBehavior.Restrict)
                   .IsRequired(); 

            builder.HasOne(v => v.Payload)
                   .WithMany()
                   .HasForeignKey(v => v.PayloadId)
                   .OnDelete(DeleteBehavior.Restrict)
                   .IsRequired(); 

            builder.HasOne(v => v.BatterySize)
                   .WithMany()
                   .HasForeignKey(v => v.BatterySizeId)
                   .OnDelete(DeleteBehavior.Restrict)
                   .IsRequired(); 

            builder.HasOne(v => v.TireSize)
                   .WithMany()
                   .HasForeignKey(v => v.TireSizeId)
                   .OnDelete(DeleteBehavior.Restrict)
                   .IsRequired();

            builder.HasOne(v => v.TireNumber)
               .WithMany()
               .HasForeignKey(v => v.TireNumberId)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired();

            // Indexes for frequent search columns
            builder.HasIndex(v => v.VehicleNumber)
                   .IsUnique();

            builder.HasIndex(v => v.ChassisNumber)
                   .IsUnique();

            // Helpful if queries often filter by both identifiers together
            builder.HasIndex(v => new { v.VehicleNumber, v.ChassisNumber });
        }
    }
}
