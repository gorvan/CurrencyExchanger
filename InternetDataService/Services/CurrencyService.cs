using NbrbAPI.Models;

namespace InternetDataService.Services
{
    public class CurrencyService : ICurrencyService
    {
        private readonly IGetApiDataService apiDataService;
        private readonly ICurrencyMapper currencyMapper;

        public CurrencyService(IGetApiDataService apiDataService, ICurrencyMapper currencyMapper)
        {
            this.apiDataService = apiDataService;
            this.currencyMapper = currencyMapper;
        }

        public async Task<IEnumerable<Currency>> GetCurrencies()
        {
            var stringResult = await apiDataService.GetCurrencies();
            return currencyMapper.CurrencyListFromString(stringResult);
        }
        
        public async Task<Rate> GetRateById(int Cur_id)
        {
            var stringResult = await apiDataService.GetRate(Cur_id);  
            return currencyMapper.RateFromString(stringResult);
        }
    }
}
