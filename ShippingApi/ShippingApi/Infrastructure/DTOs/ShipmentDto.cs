using ShippingApi.Infrastructure.Attributes;
using ShippingApi.Infrastructure.Enums;
using System.ComponentModel.DataAnnotations;

namespace ShippingApi.Infrastructure.DTOs
{
    public class ShipmentDto
    {
        [Required]
        [RegularExpression(@"[a-zA-z\d]{3}-[a-zA-z\d]{6}", ErrorMessage = "Incorrect shipment number format")]
        public string ShipmentNumber { get; set; }
        [Required]
        [EnumDataType(typeof(Airport))]
        public Airport Airport { get; set; }
        [Required]
        [RegularExpression(@"[a-zA-z]{2}\d{4}", ErrorMessage = "Incorrect flight number format")]
        public string FlightNumber { get; set; }
        [Required]
        [FutureDate(ErrorMessage = "The flight date couldn't be in past")]
        public DateTime FlightDate { get; set; }
        public ICollection<LetterBagDto> LetterBags { get; set; }
        public ICollection<ParcelBagDto> ParcelBags { get; set; }
    }
}
