using InventarioSOLIDApp.Modelos;

namespace InventarioSOLIDApp.Interfaces
{
    public interface IProductoRepository
    {
        Producto ObtenerPorId(string id);
        void Actualizar(Producto producto);
    }
}
