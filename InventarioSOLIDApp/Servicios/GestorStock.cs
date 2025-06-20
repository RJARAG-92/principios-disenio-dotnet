using InventarioSOLIDApp.Interfaces;

namespace InventarioSOLIDApp.Servicios
{
    public class GestorStock : IGestorStock
    {
        private readonly IProductoRepository _repositorio;

        public GestorStock(IProductoRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public void RegistrarEntrada(string productoId, int cantidad)
        {
            var producto = _repositorio.ObtenerPorId(productoId);
            producto.AumentarStock(cantidad);
            _repositorio.Actualizar(producto);
            Console.WriteLine($"Entrada registrada: {producto.Nombre} +{cantidad} unidades.");
        }

        public void RegistrarSalida(string productoId, int cantidad)
        {
            var producto = _repositorio.ObtenerPorId(productoId);
            producto.DisminuirStock(cantidad);
            _repositorio.Actualizar(producto);
            Console.WriteLine($"Salida registrada: {producto.Nombre} -{cantidad} unidades.");
        }
    }
}
