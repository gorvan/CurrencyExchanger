using NbrbAPI.Models;
using System.Text.Json;

namespace InternetDataService.Services
{
    public class CurrenctMapper : ICurrencyMapper
    {
        public Currency CurrencyFromString(string stringJson)
        {
            try
            {
                return JsonSerializer.Deserialize<Currency>(stringJson);
            }
            catch(Exception ex)
            {
                return null;
            }            
        }

        public IEnumerable<Currency> CurrencyListFromString(string stringJson)
        {
            try
            {
                return JsonSerializer.Deserialize<IEnumerable<Currency>>(stringJson);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Rate RateFromString(string stringJson)
        {
            try
            {
                return JsonSerializer.Deserialize<Rate>(stringJson);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
