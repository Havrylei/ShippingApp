using Microsoft.EntityFrameworkCore;

namespace ShippingApi.Infrastructure.Entities
{
    public class Bag
    {
        public Guid Id { get; set; }
        public string BagNumber { get; set; }
        public Guid ShipmentId { get; set; }
        public virtual Shipment Shipment { get; set; }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bag>().HasKey(m => m.Id);
            modelBuilder.Entity<Bag>().Property(m => m.BagNumber).HasMaxLength(Constants.BagNumberMaxSize).IsRequired();
            modelBuilder.Entity<Bag>().Property(m => m.ShipmentId).IsRequired();
            modelBuilder.Entity<Bag>().HasIndex(m => m.BagNumber).IsUnique();
        }
    }
}
