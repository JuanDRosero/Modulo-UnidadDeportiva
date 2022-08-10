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

        public List<Elemento> GetElementos(string SedeID, string DepID, DateTime fechaHora)
        {
            fechaHora = DateTime.Now;
            var lista = new List<Elemento>();
            using (OracleConnection con= new OracleConnection(_connectionString))
            {
                using (OracleCommand com = new OracleCommand())
                {
                    con.Open();
                    com.Connection = con;
                    com.CommandText = $"select TE.idtipoelemento idtipoelemento," +
                        $" TE.desctipoelemento TIPO, E.descestado ESTADO, ES.nomespacio SEDE, M.nommarca marca, " +
                        $"D.nomDeporte DEPORTE from elemendeportivo EL, tipoelemento TE, estado E, espacio ES, " +
                        $"deporte D, relationship_12 D_TE, marca M where EL.idtipoelemento = TE.idtipoelemento and " +
                        $"E.idestado = EL.idestado and D.iddeporte = D_TE.iddeporte and " +
                        $"TE.idtipoelemento = D_TE.idtipoelemento " +
                        $"and ES.codespacio = EL.codespacio and M.idmarca = EL.idmarca and EL.idestado = 1";
                    var reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Elemento()
                            {
                                IDElementoD = Convert.ToInt32(reader["idtipoelemento"]),
                                DescTipo = reader["TIPO"].ToString(),
                                EstadoDesc = reader["ESTADO"].ToString(),
                                Marca = reader["marca"].ToString(),
                                Deporte = reader["DEPORTE"].ToString()
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
                        command.CommandText = $"update elemendeportivo set idestado = '2' where " +
                            $"consecelemento='{item}'";
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
            return true;   
        }
    }
}
