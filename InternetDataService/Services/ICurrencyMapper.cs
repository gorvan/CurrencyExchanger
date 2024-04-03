using NbrbAPI.Models;

namespace InternetDataService.Services
{
    public interface ICurrencyMapper
    {
        IEnumerable<Currency> CurrencyListFromString(string stringJson);
        Currency CurrencyFromString(string stringJson);
        Rate RateFromString(string stringJson);       
    }
}
