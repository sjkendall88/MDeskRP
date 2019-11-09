using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MDeskRP.Models;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MDeskRP.Data
{
    public class DeskSpecsConfiguration : IEntityTypeConfiguration<DeskSpecs>
    {
        public void Configure(EntityTypeBuilder<DeskSpecs> builder)
        {
            builder.ToTable("DeskSpecs");
            builder.HasKey(s => s.DeskSpecsID);
            builder.Property(s => s.DeskSpecsID)
                .HasColumnType("int");
            builder.Property(s => s.Width)
                .HasColumnType("nvarchar(2)")
                .HasMaxLength(2)
                .IsRequired();
            builder.Property(s => s.Depth)
                .HasColumnType("nvarchar(2)")
                .HasMaxLength(2)
                .IsRequired();
            builder.Property(s => s.NumOfDrawers)
                .HasColumnName("Number of Drawers")
                .HasColumnType("nvarchar(1)")
                .HasMaxLength(1)
                .IsRequired();
            builder.Property(s => s.RushDays)
                .HasColumnName("Rush Days")
                .HasColumnType("nvarchar(1)")
                .HasMaxLength(1)
                .IsRequired();
            builder.Property(s => s.DeskTypeString)
                .HasColumnName("Desktop type")
                .HasColumnType("varchar(30)")
                .HasConversion(
                    s => s.ToString(),
                    s => (DeskTypeEnum)Enum.Parse(typeof(DeskTypeEnum), s));
            builder.HasOne(s => s.DeskTypeDescription)
                .WithMany(dd => dd.DeskQuote)
                .HasForeignKey(s => s.DeskTypeString);
        }
    }
}
