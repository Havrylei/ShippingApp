using Microsoft.EntityFrameworkCore;

namespace ShippingApi.Infrastructure.Entities
{
    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasKey(m => m.Code);
            modelBuilder.Entity<Country>().Property(m => m.Name).IsRequired();
            modelBuilder.Entity<Country>().Property(m => m.Code).HasColumnType("nchar(2)").IsRequired();
        }
    }
}
