using AsiloLiraWeb.Data;
using AsiloLiraWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AsiloLiraWeb.Controllers
{
    public class VoluntariosController : Controller
    {
        private readonly AsiloContext _context;

        public VoluntariosController(AsiloContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Voluntario modelo)
        {
            if (!ModelState.IsValid)
            {
                return View(modelo);
            }

            _context.Voluntarios.Add(modelo);
            await _context.SaveChangesAsync();

            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
        {
            return View();
        }
    }
}
