namespace InventarioSOLIDApp.Interfaces
{
    public interface IGestorStock
    {
        void RegistrarEntrada(string productoId, int cantidad);
        void RegistrarSalida(string productoId, int cantidad);
    }
}
