using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;
using Oracle.ManagedDataAccess.Client;

namespace Modulo_UnidadDeportiva.services
{
    public class ReportesService : IReportes
    {
        private readonly string _connectionString;

        public ReportesService(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("OracleDBConnection");
            
        }

        public List<EquipoModel> GetEquipos()
        {
            throw new NotImplementedException();
        }

        public List<PasanteModel> getPasantes()
        {
            var lista = new List<PasanteModel>();
            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                using (OracleCommand command = new OracleCommand())
                {
                    con.Open();
                    command.Connection = con;
                    command.BindByName = true;
                    command.CommandText = "select E.codestu, E.nomestu ||' '|| E.apelestu nombre, " +
                        "Esp.nomespacio, p.idperiodo, Asis.fechaAsisRes from  estudiante E, " +
                        "responsable R, espacio Esp, asistirresponsable Asis, programacion P " +
                        "where Asis.consecres = R.consecres and E.codestu = R.codestu and " +
                        "R.consecprogra = p.consecprogra and p.codespacio = Esp.codespacio";
                    command.CommandType = System.Data.CommandType.Text;
                    OracleDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        lista.Add(new PasanteModel()
                        {
                            Nombre = reader["nombre"].ToString(),
                            CodgoPasante = reader["codestu"].ToString(),
                            Periodo = reader["idperiodo"].ToString(),
                            Sede = reader["nomespacio"].ToString(),
                            FechaHoraRegistro = Convert.ToDateTime(reader["fechaAsisRes"])

                        });
                    }
                }
            }

            return lista;

        }
    }
}
