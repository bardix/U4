using Es_con_console;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationCV.Models;

namespace WebApplicationCV.Controllers
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
            CV mioCV = new CV
            {
                InformazioniPersonali = new InformazioniPersonali
                {
                    nome = "Marco",
                    cognome = "Puccio",
                    telefono = "+393288317446",
                    email = "info@marcopuccio.com"
                },
                StudiEffettuati = new List<Studi>
                {
                    new Studi
                    {
                        qualifica = "Qualifica",
                        istituto = "UniPa",
                        tipo = "Tipo",
                        dal = new DateTime(2016, 09, 12),
                        al = new DateTime(2019, 07, 22)
                    },
                    new Studi
                    {
                        qualifica = "Specializzazione sviluppo software",
                        istituto = "Microsoft Center Milan",
                        tipo = "Specializzazione",
                        dal = new DateTime(2016, 09, 12),
                        al = new DateTime(2019, 07, 22)
                    }
                },
                Impieghi = new List<Impiego>
                {
                    new Impiego
                    {
                        esperienza = new Esperienza
                        {
                            azienda = "Libero Professionista",
                            jobTitle = "IT Manager",
                            dal = new DateTime(2016, 09, 12),
                            al = new DateTime(2016, 09, 12),
                            descrizione = "Sviluppatore software",
                            compiti = "Compito"
                        }
                    },
                    new Impiego
                    {
                        esperienza = new Esperienza
                        {
                            azienda = "Libero Professionista",
                            jobTitle = "Docenza e Formazione",
                            dal = new DateTime(2016, 09, 12),
                            al = new DateTime(2016, 09, 12),
                            descrizione = "Docente e formatore",
                            compiti = "Compito"
                        }
                    }
                }
            };

            return View(mioCV);
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
