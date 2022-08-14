using ShippingApi.Infrastructure.Enums;

namespace ShippingApi.Infrastructure.DTOs.ViewShipmentDtos
{
    public class ViewShipmentDto
    {
        public string ShipmentNumber { get; set; }
        public Airport Airport { get; set; }
        public string FlightNumber { get; set; }
        public DateTime FlightDate { get; set; }
        public ICollection<ViewBagDto> Bags { get; set; }
    }
}
