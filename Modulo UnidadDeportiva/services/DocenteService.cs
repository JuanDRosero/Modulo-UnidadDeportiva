using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;
using Oracle.ManagedDataAccess.Client;

namespace Modulo_UnidadDeportiva.services
{
    public class DocenteService : IDocente
    {
        private readonly string _connectionString;
        private readonly IElementosDep _elementos;
        private readonly ILogger<DocenteService> logger;
        public DocenteService(IConfiguration config, IElementosDep elementos, ILogger<DocenteService> logger)
        {
            _connectionString = config.GetConnectionString("OracleDBConnection");
            _elementos = elementos;
            this.logger = logger;
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
                    command.BindByName = true;
                    command.CommandText = $"select R.consecres, P.consecprogra, E.codempleado id, " +
                        $"D.iddeporte iddeporte, Esp.codespacio codespacio, C.noinscrito, D.nomdeporte, " +
                        $"Esp.nomespacio from (select E.codempleado from empleado E where " +
                        $"E.nomempleado = '{nombre}' and E.apellempleado = '{Apellido}') E, responsable R, " +
                        $"(select P.* from programacion P where P.idactividad= 'cu') C, espacio Esp, deporte D, " +
                        $"programacion P  where R.consecprogra = C.consecprogra and R.idrol=2 and " +
                        $"R.codempleado = E.codempleado and C.iddia=(select case when to_char(sysdate-1,'day') " +
                        $"like '%lun%' then 'l' when to_char(sysdate-1,'day') like '%mart%' then 'm' when " +
                        $"to_char(sysdate-1,'day') like '%mi%' then 'w' when to_char(sysdate-1,'day') " +
                        $"like '%jue%' then 'j' when to_char(sysdate-1,'day') like '%vie%' then 'v' " +
                        $"end Dia from dual) and C.iddeporte=D.iddeporte and C.codespacio=Esp.codespacio " +
                        $"and P.consecprogra = R.consecres";
                    command.CommandType = System.Data.CommandType.Text;
                    OracleDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        adm.HasItems = true;
                        adm.IDDocente = Convert.ToInt32(reader["id"].ToString());
                        adm.Curso = reader["nomdeporte"].ToString();
                        adm.Espacio = new Espacio() {
                            NomEspacio = reader["nomespacio"].ToString(),
                            CodEspacio = reader["codespacio"].ToString()

                        };
                        adm.Deporte = new Deporte() { 
                            Nombre = reader["nomdeporte"].ToString(),
                            IdDeporte = reader["iddeporte"].ToString()
                        };
                        adm.numEstudiantes = Convert.ToInt32(reader["noinscrito"]);
                        adm.idResponsable = Convert.ToInt32(reader["consecres"].ToString());
                        adm.idProgramacion = Convert.ToInt32(reader["consecprogra"].ToString());
                    }
                    else
                    {
                        adm.HasItems = false;
                    }
                }
            }

            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                using (OracleCommand command = new OracleCommand())
                {
                    con.Open();
                    command.Connection = con;
                    command.BindByName = true;
                    command.CommandText = $"insert into asistirresponsable (consecasisres, consecres, " +
                            $"consecprogra, fechaasisres, horaasisres) values " +
                            $"('" + adm.idResponsable + "','" + adm.idResponsable + "','" + adm.idProgramacion + "'," +
                            "to_date(sysdate, 'yyyy-mm-dd'),to_date(sysdate, 'yyyy-mm-dd hh:mi'))";
                    command.ExecuteNonQuery();
                }
            }

            string idSede = adm.Espacio.CodEspacio, depid = adm.Deporte.IdDeporte;
            var lista = _elementos.GetElementos(idSede, depid, new DateTime());
            adm.ElementosDisp = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();
            foreach (var item in lista)
            {
                adm.ElementosDisp.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem()
                {
                    Value = item.IDElementoD.ToString(),
                    Text = item.DescTipo

                });
                logger.LogError(item.IDElementoD.ToString());
            }
            
            return adm;
        }

    }
}
