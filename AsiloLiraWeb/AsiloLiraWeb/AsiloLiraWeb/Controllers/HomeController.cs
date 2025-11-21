using System.Diagnostics;
using AsiloLiraWeb.Data;
using AsiloLiraWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AsiloLiraWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AsiloContext _context;

        public HomeController(ILogger<HomeController> logger, AsiloContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SobreNostros()
        {
            return View();
        }

        public IActionResult HomeIndex()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Formulario(Voluntario voluntario)
        {
          if (!ModelState.IsValid)
             {
                 return View(voluntario);
             }

            _context.Voluntarios.Add(voluntario);
            _context.SaveChanges();

            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
