using Microsoft.AspNetCore.Mvc;
using Modulo_UnidadDeportiva.Interfaces;

namespace Modulo_UnidadDeportiva.Controllers
{
    public class DirectorController : Controller
    {
        private readonly IReportes _reportes;
        public DirectorController(IReportes reportes)
        {
            _reportes = reportes;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("_id") == null || HttpContext.Session.GetInt32("_id") == -1)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [Route("/HorasPasantes")]
        [HttpGet]
        public IActionResult HorasPasante()  //Redireccionar
        {
            if (HttpContext.Session.GetInt32("_id") == null || HttpContext.Session.GetInt32("_id") == -1)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [Route("/HorasEquipo")]
        [HttpGet]
        public IActionResult HorasEquipo() //Corregir este metodo para que redireccione
        {
            if (HttpContext.Session.GetInt32("_id") == null || HttpContext.Session.GetInt32("_id") == -1)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
