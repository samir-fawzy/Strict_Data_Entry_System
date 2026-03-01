using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Configs
{
    internal class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects");

            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Vehicle)
                   .WithMany()
                   .HasForeignKey(p => p.VehicleId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.VehicleHistory)
                   .WithMany()
                   .HasForeignKey(p => p.VehicleHistoryId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Edit)
                   .WithMany()
                   .HasForeignKey(p => p.EditId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Unit)
                   .WithMany()
                   .HasForeignKey(p => p.UnitId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
