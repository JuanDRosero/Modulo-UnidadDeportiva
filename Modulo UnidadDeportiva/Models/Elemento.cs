namespace Modulo_UnidadDeportiva.Models
{
    public class Elemento
    {
        public int IDElementoD { get; set; }        //ID tabla ElementoDeportivo
        public string DescTipo { get; set; }           //Desc tabla tipoElemento
        public string EstadoDesc { get; set; }          //Tabla estado
        public string Marca { get; set; }           //Marca Elemento
        public string Deporte { get; set; }
    }
}
