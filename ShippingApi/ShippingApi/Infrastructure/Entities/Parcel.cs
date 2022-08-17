using Microsoft.EntityFrameworkCore;

namespace ShippingApi.Infrastructure.Entities
{
    public class Parcel
    {
        public Guid Id { get; set; }
        public string ParcelNumber { get; set; }
        public string RecipientName { get; set; }
        public string DestinationCountry { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }
        public Guid ParcelBagId { get; set; }
        public ParcelBag ParcelBag { get; set; }
        public virtual Country Country { get; set; }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parcel>().HasKey(m => m.Id);
            modelBuilder.Entity<Parcel>().Property(m => m.ParcelNumber).HasColumnType("nchar(10)").IsRequired();
            modelBuilder.Entity<Parcel>().Property(m => m.RecipientName)
                .HasMaxLength(Constants.RecipientNameMaxSize).IsRequired();
            modelBuilder.Entity<Parcel>().Property(m => m.DestinationCountry).HasColumnType("nchar(2)").IsRequired();
            modelBuilder.Entity<Parcel>().Property(m => m.Weight).HasPrecision(8, 3).IsRequired();
            modelBuilder.Entity<Parcel>().Property(m => m.Price).HasPrecision(8, 2).IsRequired();
            modelBuilder.Entity<Parcel>().Property(m => m.ParcelBagId).IsRequired();
            modelBuilder.Entity<Parcel>().HasIndex(m => m.ParcelNumber).IsUnique();
            modelBuilder.Entity<Parcel>().HasOne(m => m.Country).WithMany().HasForeignKey(m => m.DestinationCountry);
        }
    }
}
