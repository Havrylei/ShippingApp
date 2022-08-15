using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using ShippingApi.Infrastructure;
using ShippingApi.Infrastructure.DTOs;
using ShippingApi.Services.Interfaces;

namespace ShippingApi.Services
{
    public class CountryService : ICountryService, IDisposable
    {
        private const string CountriesCacheKey = "COUNTRIES";

        private readonly IMapper _mapper;
        private readonly IMemoryCache _memoryCache;
        private readonly ShippingDbContext _shippingDbContext;

        public CountryService(IMapper mapper, IMemoryCache memoryCache, ShippingDbContext shippingDbContext)
        {
            _mapper = mapper;
            _memoryCache = memoryCache;
            _shippingDbContext = shippingDbContext;
        }

        public void Dispose()
        {
            _shippingDbContext.Dispose();
        }

        public async Task<IEnumerable<CountryDto>> GetCountriesAsync()
        {
            if (_memoryCache.TryGetValue<IEnumerable<CountryDto>>(CountriesCacheKey, out var result))
            {
                return result;
            }

            var countries = await _shippingDbContext.Countries.OrderBy(x => x.Name).ToListAsync();

            result = _mapper.Map<IEnumerable<CountryDto>>(countries);

            _memoryCache.Set(CountriesCacheKey, result);

            return result;
        }
    }
}
