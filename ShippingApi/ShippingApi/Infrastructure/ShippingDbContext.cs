using Microsoft.EntityFrameworkCore;
using ShippingApi.Infrastructure.Entities;

namespace ShippingApi.Infrastructure
{
    public class ShippingDbContext : DbContext
    {
        public DbSet<Bag> Bags { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<LetterBag> LetterBags { get; set; }
        public DbSet<Parcel> Parcels { get; set; }

        public ShippingDbContext(DbContextOptions<ShippingDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Bag.Configure(modelBuilder);
            Shipment.Configure(modelBuilder);
            LetterBag.Configure(modelBuilder);
            Parcel.Configure(modelBuilder);
        }
    }
}
