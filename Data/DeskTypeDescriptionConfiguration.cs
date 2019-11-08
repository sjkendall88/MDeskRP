using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MDeskRP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MDeskRP.Data
{
    public class DeskTypeDescriptionConfiguration : IEntityTypeConfiguration<DeskTypeDescription>
    {
        public void Configure(EntityTypeBuilder<DeskTypeDescription> builder)
        {
            builder.ToTable("DeskTypeDescription");
            builder.HasKey(d => d.DeskTypeString);
            builder.Property(d => d.DeskTypeString)
                .HasColumnType("nvarchar(15)")
                .HasConversion(
                    d => d.ToString(),
                    d => (DeskTypeEnum) Enum.Parse(typeof(DeskTypeEnum), d));
            builder.Property(d => d.DeskType)
                .IsRequired()
                .HasColumnType("nvarchar(40)")
                .HasMaxLength(40);
        }
    }
}
