namespace Modulo_UnidadDeportiva.Models
{
    public class AsistenciaDocenteModel
    {
        #region AtributosDeBusqueda
        //Atributos utilizados para buscar
        public string? NombreDocente { get; set; }
        public string? ApellidoDocente { get; set; }
        #endregion

        public Empleado? empleado { get; set; }
        public Curso Curso { get; set; }
        public Espacio Espacio { get; set; }
        public Deporte  Deporte { get; set; }
        public int numEstudiantes { get; set; }
    }
}
