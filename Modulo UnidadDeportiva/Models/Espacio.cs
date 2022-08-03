namespace Modulo_UnidadDeportiva.Models
{
    public class Espacio
    {
        public string CodEspacio { get; set; }
        public string NomEspacio { get; set; }
        public int? EspacioPertenece { get; set; }  //ID del padre

    }
}
