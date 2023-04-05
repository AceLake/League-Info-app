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

        public async Task<IActionResult> Index()
        {
            SummonerModel summoner = new SummonerModel();
            summoner = await _leagueApiService.GetSummonerByName("WhiteWolfyness");

            return View(summoner);
        }
    }
}
