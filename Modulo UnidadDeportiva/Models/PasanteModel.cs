using System.ComponentModel.DataAnnotations;

namespace Modulo_UnidadDeportiva.Models
{
    public class PasanteModel
    {
        public int CodgoPasante { get; set; }
        [Display(Name = "Nombre del pasante")]
        public string Nombre { get; set; }
        public string Periodo { get; set; }
        public string Sede { get; set; }
        [Display(Name = "Fecha / Hora registro")]
        public DateTime FechaHoraRegistro { get; set; }
    }
}
