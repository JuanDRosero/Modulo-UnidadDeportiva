using System.ComponentModel.DataAnnotations;

namespace Modulo_UnidadDeportiva.Models
{
    public class EquipoModel
    {
        [Display(Name = "Nombre del equipo")]
        public string  NombreEquipo{ get; set; }
        public string Miembro { get; set; }
        public string Periodo { get; set; }
        public string Sede { get; set; }
        [Display(Name ="Fecha / Hora registro")]
        public DateTime FechaHoraRegistro{ get; set; }
    }
}
