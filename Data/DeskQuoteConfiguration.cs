using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MDeskRP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MDeskRP.Data
{
    public class DeskQuoteConfiguration : IEntityTypeConfiguration<DeskQuote>
    {
        public void Configure(EntityTypeBuilder<DeskQuote> builder)
        {
            builder.ToTable("DeskQuote");
            builder.HasKey(q => q.DeskQuoteID);
            builder.Property(q => q.DeskQuoteID)
                .HasColumnType("int");
            builder.Property(q => q.CustomerID)
                .IsRequired()
                .HasColumnType("int");
            builder.HasOne(q => q.Customer)
                .WithMany(q => q.DeskQuotes)
                .HasForeignKey(q => q.CustomerID)
                .IsRequired();
            builder.Property(q => q.DeskSpecsID)
                .IsRequired()
                .HasColumnType("int");
            builder.HasOne(q => q.DeskSpecs)
                .WithMany(q => q.DeskQuotes)
                .HasForeignKey(q => q.DeskSpecsID)
                .IsRequired();
        }
    }
}
