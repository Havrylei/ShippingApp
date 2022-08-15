using ShippingApi.Infrastructure.DTOs;

namespace ShippingApi.Services.Interfaces
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryDto>> GetCountriesAsync();
    }
}
