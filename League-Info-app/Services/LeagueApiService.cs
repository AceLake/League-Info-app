using League_Info_app.Models;
using System.Text.Json;

namespace League_Info_app.Services
{
    public class LeagueApiService : ILeagueApiService
    {
        private static readonly HttpClient client;
        private static string apiKey = "RGAPI-aca0bd20-63a8-4cba-b885-c9aa97d3dcb2";

        static LeagueApiService()
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri("https://na1.api.riotgames.com")
            };
        }

        public Task<List<SummonerModel>> GetSummonerByAccountID(string AccountID)
        {
            throw new NotImplementedException();
        }

        public async Task<SummonerModel> GetSummonerByName(string SummonerName)
        {
            // The first line is building the Url of the API and using the SummonerName and apiKey parameters
            var url = string.Format("/tft/summoner/v1/summoners/by-name/{0}?api_key={1}", SummonerName, apiKey);
            var result = new SummonerModel();

            // Next, we are making an API call using the GetAsync method that sends a GET request to the specified Uri as an asynchronous operation.
            // The method returns System.Net.Http.HttpResponseMessage object that represents an HTTP response message including the status code and data.
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                // Next, we are calling ReadAsStringAsync method that serializes the HTTP content to a string
                var stringResponse = await response.Content.ReadAsStringAsync();

                // Finally, we are using JsonSerializer to Deserialize the JSON response string into a List of HolidayModel objects.
                result = JsonSerializer.Deserialize<SummonerModel>(stringResponse,
                    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }

            return result;
        }

        public Task<List<SummonerModel>> GetSummonerByPUUID(string SummonerID)
        {
            throw new NotImplementedException();
        }

        public Task<List<SummonerModel>> GetSummonerByRsoPUUID(string SummonerID)
        {
            throw new NotImplementedException();
        }

        public Task<List<SummonerModel>> GetSummonerBySummonerID(string SummonerID)
        {
            throw new NotImplementedException();
        }

        public Task<List<SummonerModel>> GetSummonerByToken(string Bearertoken)
        {
            throw new NotImplementedException();
        }
    }
}
