using ShippingApi.Infrastructure.DTOs.CreateShipmentDtos;
using ShippingApi.Infrastructure.DTOs.ViewShipmentDtos;

namespace ShippingApi.Services.Interfaces
{
    public interface IShipmentService
    {
        Task<IEnumerable<ViewShipmentDto>> GetShipmentsAsync();
        Task CreateShipmentAsync(CreateShipmentDto dto);
    }
}
