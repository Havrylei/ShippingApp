using System.ComponentModel.DataAnnotations;
using static ShippingApi.Infrastructure.Constants;

namespace ShippingApi.Infrastructure.DTOs.CreateShipmentDtos
{
    public class CreateLetterBagDto
    {
        [Required]
        [StringLength(BagNumberMaxSize, ErrorMessage = "Max bag number length is 15 characters")]
        public string BagNumber { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Incorrect count of letters")]
        public int CountOfLetters { get; set; }
        [Required]
        [Range(0.001, double.MaxValue, ErrorMessage = "Incorrect weight")]
        public decimal Weight { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Incorrect price")]
        public decimal Price { get; set; }
    }
}
