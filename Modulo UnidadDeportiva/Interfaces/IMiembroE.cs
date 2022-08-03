using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.Interfaces
{
    public interface IMiembroE
    {
        public AsistenciaMiembroModel GetAsistenciaMiembro(int codigoEstudiante, Equipo equipo);
        public bool RegistrarAsistenciaEquipo(int codigoEstudiante, Equipo equipo);
    }
}
