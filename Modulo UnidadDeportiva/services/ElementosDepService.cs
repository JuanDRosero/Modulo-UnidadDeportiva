using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;
using Oracle.ManagedDataAccess.Client;

namespace Modulo_UnidadDeportiva.services
{
    public class ElementosDepService : IElementosDep
    {
        private readonly string _connectionString;
        public ElementosDepService(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("OracleDBConnection2");
        }

        public List<Elemento> GetElementos(int SedeID, int DepID, DateTime fechaHora)
        {
            fechaHora = DateTime.Now;
            var lista = new List<Elemento>();
            using (OracleConnection con= new OracleConnection(_connectionString))
            {
                using (OracleCommand com = new OracleCommand())
                {
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "";
                    var reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Elemento()
                            {
                                IDElementoD = Convert.ToInt32(reader["cod"]),
                                DescTipo = reader["desc"].ToString(),
                                EstadoDesc = reader["estadoDes"].ToString(),
                                Marca = reader["marcaDesc"].ToString(),
                                Deporte = reader["deporte"].ToString()
                            }); ;
                        }
                    }
                }
            }
            /* Se encarga de devolver los elementos Dep
             * 
             * 3.2.1.2. (Solo elementos)
             * 3.2.2.2. (Solo elementos)
             * */
            return lista;
        }

        public bool Prestar(List<int> elementos, int responsableID)
        {
            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                using (OracleCommand command = new OracleCommand())
                {
                    con.Open();
                    command.Connection = con;
                    foreach (var item in elementos)
                    {
                        command.CommandText = "aca va consulta con los ids";
                        command.ExecuteNonQuery();
                    }
                }
            }

                //HACE FLATA RETORNAR BOOL SI TODO ESTA BIEN Y FALSE Y ALGO FALLÓ
            /*
             * Esta interfaz se encargará de realizar el prestamo del material 
             * 
             * 3.2.1.4.
             * 3.2.1.5.
             * 3.2.2.4.
             * 3.2.2.5.
             */
            throw new NotImplementedException();   
        }
    }
}
