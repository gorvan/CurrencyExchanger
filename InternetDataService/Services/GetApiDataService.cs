namespace InternetDataService.Services
{
    public class GetApiDataService : IGetApiDataService
    {
        private readonly string currencyLink = @"https://api.nbrb.by/exrates/currencies";
        private readonly string rateLink = @"https://api.nbrb.by/exrates/rates";

        HttpClient httpClient { get; set; }

        public GetApiDataService()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> GetCurrencies()
        {
            return await GetData(currencyLink);
        }

        public async Task<string> GetRate(int id)
        {
            return await GetData(rateLink + $"/{id}");
        }

        private async Task<string> GetData(string connectionString)
        {
            try
            {
                if (IsInternetConnected)
                {
                    var responce = await httpClient.GetAsync(connectionString);

                    if (responce.IsSuccessStatusCode)
                    {
                        return await responce.Content.ReadAsStringAsync();
                    }
                }
            }
            catch (InvalidOperationException ex)
            {

            }
            catch (HttpRequestException ex)
            {

            }
            catch (TaskCanceledException ex)
            {

            }
            catch (UriFormatException ex)
            {

            }
            catch (Exception ex)
            {

            }
            return "";
        }

        public bool IsInternetConnected => System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
    }
}
