using ShippingApi.Infrastructure.Enums;

namespace ShippingApi.Infrastructure.DTOs.ViewShipmentDtos
{
    public class ViewBagDto
    {
        public string BagNumber { get; set; }
        public BagType BagType { get; set; }
        public int TotalItems { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
