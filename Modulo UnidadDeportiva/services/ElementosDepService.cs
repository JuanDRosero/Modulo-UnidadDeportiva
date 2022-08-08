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
            _connectionString = config.GetConnectionString("OracleDBConnection");
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
                    com.CommandText = "select TE.desctipoelemento TIPO, E.descestado ESTADO, ES.nomespacio SEDE, D.nomDeporte DEPORTE, M.nommarca MARCA " +
                        "from elemendeportivo EL, tipoelemento TE, estado E, espacio ES, deporte D, relationship_12 D_TE, marca M " +
                        "where EL.idtipoelemento = TE.idtipoelemento and E.idestado = EL.idestado and D.iddeporte = D_TE.iddeporte " +
                        $"and TE.idtipoelemento = D_TE.idtipoelemento and ES.codespacio = EL.codespacio and EL.codespacio= '{SedeID}' and D_TE.iddeporte='{DepID}'" +
                        "and M.idmarca = EL.idmarca and EL.idestado = 1";
                    var reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Elemento()
                            {
                                IDElementoD = Convert.ToInt32(reader["idtipoelemento"]),
                                DescTipo = reader["desctipoelemento"].ToString(),
                                EstadoDesc = reader["descestado"].ToString(),
                                Marca = reader["marcadesc"].ToString(),
                                Deporte = reader["nomdeporte"].ToString()
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
