using AutoMapper;
using ShippingApi.Infrastructure.DTOs;
using ShippingApi.Infrastructure.Entities;

namespace ShippingApi.Infrastructure
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Parcel, ParcelDto>()
                .ForMember(d => d.ParcelNumber, o => o.MapFrom(s => s.ParcelNumber))
                .ForMember(d => d.RecipientName, o => o.MapFrom(s => s.RecipientName))
                .ForMember(d => d.DestinationCountry, o => o.MapFrom(s => s.DestinationCountry))
                .ForMember(d => d.Weight, o => o.MapFrom(s => s.Weight))
                .ForMember(d => d.Price, o => o.MapFrom(s => s.Price));
            CreateMap<LetterBag, LetterBagDto>()
                .ForMember(d => d.BagNumber, o => o.MapFrom(s => s.BagNumber))
                .ForMember(d => d.CountOfLetters, o => o.MapFrom(s => s.CountOfLetters))
                .ForMember(d => d.Weight, o => o.MapFrom(s => s.Weight))
                .ForMember(d => d.Price, o => o.MapFrom(s => s.Price));
            CreateMap<ParcelBag, ParcelBagDto>()
                .ForMember(d => d.BagNumber, o => o.MapFrom(s => s.BagNumber))
                .ForMember(d => d.Parcels, o => o.MapFrom(s => s.Parcels));
            CreateMap<Shipment, ShipmentDto>()
                .ForMember(d => d.ShipmentNumber, o => o.MapFrom(s => s.ShipmentNumber))
                .ForMember(d => d.Airport, o => o.MapFrom(s => s.Airport))
                .ForMember(d => d.FlightNumber, o => o.MapFrom(s => s.FlightNumber))
                .ForMember(d => d.FlightDate, o => o.MapFrom(s => s.FlightDate.Date))
                .ForMember(d => d.LetterBags, o => o.MapFrom(s => s.LetterBags))
                .ForMember(d => d.ParcelBags, o => o.MapFrom(s => s.ParcelBags));
            CreateMap<ParcelDto, Parcel>()
                .ForMember(d => d.ParcelNumber, o => o.MapFrom(s => s.ParcelNumber.ToUpper()))
                .ForMember(d => d.RecipientName, o => o.MapFrom(s => s.RecipientName.Trim()))
                .ForMember(d => d.DestinationCountry, o => o.MapFrom(s => s.DestinationCountry.ToUpper()))
                .ForMember(d => d.Weight, o => o.MapFrom(s => s.Weight))
                .ForMember(d => d.Price, o => o.MapFrom(s => s.Price));
            CreateMap<LetterBagDto, LetterBag>()
                .ForMember(d => d.BagNumber, o => o.MapFrom(s => s.BagNumber.ToUpper()))
                .ForMember(d => d.CountOfLetters, o => o.MapFrom(s => s.CountOfLetters))
                .ForMember(d => d.Weight, o => o.MapFrom(s => s.Weight))
                .ForMember(d => d.Price, o => o.MapFrom(s => s.Price));
            CreateMap<ParcelBagDto, ParcelBag>()
                .ForMember(d => d.BagNumber, o => o.MapFrom(s => s.BagNumber.ToUpper()))
                .ForMember(d => d.Parcels, o => o.MapFrom(s => s.Parcels));
            CreateMap<ShipmentDto, Shipment>()
                .ForMember(d => d.ShipmentNumber, o => o.MapFrom(s => s.ShipmentNumber.ToUpper()))
                .ForMember(d => d.Airport, o => o.MapFrom(s => s.Airport))
                .ForMember(d => d.FlightNumber, o => o.MapFrom(s => s.FlightNumber.ToUpper()))
                .ForMember(d => d.FlightDate, o => o.MapFrom(s => s.FlightDate))
                .ForMember(d => d.LetterBags, o => o.MapFrom(s => s.LetterBags))
                .ForMember(d => d.ParcelBags, o => o.MapFrom(s => s.ParcelBags));
        }
    }
}
