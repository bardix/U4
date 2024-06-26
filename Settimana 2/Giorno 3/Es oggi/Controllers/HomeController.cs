using Es_oggi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Es_oggi.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult Index()
        {
            return View(Cinema.Tickets);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                Cinema.Tickets.Add(ticket);
                return RedirectToAction("Index");
            }
            return View(ticket);
        }

        public IActionResult Summary()
        {
            var model = new SummaryViewModel
            {
                NorthHallTickets = Cinema.Tickets.Count(t => t.Hall == "SALA NORD"),
                EastHallTickets = Cinema.Tickets.Count(t => t.Hall == "SALA EST"),
                SouthHallTickets = Cinema.Tickets.Count(t => t.Hall == "SALA SUD"),
                NorthHallReducedTickets = Cinema.Tickets.Count(t => t.Hall == "SALA NORD" && t.IsReduced),
                EastHallReducedTickets = Cinema.Tickets.Count(t => t.Hall == "SALA EST" && t.IsReduced),
                SouthHallReducedTickets = Cinema.Tickets.Count(t => t.Hall == "SALA SUD" && t.IsReduced),
            };
            return View(model);
        }
    }
}
