using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.services
{
    public class DocenteService : IDocente
    {
        private readonly string _connectionString;
        private readonly IElementosDep _elementos;
        public DocenteService(IConfiguration config, IElementosDep elementos)
        {
            _connectionString = config.GetConnectionString("OracleDBConnection");
            _elementos = elementos;
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
            int idSede=0, depid=0;
            foreach (var item in _elementos.GetElementos(idSede, depid, new DateTime()))
            {
                adm.ElementosDisp.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem()
                {
                    Value = item.IDElementoD.ToString(),
                    Text = item.DescTipo
                });
            }
            
            return adm;
        }

    }
}
