using DAL.Entities.VehicleEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Data.Configs
{
    internal class BrandConfig : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                   .IsRequired()
                   .HasMaxLength(100);

           builder.HasIndex(b => b.Name)
                   .IsUnique();

            builder.HasMany(b => b.Models)
                   .WithOne(m => m.Brand)
                   .HasForeignKey(m => m.BrandId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Index for search by brand name
            builder.HasIndex(b => b.Name);
        }
    }
}
