using System.ComponentModel.DataAnnotations;
using static ShippingApi.Infrastructure.Constants;

namespace ShippingApi.Infrastructure.DTOs
{
    public class ParcelBagDto
    {
        [Required]
        [StringLength(BagNumberMaxSize, ErrorMessage = "Max bag number length is 15 characters")]
        public string BagNumber { get; set; }
        [Required]
        public ICollection<ParcelDto> Parcels { get; set; }
    }
}
