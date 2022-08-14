using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShippingApi.Infrastructure;
using ShippingApi.Infrastructure.DTOs.CreateShipmentDtos;
using ShippingApi.Infrastructure.DTOs.ViewShipmentDtos;
using ShippingApi.Infrastructure.Entities;
using ShippingApi.Infrastructure.Extensions;
using ShippingApi.Services.Interfaces;

namespace ShippingApi.Services
{
    public class ShipmentService : IShipmentService, IDisposable
    {
        private readonly IMapper _mapper;
        private readonly ShippingDbContext _shippingDbContext;

        public ShipmentService(IMapper mapper, ShippingDbContext shippingDbContext)
        {
            _mapper = mapper;
            _shippingDbContext = shippingDbContext;
        }

        public async Task CreateShipmentAsync(CreateShipmentDto dto)
        {
            if (dto is null)
            {
                throw new ArgumentNullException("The incoming shipment couldn't be null");
            }

            var shipment = _mapper.Map<Shipment>(dto);

            await ValidateShipmentNumberAsync(shipment.ShipmentNumber);
            await ValidateBagNumbersAsync(shipment.FetchBagNumbers());
            await ValidateParcelBagsAsync(shipment.ParcelBags);

            _shippingDbContext.Add(shipment);

            await _shippingDbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _shippingDbContext.Dispose();
        }

        public async Task<IEnumerable<ViewShipmentDto>> GetShipmentsAsync()
        {
            var shipments = await _shippingDbContext.Shipments
                .Include(x => x.LetterBags)
                .Include(x => x.ParcelBags).ThenInclude(x => x.Parcels)
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();
            var result = _mapper.Map<IEnumerable<ViewShipmentDto>>(shipments);

            return result;
        }

        private async Task ValidateShipmentNumberAsync(string shipmentNumber)
        {
            if (await _shippingDbContext.Shipments.AnyAsync(x => x.ShipmentNumber == shipmentNumber))
            {
                throw new ArgumentException($"The shipment number {shipmentNumber} already exists");
            }
        }

        private async Task ValidateBagNumbersAsync(IEnumerable<string> bagNumbers)
        {
            if (!bagNumbers.Any())
            {
                throw new ArgumentException("Shipment should contain at least one bag");
            }

            var existedBags = await _shippingDbContext.Bags.Where(x => bagNumbers.Contains(x.BagNumber)).ToListAsync();

            if (existedBags.Any())
            {
                var errorList = existedBags
                    .Select(x => new ArgumentException($"The bag number {x.BagNumber} already exists"));

                throw new AggregateException(errorList);
            }
        }

        private async Task ValidateParcelBagsAsync(IEnumerable<ParcelBag> parcelBags)
        {
            if (!parcelBags.Any())
            {
                return;
            }

            if (!parcelBags.All(x => x.Parcels?.Any() ?? false))
            {
                throw new ArgumentException("Should contain at least one parcel");
            }

            var parcelNumbers = parcelBags.SelectMany(x => x.Parcels.Select(y => y.ParcelNumber));

            await ValidateParcelNumbersAsync(parcelNumbers);
        }

        private async Task ValidateParcelNumbersAsync(IEnumerable<string> parcelNumbers)
        {
            var existedParcels = await _shippingDbContext.Parcels
                    .Where(x => parcelNumbers.Contains(x.ParcelNumber)).ToListAsync();

            if (existedParcels.Any())
            {
                var errorList = existedParcels
                    .Select(x => new ArgumentException($"The parcel number {x.ParcelNumber} already exists"));

                throw new AggregateException(errorList);
            }
        }
    }
}
