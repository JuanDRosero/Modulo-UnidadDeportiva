using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.Interfaces
{
    public interface IAutenticacion
    {
        public Empleado IngresarAuxiliar(int codigo);
        public Empleado IngresarDirector(int codigo);
    }
}
