using Moq;
using ShippingApi.Controllers;
using ShippingApi.Services.Interfaces;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using AutoFixture;
using AutoFixture.DataAnnotations;
using ShippingApi.Infrastructure.DTOs.CreateShipmentDtos;
using ShippingApi.Infrastructure.DTOs.ViewShipmentDtos;

namespace ShippingApi.Tests.Controllers
{
    public class ShipmentControllerTests
    {
        private readonly Fixture _fixture;
        private readonly Mock<IShipmentService> _shipmentServiceMock;
        private readonly ShipmentController _shipmentController;

        public ShipmentControllerTests()
        {
            _fixture = new Fixture();
            _shipmentServiceMock = new Mock<IShipmentService>(MockBehavior.Strict);
            _shipmentController = new ShipmentController(_shipmentServiceMock.Object);

            _fixture.Customize(new NoDataAnnotationsCustomization());
        }

        [Fact]
        public async Task CreateShipmentAsync_ValidShipmentDto_ReturnsOkResult()
        {
            // Arrange
            var dto = _fixture.Create<CreateShipmentDto>();

            _shipmentServiceMock.Setup(x => x.CreateShipmentAsync(dto)).Returns(Task.CompletedTask);

            // Act
            var result = await _shipmentController.CreateShipmentAsync(dto);

            // Assert
            result.Should().BeAssignableTo<OkResult>();

            _shipmentServiceMock.Verify(x => x.CreateShipmentAsync(dto), Times.Once);
        }

        [Fact]
        public async Task GetShipmentsAsync_ReturnsOkObjectResult()
        {
            // Arrange
            var list = _fixture.Create<IEnumerable<ViewShipmentDto>>();

            _shipmentServiceMock.Setup(x => x.GetShipmentsAsync()).Returns(Task.FromResult(list));

            // Act
            var result = await _shipmentController.GetShipmentsAsync();

            // Assert
            result.Should().BeAssignableTo<OkObjectResult>();

            _shipmentServiceMock.Verify(x => x.GetShipmentsAsync(), Times.Once);
        }

        [Fact]
        public async Task GetShipmentsAsync_WhenNoShipmentsExist_ReturnsOkObjectResult()
        {
            // Arrange
            _shipmentServiceMock.Setup(x => x.GetShipmentsAsync())
                .Returns(Task.FromResult((IEnumerable<ViewShipmentDto>)new List<ViewShipmentDto>()));

            // Act
            var result = await _shipmentController.GetShipmentsAsync();

            // Assert
            result.Should().BeAssignableTo<OkObjectResult>();

            _shipmentServiceMock.Verify(x => x.GetShipmentsAsync(), Times.Once);
        }
    }
}
