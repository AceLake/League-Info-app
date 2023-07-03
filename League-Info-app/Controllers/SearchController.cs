using League_Info_app.Models;
using League_Info_app.Services;
using Microsoft.AspNetCore.Mvc;

namespace League_Info_app.Controllers
{
    public class SearchController : Controller
    {
        //private ILeagueApiService _leagueApiService = new LeagueApiService();
        private ILeagueApiService _leagueApiService;

        public SearchController(ILeagueApiService leagueApiService)
        {
            _leagueApiService = leagueApiService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> ProssesSearch(SummonerModel summonerName)
        {
            SummonerModel summoner = await _leagueApiService.GetSummonerByName(summonerName.name);
           
            return View(summoner);
        }
        public IActionResult ProcessMastery(string accountId)
        {
            List<ChampionMasteryDto> mastery = await _leagueApiService.GetMasteryByID(summoner.accountId);
            return View(mastery);
        }
    }
}
