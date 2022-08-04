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
            return View();
        }

        /*
         * acá van los metodos de generar reportes
         * 
         */
    }
}
