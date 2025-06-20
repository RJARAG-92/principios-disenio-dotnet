using FacturacionSOLIDApp.Interfaces;

namespace FacturacionSOLIDApp.Servicios
{
    // SRP: solo guarda información
    public class RepositorioFactura : IRepositorioFactura
    {
        public void Guardar(decimal total)
        {
            Console.WriteLine($"Factura guardada con total: {total:C}");
        }
    }
}
