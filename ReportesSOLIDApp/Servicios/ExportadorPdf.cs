using ReportesSOLIDApp.Interfaces;
using ReportesSOLIDApp.Modelos;

namespace ReportesSOLIDApp.Servicios
{
    public class ExportadorPdf : IExportadorReporte
    {
        public void Exportar(Reporte reporte)
        {
            Console.WriteLine($"[PDF] {reporte.Titulo}: {reporte.Contenido}");
        }
    }
}
