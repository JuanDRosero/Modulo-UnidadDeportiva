/*
 * Controlador Responsable del Login
 * 
 */
using Microsoft.AspNetCore.Mvc;
using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;
using System.Diagnostics;

namespace Modulo_UnidadDeportiva.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAutenticacion _aut;

        public HomeController(ILogger<HomeController> logger, IAutenticacion auth)
        {
            _logger = logger;
            _aut = auth;
        }

        [HttpGet]
        public IActionResult Index()    //Retorna la vista del form de loggeo
        {
            HttpContext.Session.SetInt32("_id", -1);//Inicia el ID en la sesion en-1
            return View();
        }
        [HttpPost]
        public IActionResult Index(int codigo)
        {
            var usuario = _aut.IngresarAuxiliar(codigo);
            if (usuario == null)
                usuario = _aut.IngresarDirector(codigo);
            if (usuario==null)
            {
                return View();
            }
            //  Revisar acá para que valide según el tipo de usuario a donde lo manda
            //Ademas hay que Añadir el uso de la sesion
            return RedirectToAction("Index", "Controlador");
        }


        /*
        public IActionResult Privacy()
        {
            return View();
        }
        */

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}