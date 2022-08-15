using Microsoft.AspNetCore.Mvc;
using ShippingApi.Services.Interfaces;

namespace ShippingApi.Controllers
{
    [Route("api/[controller]")]
    public class CountriesController : Controller
    {
        private readonly ICountryService _countryService;

        public CountriesController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCountriesAsync()
        {
            var result = await _countryService.GetCountriesAsync();

            return Ok(result);
        }
    }
}
