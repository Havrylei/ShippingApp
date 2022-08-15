using System.ComponentModel.DataAnnotations;
using static ShippingApi.Infrastructure.Constants;

namespace ShippingApi.Infrastructure.DTOs.CreateShipmentDtos
{
    public class CreateParcelBagDto
    {
        [Required]
        [StringLength(BagNumberMaxSize, ErrorMessage = "Max bag number length is 15 characters")]
        [RegularExpression(@"[a-zA-z\d]+", ErrorMessage = "No special symbols allowed")]
        public string BagNumber { get; set; }
        [Required]
        public ICollection<CreateParcelDto> Parcels { get; set; }
    }
}
