using ShippingApi.Infrastructure.DTOs;

namespace ShippingApi.Services.Interfaces
{
    public interface IShipmentService
    {
        Task<IEnumerable<ShipmentDto>> GetShipmentsAsync();
        Task CreateShipmentAsync(ShipmentDto dto);
    }
}
