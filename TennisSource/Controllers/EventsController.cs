using Microsoft.AspNetCore.Mvc;
using TennisSource.Models;

namespace TennisSource.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index(int id)
        {
            List<TennisTournament>? events = new List<TennisTournament> { new TennisTournament { TennisTournamentId = 1, Title = "Nationals 2025", Description = "testing desc 1" }, new TennisTournament { TennisTournamentId = 2, Title = "Nationals 2026", Description = "testing desc 2" }, new TennisTournament { TennisTournamentId = 3, Title = "Nationals 2027", Description = "testing desc 3" } };

            return View(events);
           
        }

        public IActionResult Details(int id)
        {
            TennisTournament TestEv = new TennisTournament { TennisTournamentId = 1, Title = "Nationals 2025", Description = "testing desc 1" };
            return View(TestEv);
        }

    }
}