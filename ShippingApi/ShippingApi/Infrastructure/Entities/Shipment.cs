using Microsoft.EntityFrameworkCore;
using ShippingApi.Infrastructure.Enums;

namespace ShippingApi.Infrastructure.Entities
{
    public class Shipment
    {
        public Guid Id { get; set; }
        public string ShipmentNumber { get; set; }
        public Airport Airport { get; set; }
        public string FlightNumber { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public virtual ICollection<LetterBag> LetterBags { get; set; }
        public virtual ICollection<ParcelBag> ParcelBags { get; set; }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shipment>().HasKey(m => m.Id);
            modelBuilder.Entity<Shipment>().Property(m => m.Airport).IsRequired();
            modelBuilder.Entity<Shipment>().Property(m => m.ShipmentNumber).HasColumnType("nchar(10)").IsRequired();
            modelBuilder.Entity<Shipment>().Property(m => m.FlightNumber).HasColumnType("nchar(6)").IsRequired();
            modelBuilder.Entity<Shipment>().Property(m => m.FlightDate).HasColumnType("datetime2").IsRequired();
            modelBuilder.Entity<Shipment>().Property(m => m.CreatedAt).HasColumnType("datetime2").IsRequired();
            modelBuilder.Entity<Shipment>().HasIndex(m => m.ShipmentNumber).IsUnique();
        }
    }
}
