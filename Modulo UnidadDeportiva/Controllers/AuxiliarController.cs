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
        private readonly IElementosDep _prestamo;
        private readonly IAutenticacion _auth;

        public AuxiliarController(IDocente docente, IPasante pasante, IMiembroE miembro, IAutenticacion auth,
            IElementosDep prestamo)
        {
            _docente = docente;
            _pasante = pasante;
            _miembro = miembro;
            _prestamo = prestamo;
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
                model = _pasante.GetAsistenciaPasante((int)model.codEstudiante);
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
                model = _miembro.GetAsistenciaMiembro(model.Codigo, model.EquipoID);
            }
            return View(model);
        }


        [HttpPost]
        public IActionResult PrestamoMaterial(int idDocente,List<string> materiales)
        {
            if (HttpContext.Session.GetInt32("_id") == null || HttpContext.Session.GetInt32("_id") == -1 
                || HttpContext.Session.GetInt32("_id") != 1)
            {
                return RedirectToAction("Index", "Home");
            }
            var correcto = _prestamo.Prestar(materiales.Select(x=>Convert.ToInt32(x)).ToList(), idDocente);
            return RedirectToAction("Index");
        }

    }
}
