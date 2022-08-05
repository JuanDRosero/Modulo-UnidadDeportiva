﻿using Modulo_UnidadDeportiva.Interfaces;

namespace Modulo_UnidadDeportiva.services
{
    public class ReportesService : IReportes
    {
        private readonly string _connectionString;

        public ReportesService(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("OracleDBConnection");
        }

        public void GenerarReporteMiembros()
        {
            throw new NotImplementedException();
        }

        public void GenerarReportePasantes()
        {
            throw new NotImplementedException();
        }
    }
}
