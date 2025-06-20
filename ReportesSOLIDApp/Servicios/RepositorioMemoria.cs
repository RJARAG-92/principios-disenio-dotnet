using ReportesSOLIDApp.Interfaces;
using ReportesSOLIDApp.Modelos;

namespace ReportesSOLIDApp.Servicios
{
    public class RepositorioMemoria : IRepositorioDatos
    {
        public Reporte ObtenerDatos()
        {
            return new Reporte { Titulo = "Ventas Q2", Contenido = "Total: $150,000" };
        }
    }
}
