using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.services
{
    public class PasanteService : IPasante
    {
        private readonly string _connectionString;

        public PasanteService(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("OracleDBConnection");
        }

        public AsistenciaPasanteModel GetAsistenciaPasante(int codigo)
        {

            //3.2.2.1. y  3.2.2.1.
            throw new NotImplementedException();
        }

    }
}
