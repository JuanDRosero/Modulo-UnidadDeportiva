using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.Interfaces
{
    public interface IReportes
    {
        public void GenerarReportePasantes();
        public void GenerarReporteMiembros();
        public List<EquipoModel> GetEquipos();
        public List<PasanteModel> getPasantes();

        
    }
}
