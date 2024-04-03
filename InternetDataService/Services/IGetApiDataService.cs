namespace InternetDataService.Services
{
    public interface IGetApiDataService
    {
        Task<string> GetCurrencies();
        Task<string> GetRate(int id);
    }
}
