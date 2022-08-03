using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.Interfaces
{
    public interface IDocente
    {
        public Empleado GetDocente(string Nombre, string Apellido);
        public AsistenciaDocenteModel GetAsistenciaDocente(DateTime fechaHora);   //hay que Revisar como son los valores DateTime
    }
}
