using DAL.Entities.VehicleEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Data.Configs
{
    internal class VehicleHistoryConfig : IEntityTypeConfiguration<VehicleHistory>
    {
        public void Configure(EntityTypeBuilder<VehicleHistory> builder)
        {
            builder.ToTable("VehicleHistories");

            builder.HasKey(vh => vh.Id);

            builder.Property(vh => vh.Date)
                   .IsRequired();

            builder.Property(vh => vh.VehicleNumber)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(vh => vh.ChassisNumber)
                   .IsRequired()
                   .HasMaxLength(50);


            builder.Property(vh => vh.BatteryNumber)
                   .IsRequired();

            builder.Property(vh => vh.AirConditioning)
                   .IsRequired();

            builder.Property(vh => vh.FuelType)
                   .IsRequired();

            builder.Property(vh => vh.Gearbox)
                   .IsRequired();

            builder.Property(vh => vh.Cabins)
                   .IsRequired();

            builder.HasOne(vh => vh.Vehicle)
                   .WithMany()
                   .HasForeignKey(vh => vh.VehicleId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(vh => vh.Usage)
               .WithMany()
               .HasForeignKey(vh => vh.UsageId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(vh => vh.Preparation)
               .WithMany()
               .HasForeignKey(vh => vh.PreparationId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(vh => vh.Status)
               .WithMany()
               .HasForeignKey(vh => vh.StatusId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(vh => vh.Unit)
               .WithMany()
               .HasForeignKey(vh => vh.UnitId)
               .OnDelete(DeleteBehavior.Restrict);

            // Index for queries filtering by history date
            builder.HasIndex(vh => vh.Date);

            // Composite index for history by vehicle and date
            builder.HasIndex(vh => new { vh.VehicleId, vh.Date });
        }
    }
}
