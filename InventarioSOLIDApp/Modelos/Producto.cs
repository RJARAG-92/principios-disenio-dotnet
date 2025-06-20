namespace InventarioSOLIDApp.Modelos
{
    // Entidad
    public class Producto
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; private set; }

        public Producto(string id, string nombre, int stockInicial)
        {
            Id = id;
            Nombre = nombre;
            Stock = stockInicial;
        }

        public void AumentarStock(int cantidad) => Stock += cantidad;
        public void DisminuirStock(int cantidad)
        {
            if (cantidad > Stock) throw new InvalidOperationException("Stock insuficiente");
            Stock -= cantidad;
        }
    }
}
