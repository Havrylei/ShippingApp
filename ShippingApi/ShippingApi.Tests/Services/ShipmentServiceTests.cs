using AutoFixture;
using AutoFixture.DataAnnotations;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using ShippingApi.Infrastructure.DTOs;
using ShippingApi.Infrastructure.Entities;
using ShippingApi.Services;

namespace ShippingApi.Tests.Services
{
    public class ShipmentServiceTests : BaseServiceTest
    {
        private readonly ShipmentService _shipmentService;

        public ShipmentServiceTests()
        {
            _fixture.Customize(new NoDataAnnotationsCustomization());
            _shipmentService = new ShipmentService(_mapper, _dbContext);
        }

        [Fact]
        public async Task CreateShipmentAsync_ShipmentDtoWithParcelAndLetterBags_Saves()
        {
            // Arrange
            var dto = _fixture.Create<ShipmentDto>();
            var expectedBagAmount = dto.ParcelBags.Count + dto.LetterBags.Count;
            var expectedParcelAmount = dto.ParcelBags.Sum(x => x.Parcels.Count);

            // Act
            await _shipmentService.CreateShipmentAsync(dto);

            // Assert
            var shipment = await _dbContext.Shipments.LastOrDefaultAsync();
            var bagAmount = await _dbContext.Bags.CountAsync();
            var parcelAmount = await _dbContext.Parcels.CountAsync();

            shipment.Should().NotBeNull();
            bagAmount.Should().Be(expectedBagAmount);
            parcelAmount.Should().Be(expectedParcelAmount);
        }

        [Fact]
        public async Task CreateShipmentAsync_ShipmentDtoWithOnlyParcelBags_Saves()
        {
            // Arrange
            var dto = _fixture.Build<ShipmentDto>().With(x => x.LetterBags, new List<LetterBagDto>()).Create();
            var expectedBagAmount = dto.ParcelBags.Count;
            var expectedParcelAmount = dto.ParcelBags.Sum(x => x.Parcels.Count);

            // Act
            await _shipmentService.CreateShipmentAsync(dto);

            // Assert
            var shipment = await _dbContext.Shipments.LastOrDefaultAsync();
            var bagAmount = await _dbContext.Bags.CountAsync();
            var parcelAmount = await _dbContext.Parcels.CountAsync();

            shipment.Should().NotBeNull();
            bagAmount.Should().Be(expectedBagAmount);
            parcelAmount.Should().Be(expectedParcelAmount);
        }

        [Fact]
        public async Task CreateShipmentAsync_ShipmentDtoWithOnlyLetterBags_Saves()
        {
            // Arrange
            var dto = _fixture.Build<ShipmentDto>().With(x => x.ParcelBags, new List<ParcelBagDto>()).Create();
            var expectedBagAmount = dto.LetterBags.Count;
            var expectedParcelAmount = 0;

            // Act
            await _shipmentService.CreateShipmentAsync(dto);

            // Assert
            var shipment = await _dbContext.Shipments.LastOrDefaultAsync();
            var bagAmount = await _dbContext.Bags.CountAsync();
            var parcelAmount = await _dbContext.Parcels.CountAsync();

            shipment.Should().NotBeNull();
            bagAmount.Should().Be(expectedBagAmount);
            parcelAmount.Should().Be(expectedParcelAmount);
        }

        [Fact]
        public async Task CreateShipmentAsync_ShipmentDtoWithExistingShipmentNumber_ThrowsArgumentException()
        {
            // Arrange
            var existingShipment = _fixture.Create<ShipmentDto>();
            var dto = _fixture.Build<ShipmentDto>()
                .With(x => x.ShipmentNumber, existingShipment.ShipmentNumber)
                .Create();

            await _shipmentService.CreateShipmentAsync(existingShipment);

            // Act
            var action = async () => await _shipmentService.CreateShipmentAsync(dto);

            // Assert
            await action.Should().ThrowAsync<ArgumentException>();

        }

        [Fact]
        public async Task CreateShipmentAsync_ShipmentDtoWithNoBags_ThrowsArgumentException()
        {
            // Arrange
            var dto = _fixture.Build<ShipmentDto>()
                .With(x => x.ParcelBags, new List<ParcelBagDto>())
                .With(x => x.LetterBags, new List<LetterBagDto>())
                .Create();

            // Act
            var action = async () => await _shipmentService.CreateShipmentAsync(dto);

            // Assert
            await action.Should().ThrowAsync<ArgumentException>();
        }

        [Fact]
        public async Task CreateShipmentAsync_ShipmentDtoWithNullBags_ThrowsArgumentException()
        {
            // Arrange
            var dto = _fixture.Build<ShipmentDto>()
                .Without(x => x.ParcelBags)
                .Without(x => x.LetterBags)
                .Create();

            // Act
            var action = async () => await _shipmentService.CreateShipmentAsync(dto);

            // Assert
            await action.Should().ThrowAsync<ArgumentException>();
        }

