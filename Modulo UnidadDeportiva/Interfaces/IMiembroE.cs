using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.Interfaces
{
    public interface IMiembroE
    {
        public AsistenciaMiembroModel GetAsistenciaMiembro(int codigoEstudiante, int equipo);
    }
}
