using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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
            var list = new List<Menu>{
                new Menu { NameProduct="CocaCola 150", Price="€ 2.50"},
                new Menu { NameProduct="Insalata di pollo", Price="€ 5.20"},
                new Menu { NameProduct="Pizza Margherita", Price="€ 10.00"},
                new Menu { NameProduct="Pizza 4 Formaggi ", Price="€12.50"},
                new Menu { NameProduct="Pz patatine fritte", Price="€ 3.50"},
                new Menu { NameProduct="Insalata di riso", Price="€ 8.00"},
                new Menu { NameProduct="Frutta di stagione", Price="€ 5.00"},
            };
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
