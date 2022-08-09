using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;
using Oracle.ManagedDataAccess.Client;

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
            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                using(OracleCommand command = new OracleCommand())
                {
                    con.Open();
                    command.Connection = con;
                    command.CommandText = $"select E.codempleado id, C.noinscrito, D.nomdeporte, Esp.nomespacio from (select E.codempleado from empleado E where E.nomempleado = 'sebastian' and E.apellempleado= 'sanchez') E, responsable R, (select P.* from programacion P where P.idactividad= 'cu') C, espacio Esp, deporte D  where R.consecprogra=C.consecprogra and R.idrol=2 and R.codempleado=E.codempleado and C.iddia=(select case when to_char(sysdate,'day') like '%lun%' then 'l' when to_char(sysdate,'day') like '%mart%' then 'm' when to_char(sysdate,'day') like '%mi%' then 'w' when to_char(sysdate,'day') like '%jue%' then 'j' when to_char(sysdate,'day') like '%vie%' then 'v' end Dia from dual) and C.iddeporte=D.iddeporte and C.codespacio=Esp.codespacio";
                    command.CommandType = System.Data.CommandType.Text;
                    OracleDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        adm.HasItems = true;
                        adm.IDDocente = Convert.ToInt32(reader["codempleado"]);
                        adm.Curso = reader["nomdeporte"].ToString();
                        adm.Espacio = new Espacio() { NomEspacio = reader["nomespacio"].ToString() };
                        adm.Deporte = new Deporte() { Nombre = reader["nomdeporte"].ToString() };
                        adm.numEstudiantes = Convert.ToInt32(reader["noinscrito"]);

                    }
                    else
                    {
                        adm.HasItems = false;
                    }
                }
            }
                /*
                {
                    Curso=...,
                    numEstudiantes=...,

                };
                */
                //Aca tendria que ir una consulta que con el nombre y el apellido y por debajo la aplicacion
                //obtiene los datos del docente y la fecha actual y  retorna los datos  AsistenciaViewModel
                int idSede = 0, depid = 0;
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
