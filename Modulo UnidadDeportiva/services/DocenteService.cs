using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.services
{
    public class DocenteService : IDocente
    {
        private readonly string _connectionString;
        public DocenteService(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("OracleDBConnection");
        }

        public AsistenciaDocenteModel GetAsistenciaDocente(String nombre, string Apellido)
        {

            var adm = new AsistenciaDocenteModel();
            /*
            {
                Curso=...,
                numEstudiantes=...,

            };
            */
            //Aca tendria que ir una consulta que con el nombre y el apellido y por debajo la aplicacion
            //obtiene los datos del docente y la fecha actual y  retorna los datos  AsistenciaViewModel
            throw new NotImplementedException();    //Se encarga de obtener lo del 3.2.1.2.
            return adm;
        }

    }
}
