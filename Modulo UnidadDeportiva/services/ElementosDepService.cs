using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.services
{
    public class ElementosDepService : IElementosDep
    {
        private readonly string _connectionString;
        public ElementosDepService(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("OracleDBConnection");
        }

        public List<IElementosDep> GetElementos(int SedeID, int DepID)
        {
            /* Se encarga de devolver los elementos Dep
             * 
             * 3.2.1.2. (Solo elementos)
             * 3.2.2.2. (Solo elementos)
             * */
            throw new NotImplementedException();    
        }

        public bool Prestar(List<Elemento> elementos, Empleado responsable)
        {
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
