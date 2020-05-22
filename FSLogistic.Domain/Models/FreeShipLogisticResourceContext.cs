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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-81STRLN\\LUCIFER;Database=FreeShipLogisticResource;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
