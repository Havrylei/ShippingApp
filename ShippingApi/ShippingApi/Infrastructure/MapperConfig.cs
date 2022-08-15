using AutoMapper;
using ShippingApi.Infrastructure.DTOs;
using ShippingApi.Infrastructure.DTOs.CreateShipmentDtos;
using ShippingApi.Infrastructure.DTOs.ViewShipmentDtos;
using ShippingApi.Infrastructure.Entities;
using ShippingApi.Infrastructure.Enums;

namespace ShippingApi.Infrastructure
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LetterBag, ViewBagDto>()
                .ForMember(d => d.BagNumber, o => o.MapFrom(s => s.BagNumber))
                .ForMember(d => d.BagType, o => o.MapFrom(s => BagType.Letter))
                .ForMember(d => d.TotalItems, o => o.MapFrom(s => s.CountOfLetters))
                .ForMember(d => d.TotalPrice, o => o.MapFrom(s => s.Price));
            CreateMap<Country, CountryDto>()
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.Code, o => o.MapFrom(s => s.Code));
            CreateMap<ParcelBag, ViewBagDto>()
                .ForMember(d => d.BagNumber, o => o.MapFrom(s => s.BagNumber))
                .ForMember(d => d.BagType, o => o.MapFrom(s => BagType.Letter))
                .ForMember(d => d.TotalItems, o => o.MapFrom(s => s.Parcels.Count))
                .ForMember(d => d.TotalPrice, o => o.MapFrom(s => s.Parcels.Sum(x => x.Price)));
            CreateMap<Shipment, ViewShipmentDto>()
                .ForMember(d => d.ShipmentNumber, o => o.MapFrom(s => s.ShipmentNumber))
                .ForMember(d => d.Airport, o => o.MapFrom(s => s.Airport))
                .ForMember(d => d.FlightNumber, o => o.MapFrom(s => s.FlightNumber))
                .ForMember(d => d.FlightDate, o => o.MapFrom(s => s.FlightDate))
                .ForMember(d => d.Bags, o => o.Ignore())
                .AfterMap((entity, dto, c) =>
                {
                    var letterBags = c.Mapper.Map<ICollection<ViewBagDto>>(entity.LetterBags);
                    var parcelBags = c.Mapper.Map<ICollection<ViewBagDto>>(entity.ParcelBags);

                    dto.Bags = letterBags.Concat(parcelBags).ToList();
                });
            CreateMap<CreateParcelDto, Parcel>()
                .ForMember(d => d.ParcelNumber, o => o.MapFrom(s => s.ParcelNumber.ToUpper()))
                .ForMember(d => d.RecipientName, o => o.MapFrom(s => s.RecipientName.Trim()))
                .ForMember(d => d.DestinationCountry, o => o.MapFrom(s => s.DestinationCountry.ToUpper()))
                .ForMember(d => d.Weight, o => o.MapFrom(s => s.Weight))
                .ForMember(d => d.Price, o => o.MapFrom(s => s.Price));
            CreateMap<CreateLetterBagDto, LetterBag>()
                .ForMember(d => d.BagNumber, o => o.MapFrom(s => s.BagNumber.ToUpper()))
                .ForMember(d => d.CountOfLetters, o => o.MapFrom(s => s.CountOfLetters))
                .ForMember(d => d.Weight, o => o.MapFrom(s => s.Weight))
                .ForMember(d => d.Price, o => o.MapFrom(s => s.Price));
            CreateMap<CreateParcelBagDto, ParcelBag>()
                .ForMember(d => d.BagNumber, o => o.MapFrom(s => s.BagNumber.ToUpper()))
                .ForMember(d => d.Parcels, o => o.MapFrom(s => s.Parcels));
            CreateMap<CreateShipmentDto, Shipment>()
                .ForMember(d => d.ShipmentNumber, o => o.MapFrom(s => s.ShipmentNumber.ToUpper()))
                .ForMember(d => d.Airport, o => o.MapFrom(s => s.Airport))
                .ForMember(d => d.FlightNumber, o => o.MapFrom(s => s.FlightNumber.ToUpper()))
                .ForMember(d => d.FlightDate, o => o.MapFrom(s => s.FlightDate.ToUniversalTime()))
                .ForMember(d => d.LetterBags, o => o.MapFrom(s => s.LetterBags))
                .ForMember(d => d.ParcelBags, o => o.MapFrom(s => s.ParcelBags));
        }
    }
}