        [Fact]
        public async Task CreateShipmentAsync_ShipmentDtoIsNull_ThrowsArgumentNullException()
        {
            // Arrange
            var dto = default(ShipmentDto);

            // Act
            var action = async () => await _shipmentService.CreateShipmentAsync(dto);

            // Assert
            await action.Should().ThrowAsync<ArgumentNullException>();
        }

        [Fact]
        public async Task CreateShipmentAsync_ParcelBagWithExistingBagNumber_ThrowsArgumentException()
        {
            // Arrange
            var existingShipment = _fixture.Create<ShipmentDto>();
            var dto = _fixture.Build<ShipmentDto>()
                .With(x => x.ParcelBags, new List<ParcelBagDto>
                    {
                        _fixture.Build<ParcelBagDto>()
                            .With(x => x.BagNumber, existingShipment.ParcelBags.First().BagNumber)
                            .Create()
                    })
                .Create();

            await _shipmentService.CreateShipmentAsync(existingShipment);

            // Act
            var action = async () => await _shipmentService.CreateShipmentAsync(dto);

            // Assert
            await action.Should().ThrowAsync<AggregateException>();
        }

        [Fact]
        public async Task CreateShipmentAsync_LetterBagWithExistingBagNumber_ThrowsArgumentException()
        {
            // Arrange
            var existingShipment = _fixture.Create<ShipmentDto>();
            var dto = _fixture.Build<ShipmentDto>()
                .With(x => x.LetterBags, new List<LetterBagDto>
                    {
                        _fixture.Build<LetterBagDto>()
                            .With(x => x.BagNumber, existingShipment.ParcelBags.First().BagNumber)
                            .Create()
                    })
                .Create();

            await _shipmentService.CreateShipmentAsync(existingShipment);

            // Act
            var action = async () => await _shipmentService.CreateShipmentAsync(dto);

            // Assert
            await action.Should().ThrowAsync<AggregateException>();
        }

        [Fact]
        public async Task CreateShipmentAsync_ParcelBagWithNoParcels_ThrowsArgumentException()
        {
            // Arrange
            var dto = _fixture.Build<ShipmentDto>()
                .With(x => x.ParcelBags, new List<ParcelBagDto>
                    {
                        _fixture.Build<ParcelBagDto>()
                            .With(x => x.Parcels, new List<ParcelDto>())
                            .Create()
                    })
                .Create();

            // Act
            var action = async () => await _shipmentService.CreateShipmentAsync(dto);

            // Assert
            await action.Should().ThrowAsync<ArgumentException>();
        }

        [Fact]
        public async Task CreateShipmentAsync_ParcelBagWithNullParcels_ThrowsArgumentException()
        {
            // Arrange
            var dto = _fixture.Build<ShipmentDto>()
                .With(x => x.ParcelBags, new List<ParcelBagDto>
                    {
                        _fixture.Build<ParcelBagDto>()
                            .Without(x => x.Parcels)
                            .Create()
                    })
                .Create();

            // Act
            var action = async () => await _shipmentService.CreateShipmentAsync(dto);

            // Assert
            await action.Should().ThrowAsync<ArgumentException>();
        }

        [Fact]
        public async Task CreateShipmentAsync_ParcelWithExistingParcelNumber_ThrowsArgumentException()
        {
            // Arrange
            var existingShipment = _fixture.Create<ShipmentDto>();
            var existingParcelNumber = existingShipment.ParcelBags.First().Parcels.First().ParcelNumber;
            var dto = _fixture.Build<ShipmentDto>()
                .With(x => x.ParcelBags, new List<ParcelBagDto>
                    {
                        _fixture.Build<ParcelBagDto>()
                            .With(x => x.Parcels, new List<ParcelDto>
                            {
                                _fixture.Build<ParcelDto>()
                                    .With(x => x.ParcelNumber, existingParcelNumber)
                                    .Create()
                            })
                            .Create()
                    })
                .Create();

            await _shipmentService.CreateShipmentAsync(existingShipment);

            // Act
            var action = async () => await _shipmentService.CreateShipmentAsync(dto);

            // Assert
            await action.Should().ThrowAsync<AggregateException>();
        }

        [Fact]
        public async Task GetShipmentsAsync_ReturnsListOfShipments()
        {
            // Arrange
            var list = _fixture.Create<List<Shipment>>();

            _dbContext.AddRange(list);

            await _dbContext.SaveChangesAsync();

            // Act
            var result = await _shipmentService.GetShipmentsAsync();

            // Assert
            result.Should().NotBeEmpty();
        }

        [Fact]
        public async Task GetShipmentsAsync_WhenNoShipmentsExist_ReturnsEmptyList()
        {
            // Arrange

            // Act
            var result = await _shipmentService.GetShipmentsAsync();

            // Assert
            result.Should().BeEmpty();
        }
    }
}
