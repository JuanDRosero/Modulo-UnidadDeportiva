using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.Interfaces
{
    public interface IDocente
    {
        public AsistenciaDocenteModel GetAsistenciaDocente(String nombre, string Apellido);   //hay que Revisar como son los valores DateTime
    }
}
