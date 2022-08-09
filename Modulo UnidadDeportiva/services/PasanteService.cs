using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.services
{
    public class PasanteService : IPasante
    {
        private readonly string _connectionString;
        private readonly IElementosDep _elementos;

        public PasanteService(IConfiguration config, IElementosDep elementos)
        {
            _connectionString = config.GetConnectionString("OracleDBConnection");
            _elementos = elementos;
        }

        public AsistenciaPasanteModel GetAsistenciaPasante(int codigo)
        {
            string idSede = "";
            string depid = "";
            var aPM = new AsistenciaPasanteModel();
            //3.2.2.1. y  3.2.2.1.
            foreach (var item in _elementos.GetElementos(idSede, depid, new DateTime()))
            {
                aPM.ElementosDisp.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem()
                {
                    Value = item.IDElementoD.ToString(),
                    Text = item.DescTipo
                });
            }
            return aPM;
        }

    }
}
