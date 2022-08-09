using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;
using Oracle.ManagedDataAccess.Client;

namespace Modulo_UnidadDeportiva.services
{
    public class PasanteService : IPasante
    {
        private readonly string _connectionString;
        private readonly IElementosDep _elementos;
        private readonly ILogger<DocenteService> logger;

        public PasanteService(IConfiguration config, IElementosDep elementos)
        {
            _connectionString = config.GetConnectionString("OracleDBConnection");
            _elementos = elementos;
        }

        public AsistenciaPasanteModel GetAsistenciaPasante(string codigo)
        {
            var amp = new AsistenciaPasanteModel();
            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                using (OracleCommand command = new OracleCommand())
                {
                    con.Open();
                    command.Connection = con;
                    command.BindByName = true;
                    command.CommandText = $"SELECT E.codespacio, E.nomespacio, D.nomdeporte, P.noinscrito, P.idhorainicio, " +
                        $"P.idhorafin, D.iddeporte, D.nomdeporte from (select P.* from programacion P where idactividad = 'pr') P, estudiante Est, " +
                        $"espacio E, deporte D, responsable R where P.consecprogra = R.consecres and " +
                        $"R.codEstu = Est.codestu and P.iddia = (select case when to_char(sysdate+2,'day') like '%lun%' " +
                        $"then 'l' when to_char(sysdate+2,'day') like '%mart%' then 'm' when to_char(sysdate+2,'day') like " +
                        $"'%mi%' then 'w' when to_char(sysdate+2,'day') like '%jue%' then 'j' when to_char(sysdate+2,'day') " +
                        $"like '%vie%' then 'v' end Dia from dual) and E.codespacio = P.codespacio and " +
                        $"D.iddeporte = P.iddeporte and Est.codestu = {codigo}";
                    command.CommandType = System.Data.CommandType.Text;
                    OracleDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        amp.HastItems = true;
                        amp.nombrePractica = "Practica";
                        amp.Espacio = new Espacio() { 
                            CodEspacio = reader["codespacio"].ToString(),
                            NomEspacio = reader["nomespacio"].ToString()
                        };
                        amp.Deporte = new Deporte() { 
                            IdDeporte = reader["iddeporte"].ToString(),
                            Nombre = reader["nomdeporte"].ToString()
                        };
                        amp.numEstudiantes = Convert.ToInt32(reader["noinscrito"].ToString());
                    }
                    else
                    {
                        amp.HastItems = false;
                    }
                }
            }


            string idSede = amp.Espacio.CodEspacio;
            string depid = amp.Deporte.IdDeporte;
            amp.ElementosDisp = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();
            //3.2.2.1. y  3.2.2.1.
            foreach (var item in _elementos.GetElementos(idSede, depid, new DateTime()))
            {
                amp.ElementosDisp.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem()
                {
                    Value = item.IDElementoD.ToString(),
                    Text = item.DescTipo
                });
                //ogger.LogError(item.IDElementoD.ToString());
            }
            return amp;
        }

    }
}
