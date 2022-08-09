using Microsoft.AspNetCore.Mvc.Rendering;

namespace Modulo_UnidadDeportiva.Models
{
    public class AsistenciaDocenteModel
    {
        public int IDDocente { get; set; }
        #region AtributosDeBusqueda
        //Atributos utilizados para buscar
        public string? NombreDocente { get; set; }
        public string? ApellidoDocente { get; set; }
        #endregion

        public bool HasItems { get; set; } = false; //Si la busqueda arroja algo esto pasa a true sino es false

        public string Curso { get; set; }
        public Espacio Espacio { get; set; }
        public Deporte Deporte { get; set; }
        public int numEstudiantes { get; set; }

        public List<SelectListItem> ElementosDisp { get; set; }
        public List<string> ElementosAPrestar{ get; set; }

    }
}
