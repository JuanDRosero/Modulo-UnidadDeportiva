using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.services
{
    public class AutenticacionService : IAutenticacion
    {
        private readonly string _connectionString;
        public AutenticacionService(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("OracleDBConnection");
        }

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
