using Microsoft.EntityFrameworkCore;

namespace ShippingApi.Infrastructure.Entities
{
    public class LetterBag : Bag
    {
        public int CountOfLetters { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }

        public static new void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LetterBag>().Property(m => m.CountOfLetters).IsRequired();
            modelBuilder.Entity<LetterBag>().Property(m => m.Weight).HasPrecision(8, 3).IsRequired();
            modelBuilder.Entity<LetterBag>().Property(m => m.Price).HasPrecision(8, 2).IsRequired();
        }
    }
}
