using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MDeskRP.Data;
using Microsoft.EntityFrameworkCore;

namespace MDeskRP.Models
{
    public class MDeskRPContext : DbContext
    {
        public MDeskRPContext(DbContextOptions<MDeskRPContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Customer DbSet
        /// </summary>
        public DbSet<MDeskRP.Models.Customer> Customer { get; set; }

        public DbSet<MDeskRP.Models.DeskQuote> DeskQuote { get; set; }
        public DbSet<MDeskRP.Models.DeskSpecs> DeskSpecs { get; set; }
        public DbSet<MDeskRP.Models.DeskTypeDescription> DeskTypeDescription { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DeskQuoteConfiguration());
            modelBuilder.ApplyConfiguration(new DeskSpecsConfiguration());
            modelBuilder.ApplyConfiguration(new DeskTypeDescriptionConfiguration());
            // modelBuilder.ApplyConfiguration(new );
        }
    }
}
