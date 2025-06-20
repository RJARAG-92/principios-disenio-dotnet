namespace GestionTareasApp
{
    // Principio: Separation of Concerns + Alta cohesión
    public class ServicioTarea
    {
        private readonly List<Tarea> _tareas = new();

        // Principio: DRY - Centralizamos la validación en un solo método
        public void AgregarTarea(string titulo, string responsable)
        {
            if (string.IsNullOrWhiteSpace(titulo))
                throw new ArgumentException("El título no puede estar vacío");

            if (string.IsNullOrWhiteSpace(responsable))
                throw new ArgumentException("El responsable no puede estar vacío");

            var nuevaTarea = new Tarea(titulo, responsable);
            _tareas.Add(nuevaTarea);
        }

        public IEnumerable<Tarea> ObtenerTareasPendientes()
        {
            return _tareas.Where(t => !t.EstaCompleta);
        }

        public IEnumerable<Tarea> ObtenerTareasCompletadas()
        {
            return _tareas.Where(t => t.EstaCompleta);
        }
    }
}
