using League_Info_app.Models;
using System.Xml.Linq;

namespace League_Info_app.Services
{
    public interface ILeagueApiService
    {
        Task<List<SummonerModel>> GetSummonerByRsoPUUID(string SummonerID);
        Task<List<SummonerModel>> GetSummonerByAccountID(string AccountID);
        Task<List<SummonerModel>> GetSummonerByName(string SummonerName);
        Task<List<SummonerModel>> GetSummonerByPUUID(string SummonerID);
        Task<List<SummonerModel>> GetSummonerByToken(string Bearertoken);
        Task<List<SummonerModel>> GetSummonerBySummonerID(string SummonerID);
    }
}
