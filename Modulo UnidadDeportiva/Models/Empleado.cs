using System.ComponentModel.DataAnnotations;

namespace Modulo_UnidadDeportiva.Models
{
    public class Empleado
    {
        public string Codigo { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public string Cargo { get; set; }    //Ultimo cargo
        public string Sede { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }
    }
}
