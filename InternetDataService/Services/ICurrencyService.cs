using NbrbAPI.Models;

namespace InternetDataService.Services
{
    public interface ICurrencyService
    {
        Task<IEnumerable<Currency>> GetCurrencies();        
        Task<Rate> GetRateById(int Cur_id);
    }
}
