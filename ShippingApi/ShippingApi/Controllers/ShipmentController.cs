using Microsoft.AspNetCore.Mvc;
using ShippingApi.Infrastructure.Attributes;
using ShippingApi.Infrastructure.DTOs.CreateShipmentDtos;
using ShippingApi.Infrastructure.Enums;
using ShippingApi.Services.Interfaces;

namespace ShippingApi.Controllers
{
    [Route("api/[controller]")]
    public class ShipmentController : Controller
    {
        private readonly IShipmentService _shipmentService;

        public ShipmentController(IShipmentService shipmentService)
        {
            _shipmentService = shipmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetShipmentsAsync()
        {
            var result = await _shipmentService.GetShipmentsAsync();

            return Ok(result);
        }

        [HttpPost("Create")]
        [ValidationFilter]
        [ExceptionFilter]
        public async Task<IActionResult> CreateShipmentAsync([FromBody] CreateShipmentDto dto)
        {
            await _shipmentService.CreateShipmentAsync(dto);

            return Ok();
        }

        [HttpGet("GetAirports")]
        public IActionResult GetAirportsAsync()
        {
            return Ok(Enum.GetValues<Airport>());
        }
    }
}
