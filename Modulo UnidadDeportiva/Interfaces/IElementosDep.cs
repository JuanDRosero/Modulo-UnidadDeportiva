using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.Interfaces
{
    public interface IElementosDep
    {
        public List<IElementosDep> GetElementos( int SedeID, int DepID);
        public bool Prestar(List<int> elementos, int responsableID);  //Elemento no es un mapeo literal de la tabla.. (REVISAR)
    }
}
