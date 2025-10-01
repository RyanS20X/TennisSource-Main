using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TennisSource.Models;
namespace TennisSource.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<TennisTournament>? events = new List<TennisTournament> { new TennisTournament { TennisTournamentId = 1, Title = "Nationals 2025", Description = "testing desc 1" }, new TennisTournament { TennisTournamentId = 2, Title = "Nationals 2026", Description = "testing desc 2" }, new TennisTournament { TennisTournamentId = 3, Title = "Nationals 2027", Description = "testing desc 3" } };
            _logger.Log(LogLevel.Information, "Num of Events: " + events.Count);
               
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Hello()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            TennisTournament ev1 = new TennisTournament { TennisTournamentId = id };
            return View(ev1);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
