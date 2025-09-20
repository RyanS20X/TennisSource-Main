using Microsoft.AspNetCore.Mvc;
using TennisSource.Models;

namespace TennisSource.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index(int id)
        {
            List<Event>? events = new List<Event> { new Event { EventId = 1, Title = "Nationals 2025", Description = "testing desc 1" }, new Event { EventId = 2, Title = "Nationals 2026", Description = "testing desc 2" }, new Event { EventId = 3, Title = "Nationals 2027", Description = "testing desc 3" } };

            return View(events);
           
        }

        public IActionResult Details()
        {
            return View();
        }

    }
}