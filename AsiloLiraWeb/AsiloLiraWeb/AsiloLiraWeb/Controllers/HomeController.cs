using System.Diagnostics;
using AsiloLiraWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AsiloLiraWeb.Controllers
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

        public IActionResult Formulario()
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
