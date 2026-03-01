using DAL.Entities.EditEntites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Configs
{
    internal class EditConfig : IEntityTypeConfiguration<Edit>
    {
        public void Configure(EntityTypeBuilder<Edit> builder)
        {
            builder.ToTable("Edits");

            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Preparation)
                .WithMany()
                .HasForeignKey(e => e.PreparationId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            builder.HasOne(e => e.Usage)
                .WithMany()
                .HasForeignKey(e => e.UsageId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            builder.HasOne(e => e.Status)
            .WithMany()
            .HasForeignKey(e => e.StatusId)
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();

        }
    }
}
