using Microsoft.EntityFrameworkCore;
using DeliveryRoutes.Domain.DeliveryRoutes.Model;
using DeliveryRoutes.Domain.DeliveryRoutes.Infrastructure.EntityConfiguration;

namespace DeliveryRoutes.Infrastructure
{
    public sealed class DeliveryRoutesDbContext : DbContext
    {
        public DeliveryRoutesDbContext(DbContextOptions<DeliveryRoutesDbContext> options) : base(options)
        {
        }

        public DbSet<DeliveryRoutesEntity> DeliveryRoutes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DeliveryRoutesTypeConfiguration());
        }
    }
}
