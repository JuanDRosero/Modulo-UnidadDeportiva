using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;
using Oracle.ManagedDataAccess.Client;

namespace Modulo_UnidadDeportiva.services
{
    public class MiembroEService : IMiembroE
    {
        private readonly string _connectionString;

        public MiembroEService(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("OracleDBConnection");
        }

        public AsistenciaMiembroModel GetAsistenciaMiembro(string codigoEstudiante, int equipo)
        {
            bool IsPractica = false;
            bool IsCorrecto = false;
            using (OracleConnection con = new OracleConnection())
            {
                using (OracleCommand command = new OracleCommand())
                {
                    con.Open();
                    command.Connection= con;
                    command.CommandText= "select * from (select P.* from programacion P where idactividad= 'en') PE, deporte D, equipo E, miebroequipo ME, estudiante E"+
                                        $"where PE.iddeporte = D.iddeporte and E.iddeporte = D.iddeporte and E.conseequipo = ME.conseequipo and ME.conseequipo= {equipo} and ME.codestu='{codigoEstudiante}' and"+ 
	                                        "PE.iddia=(select to_char(sysdate, 'day') Fecha, case when to_char(sysdate,'day') like '%lun%' then 'l' when to_char(sysdate,'day')"+
                                         "like '%mart%' then 'm' when to_char(sysdate,'day') like '%mi%' then 'w' when to_char(sysdate,'day') like '%jue%' then 'j' when to_char(sysdate,'day')"+
                                         "like '%vie%' then 'v' end Dia from dual)";
                    OracleDataReader reader = command.ExecuteReader();
                    IsPractica = reader.HasRows;
                }
            }
            if (IsPractica)
            {
                using (OracleConnection con = new OracleConnection())
                {
                    using (OracleCommand comand = new OracleCommand())
                    {
                        con.Open();
                        comand.Connection= con;
                        comand.CommandText = "aca va el comando";
                        comand.ExecuteNonQuery();
                        IsCorrecto = true;
                    }
                }
            }
            return new AsistenciaMiembroModel()
            {
                IsCompleted = IsCorrecto
            };
        }
    }
}
