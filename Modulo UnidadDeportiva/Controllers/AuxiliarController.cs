using Microsoft.AspNetCore.Mvc;
using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.Controllers
{
    public class AuxiliarController : Controller
    {
        private readonly IDocente _docente;
        private readonly IPasante _pasante;
        private readonly IMiembroE _miembro;
        private readonly IAutenticacion _auth;

        public AuxiliarController(IDocente docente, IPasante pasante, IMiembroE miembro, IAutenticacion auth)
        {
            _docente = docente;
            _pasante = pasante;
            _miembro = miembro;
            _auth = auth;
        }
        [HttpGet]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("_id") == null || HttpContext.Session.GetInt32("_id") == -1 
                || HttpContext.Session.GetInt32("_id") != 1)
            {
                return RedirectToAction("Index", "Home");
            }
            
            return View(_auth.IngresarAuxiliar((int) HttpContext.Session.GetInt32("_id")));
        }
        [Route("/Docente")]
        [HttpGet]
        public IActionResult AsistenciaDocente(AsistenciaDocenteModel model)
        {
            if (HttpContext.Session.GetInt32("_id") == null || HttpContext.Session.GetInt32("_id") == -1 
                || HttpContext.Session.GetInt32("_id") != 1)
            {
                return RedirectToAction("Index", "Home");
            }

            if (model.NombreDocente!=null && model.ApellidoDocente!=null)   //Si los datos de busqueda no son nulos busca el docente y toma asistencia
            {
                model= _docente.GetAsistenciaDocente(model.NombreDocente, model.ApellidoDocente);  

            }
            
            return View(model);
        }

        [Route("/Pasante")]
        [HttpGet]
        public IActionResult AsistenciaPasante(AsistenciaPasanteModel model)
        {
            if (HttpContext.Session.GetInt32("_id") == null || HttpContext.Session.GetInt32("_id") == -1 
                || HttpContext.Session.GetInt32("_id") != 1)
            {
                return RedirectToAction("Index", "Home");
            }

            if (model.codEstudiante!=null)
            {
                //Aca se llena model con los datos solicitados
            }
            return View(model);
        }
        [Route("/Miembro")]
        [HttpGet]
        public IActionResult AsistenciaMiembro(AsistenciaMiembroModel model)
        {
            if (HttpContext.Session.GetInt32("_id") == null || HttpContext.Session.GetInt32("_id") == -1 
                || HttpContext.Session.GetInt32("_id") != 1)
            {
                return RedirectToAction("Index", "Home");
            }

            if (model.Codigo != null && model.EquipoID!= null)
            {
                //Aca se llena model con los datos solicitados
            }
            return View(model);
        }

        /*
         * Hace falta pensar como es lo de la asitencia o si necesita vita
         * La vista anterior es necesaria?
         * 
         */

        [HttpPost]
        public IActionResult PrestamoMaterial(List<int> materiales)
        {
            if (HttpContext.Session.GetInt32("_id") == null || HttpContext.Session.GetInt32("_id") == -1 
                || HttpContext.Session.GetInt32("_id") != 1)
            {
                return RedirectToAction("Index", "Home");
            }
            /*
             * Acá va el codigo para prestar materiales
             * 
             */
            return RedirectToAction("Index");
        }

        [Route("/Pasante")]
        [HttpGet]
        public IActionResult AsistenciaPasante()
        {
            if (HttpContext.Session.GetInt32("_id") == null || HttpContext.Session.GetInt32("_id") == -1 
                || HttpContext.Session.GetInt32("_id") != 1)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public IActionResult AsistenciaDocentePost(AsistenciaDocenteModel model)
        {
            if (HttpContext.Session.GetInt32("_id") == null || HttpContext.Session.GetInt32("_id") == -1 
                || HttpContext.Session.GetInt32("_id") != 1)
            {
                return RedirectToAction("Index", "Home");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //Aca busca
            return View(model);
        }
        [Route("/Miembro")]
        [HttpGet]
        public IActionResult AsistenciaMiembro()
        {
            if (HttpContext.Session.GetInt32("_id") == null || HttpContext.Session.GetInt32("_id") == -1 
                || HttpContext.Session.GetInt32("_id") != 1)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
