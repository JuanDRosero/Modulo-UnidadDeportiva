using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.services
{
    public class ReportesService : IReportes
    {
        private readonly string _connectionString;

        public ReportesService(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("OracleDBConnection2");
        }

        public List<EquipoModel> GetEquipos()
        {
            throw new NotImplementedException();
        }

        public List<PasanteModel> getPasantes()
        {
            throw new NotImplementedException();
        }
    }
}
