namespace Modulo_UnidadDeportiva.Models
{
    public class Espacio
    {
        public string CodEspacio { get; set; }
        public string NomEspacio { get; set; }
        public int? EspacioPerteneceID { get; set; }  //ID del padre
        public int? TipoEspacioID { get; set; }

    }
}
