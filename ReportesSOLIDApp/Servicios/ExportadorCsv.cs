using ReportesSOLIDApp.Interfaces;
using ReportesSOLIDApp.Modelos;

namespace ReportesSOLIDApp.Servicios
{
    public class ExportadorCsv : IExportadorReporte
    {
        public void Exportar(Reporte reporte)
        {
            Console.WriteLine($"[CSV] \"{reporte.Titulo}\",\"{reporte.Contenido}\"");
        }
    }
}
