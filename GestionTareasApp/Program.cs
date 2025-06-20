// Principio: SoC - Controlador separado del dominio
using GestionTareasApp;

var servicio = new ServicioTarea();

// Principio: YAGNI - No implementamos lógica no requerida como eliminación
servicio.AgregarTarea("Enviar informe semanal", "Laura");
servicio.AgregarTarea("Actualizar dashboard", "Pedro");

Console.WriteLine("Tareas pendientes:");
foreach (var tarea in servicio.ObtenerTareasPendientes())
{
    Console.WriteLine("- " + tarea.Titulo);
}

Console.WriteLine("\nMarcando una tarea como completada...");
var tareaACompletar = servicio.ObtenerTareasPendientes().First();
tareaACompletar.Completar();

Console.WriteLine("\nTareas completadas:");
foreach (var tarea in servicio.ObtenerTareasCompletadas())
{
    Console.WriteLine("- " + tarea.Titulo);
}