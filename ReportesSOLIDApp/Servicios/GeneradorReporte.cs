using ReportesSOLIDApp.Interfaces;

namespace ReportesSOLIDApp.Servicios
{
    public class GeneradorReporte
    {
        private readonly IRepositorioDatos _repositorio;
        private readonly IExportadorReporte _exportador;

        public GeneradorReporte(IRepositorioDatos repositorio, IExportadorReporte exportador)
        {
            _repositorio = repositorio;
            _exportador = exportador;
        }

        public void GenerarYExportar()
        {
            var reporte = _repositorio.ObtenerDatos();
            _exportador.Exportar(reporte);
        }
    }
}
