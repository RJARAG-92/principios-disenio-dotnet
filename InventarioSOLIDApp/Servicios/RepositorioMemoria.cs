using InventarioSOLIDApp.Interfaces;
using InventarioSOLIDApp.Modelos;

namespace InventarioSOLIDApp.Servicios
{
    public class RepositorioMemoria : IProductoRepository
    {
        private readonly Dictionary<string, Producto> _db = new();

        public RepositorioMemoria()
        {
            // Carga inicial
            _db["P001"] = new Producto("P001", "Laptop Dell", 10);
            _db["P002"] = new Producto("P002", "Mouse Logitech", 25);
        }

        public Producto ObtenerPorId(string id) => _db[id];
        public void Actualizar(Producto producto) => _db[producto.Id] = producto;
    }
}
