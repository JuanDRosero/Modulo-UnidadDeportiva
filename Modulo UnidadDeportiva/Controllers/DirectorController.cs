using Microsoft.AspNetCore.Mvc;
using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.Controllers
{
    public class DirectorController : Controller
    {
        private readonly IReportes _reportes;
        private readonly IAutenticacion _auth;
        private Empleado _empleado;
        public DirectorController(IReportes reportes, IAutenticacion auth)
        {
            _reportes = reportes;
            _auth = auth;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("_id") == null || HttpContext.Session.GetInt32("_id") == -1 
                || HttpContext.Session.GetInt32("_id") != 2)
            {
                return RedirectToAction("Index", "Home");
            }
            
            return View(_auth.IngresarDirector((int)HttpContext.Session.GetInt32("_id")));
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
