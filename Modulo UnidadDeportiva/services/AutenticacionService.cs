using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.services
{
    public class AutenticacionService : IAutenticacion
    {
        public Empleado IngresarAuxiliar(int codigo)
        {
            throw new NotImplementedException();    //Buscar en auxiliares
        }

        public Empleado IngresarDirector(int codigo)    //Buscar en Directores
        {
            throw new NotImplementedException();
        }
    }
}
