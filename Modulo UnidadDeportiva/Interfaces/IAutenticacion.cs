using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.Interfaces
{
    public interface IAutenticacion
    {
        public Empleado IngresarAuxiliar(string codigo);
        public Empleado IngresarDirector(string codigo);
    }
}
