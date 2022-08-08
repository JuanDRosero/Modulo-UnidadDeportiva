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
        public IActionResult Index(string inputCod)
        {
            var usuario = _aut.IngresarAuxiliar(inputCod);
            if (usuario == null)
                usuario = _aut.IngresarDirector(inputCod);
            else
            {
                HttpContext.Session.SetInt32("_id", 1); //1 Aux
            }
                
                

            if (usuario==null)
            {
                return View();
            }
            HttpContext.Session.SetString("_cod", usuario.Codigo);
            HttpContext.Session.SetInt32("_id", 2); //ID Sesion 2 Director
            HttpContext.Session.SetString("Nombre", usuario.NombreEmpleado + " " + usuario.ApellidoEmpleado); //ID Sesion 1 Auxiliar

            switch (HttpContext.Session.GetInt32("_id"))
            {
                case 1:
                    return RedirectToAction("Index", "Auxiliar");
                case 2:
                    return RedirectToAction("Index", "Director");
                default:
                    return View();
                    
            }
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