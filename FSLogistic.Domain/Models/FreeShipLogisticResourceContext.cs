using System;
using FSLogistic.Core.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FSLogistic.Domain.Models
{
    public partial class FreeShipLogisticResourceContext : DbContext
    {
        public FreeShipLogisticResourceContext()
        {
        }

        public FreeShipLogisticResourceContext(DbContextOptions<FreeShipLogisticResourceContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Autocomplete> Autocomplete { get; set; }
        public virtual DbSet<Bill> Bill { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Summary> Summary { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Const.ConnectionStringResource);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            using(var seedDataObject = new SeedData())
            {
                seedDataObject.SeedDataForInitialize(modelBuilder);
            }
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
