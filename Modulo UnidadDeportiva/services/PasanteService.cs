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

        public AsistenciaPasanteModel GetAsistenciaPasante(DateTime fechaHora)
        {
            throw new NotImplementedException();
        }

        public Estudiante GetEstudiante(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}
