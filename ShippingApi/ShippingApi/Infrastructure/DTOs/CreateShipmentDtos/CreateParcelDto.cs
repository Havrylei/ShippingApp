using System.ComponentModel.DataAnnotations;
using static ShippingApi.Infrastructure.Constants;

namespace ShippingApi.Infrastructure.DTOs.CreateShipmentDtos
{
    public class CreateParcelDto
    {
        [Required]
        [RegularExpression(@"[a-zA-z]{2}\d{6}[a-zA-z]{2}", ErrorMessage = "Incorrect parcel number format")]
        public string ParcelNumber { get; set; }
        [Required]
        [StringLength(RecipientNameMaxSize, ErrorMessage = "Max recipient number length is 100 characters")]
        public string RecipientName { get; set; }
        [Required]
        [RegularExpression(@"[a-zA-z]{2}", ErrorMessage = "Incorrect destination country format")]
        public string DestinationCountry { get; set; }
        [Required]
        [Range(0.001, double.MaxValue, ErrorMessage = "Incorrect weight")]
        public decimal Weight { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Incorrect price")]
        public decimal Price { get; set; }
    }
}
