using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.services
{
    public class DocenteService : IDocente
    {
        public AsistenciaDocenteModel GetAsistenciaDocente(DateTime fechaHora)
        {
            throw new NotImplementedException();    //Se encarga de obtener lo del 3.2.1.2.
        }

        public Empleado GetDocente(string Nombre, string Apellido)
        {
            throw new NotImplementedException();    //Se encarga de obtener lo del 3.2.1.1.
        }
    }
}
