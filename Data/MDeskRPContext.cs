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
        public MDeskRPContext (DbContextOptions<MDeskRPContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Customer DbSet
        /// </summary>
        public DbSet<MDeskRP.Models.Customer> Customer { get; set; }

        /// <summary>
        /// DeskQuote DbSet
        /// </summary>
        public DbSet<MDeskRP.Models.DeskQuote> DeskQuote { get; set; }

        /// <summary>
        /// DeskSpecs DbSet
        /// </summary>
        public DbSet<MDeskRP.Models.DeskSpecs> DeskSpecs { get; set; }

        /// <summary>
        /// DeskTypeDescription DbSet
        /// </summary>
        public DbSet<MDeskRP.Models.DeskTypeDescription> DeskTypeDescription { get; set; }

        /// <summary>
        /// Data Model Creation Method
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DeskQuoteConfiguration());
            modelBuilder.ApplyConfiguration(new DeskSpecsConfiguration());
            modelBuilder.ApplyConfiguration(new DeskTypeDescriptionConfiguration());
        }
    }
}
