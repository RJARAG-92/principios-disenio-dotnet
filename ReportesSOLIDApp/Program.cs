using ReportesSOLIDApp.Interfaces;
using ReportesSOLIDApp.Servicios;

IRepositorioDatos repositorio = new RepositorioMemoria();
IExportadorReporte exportador = new ExportadorPdf(); // Puedes cambiar a ExportadorCsv

var generador = new GeneradorReporte(repositorio, exportador);
generador.GenerarYExportar();