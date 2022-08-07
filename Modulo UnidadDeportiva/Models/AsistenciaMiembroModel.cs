namespace Modulo_UnidadDeportiva.Models
{
    public class AsistenciaMiembroModel
    {
        #region PropiedadesBusqueda
        public string Codigo { get; set; }
        public int EquipoID { get; set; }
        #endregion

        public bool IsCompleted { get; set; } = false;  //si se inserta correctamente es true   
    }
}
