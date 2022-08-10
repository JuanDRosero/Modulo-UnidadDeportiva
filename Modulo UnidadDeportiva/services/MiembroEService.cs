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
            int iditem = 0;
            int programacion = 0;
            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                using (OracleCommand command = new OracleCommand())
                {
                    con.Open();
                    command.Connection= con;
                    command.CommandText= $"select ME.itemmiembro item, PE.consecprogra program from (select P.* from programacion P where idactividad= 'en') PE, deporte D, equipo E, miembroequipo ME, estudiante E "+
                                         $"where PE.iddeporte = D.iddeporte and E.iddeporte = D.iddeporte and E.conseequipo = ME.conseequipo and ME.conseequipo= '{equipo}' and ME.codestu='{codigoEstudiante}' and "+ 
	                                     $"PE.iddia=(select case when to_char(sysdate-1,'day') like '%lun%' then 'l' when to_char(sysdate-1,'day')"+
                                         $"like '%mart%' then 'm' when to_char(sysdate-1,'day') like '%mi%' then 'w' when to_char(sysdate-1,'day') like '%jue%' then 'j' when to_char(sysdate-1,'day')"+
                                         $"like '%vie%' then 'v' end Dia from dual)";
                    OracleDataReader reader = command.ExecuteReader();
                    IsPractica = reader.HasRows;
                    if (IsPractica)
                    {
                        reader.Read();
                        iditem = Convert.ToInt32(reader["item"]);
                        programacion = Convert.ToInt32(reader["program"]);
                    }
                }
            }
            if (IsPractica)
            {
                int random = new Random().Next(1,1000);
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    using (OracleCommand comand = new OracleCommand())
                    {
                        con.Open();
                        comand.Connection = con;
                        comand.CommandText = $"insert into asismiembroequipo (conmiemequipo, itemmiembro, " +
                            $"conseequipo, consecprogra) values ({random}, {iditem}, {equipo}, '{programacion}')";
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
