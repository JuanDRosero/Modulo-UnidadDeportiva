using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;
using Oracle.ManagedDataAccess.Client;

namespace Modulo_UnidadDeportiva.services
{
    public class AutenticacionService : IAutenticacion
    {
        private readonly string _connectionString;
        public AutenticacionService(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("OracleDBConnection2");
        }

        public Empleado IngresarAuxiliar(string codigo)
        {
            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                using (OracleCommand command = new OracleCommand())
                {
                    con.Open();
                    command.Connection = con;
                    command.CommandText = $"select E.codempleado, E.nomempleado, E.apellempleado, C.descargo cargo, " +
                        "E.nomespacio sede from empleado E, empleado_cargo EC, espacio E, cargo C where EC.codempleado = E.codempleado " +
                        $"and EC.codempleado={codigo} and EC.idcargo=C.idcargo and EC.idcargo='1' and " +
                        "EC.codespacio=E.codespacio";
                    command.CommandType = System.Data.CommandType.Text;
                    OracleDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        var empleado = new Empleado();
                        while (reader.Read())
                        {
                            empleado.Codigo = reader["codempleado"].ToString();
                            empleado.NombreEmpleado = reader["nomempleado"].ToString();
                            empleado.ApellidoEmpleado = reader["apellempleado"].ToString();
                            empleado.Cargo = reader["cargo"].ToString();
                            empleado.Sede = reader["sede"].ToString();
                            empleado.FechaInicio = new DateTime(); // Que fecha usar???????????
                        }
                        return empleado;
                    }
                    else {
                        return null;
                    }
                }
            }
        }

        public Empleado IngresarDirector(string codigo)    //Buscar en Directores
        {
            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                using (OracleCommand command = new OracleCommand())
                {
                    con.Open();
                    command.Connection = con;
                    command.CommandText = "select E.codempleado, E.nomempleado, E.apellempleado, C.descargo cargo, " +
                        "E.nomespacio sede from empleado E, empleado_cargo EC, espacio E, cargo C where EC.codempleado = E.codempleado " +
                        "and EC.codempleado='"+codigo+"' and EC.idcargo=C.idcargo and EC.idcargo='3' and " +
                        "EC.codespacio=E.codespacio";
                    command.CommandType = System.Data.CommandType.Text;
                    OracleDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        var empleado = new Empleado();
                        while (reader.Read())
                        {
                            empleado.Codigo = reader["codempleado"].ToString();
                            empleado.NombreEmpleado = reader["nomempleado"].ToString();
                            empleado.ApellidoEmpleado = reader["apellempleado"].ToString();
                            empleado.Cargo = reader["cargo"].ToString();
                            empleado.Sede = reader["sede"].ToString();
                            empleado.FechaInicio = new DateTime(); // Que fecha usar???????????
                        }
                        return empleado;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
    }
}
