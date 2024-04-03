using InternetDataService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NbrbAPI.Models;

namespace InternetDataService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InternetDataController : ControllerBase
    {

        private readonly ICurrencyService _currencyService;

        public InternetDataController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }

        [HttpGet]
        public async Task<IEnumerable<Currency>> GetCurrencies()
        {
            return await _currencyService.GetCurrencies();
        }

        [HttpGet("{id}")]
        public async Task<Rate> GetRateById(int id)
        {
            return await _currencyService.GetRateById(id);
        }
    }
}
