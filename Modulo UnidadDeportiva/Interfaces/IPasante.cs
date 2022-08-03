using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.Interfaces
{
    public interface IPasante
    {
        public Estudiante GetEstudiante(int codigo);    //3.2.2.1.
        public AsistenciaPasanteModel GetAsistenciaPasante(DateTime fechaHora);

    }
}
