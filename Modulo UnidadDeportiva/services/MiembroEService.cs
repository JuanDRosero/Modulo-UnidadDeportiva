using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.services
{
    public class MiembroEService : IMiembroE
    {
        private readonly string _connectionString;

        public MiembroEService(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("OracleDBConnection");
        }

        public AsistenciaMiembroModel GetAsistenciaMiembro(int codigoEstudiante, int equipo)
        {
            throw new NotImplementedException();
        }
    }
}
