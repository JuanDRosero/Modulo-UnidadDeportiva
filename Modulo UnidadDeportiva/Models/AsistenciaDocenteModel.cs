namespace Modulo_UnidadDeportiva.Models
{
    public class AsistenciaDocenteModel
    {
        public Curso Curso { get; set; }
        public Espacio Espacio { get; set; }
        public Deporte  Deporte { get; set; }
        public int numEstudiantes { get; set; }
    }
}
