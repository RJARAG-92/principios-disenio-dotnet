namespace GestionTareasApp
{
    // Principio: KISS - Clase simple y enfocada
    public class Tarea
    {
        public string Titulo { get; set; }
        public string Responsable { get; set; }
        public bool EstaCompleta { get; private set; }

        public Tarea(string titulo, string responsable)
        {
            Titulo = titulo;
            Responsable = responsable;
            EstaCompleta = false;
        }

        public void Completar()
        {
            EstaCompleta = true;
        }
    }
}
