using System;
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
                optionsBuilder.UseSqlServer("Server=DESKTOP-GPAHG3F\\SQLEXPRESS;Database=FreeShipLogisticResource;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>(entity =>
            //{
            //    entity.Property(e => e.Name)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);
            //});
            //OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
