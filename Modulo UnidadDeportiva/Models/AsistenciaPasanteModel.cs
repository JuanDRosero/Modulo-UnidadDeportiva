using Microsoft.AspNetCore.Mvc.Rendering;

namespace Modulo_UnidadDeportiva.Models
{
    public class AsistenciaPasanteModel
    {
        #region PropiedadesBusqueda
        public int? codEstudiante { get; set; }
        #endregion

        public string nombrePractica { get; set; }  //No hay tabla practica

        public bool HastItems { get; set; } = false;

        public Espacio Espacio { get; set; }
        public Deporte Deporte { get; set; }
        public int numEstudiantes { get; set; }

        public List<SelectListItem>? ElementosDisp { get; set; }

        public List<string> ElementosAPrestar { get; set; }
    }
}
