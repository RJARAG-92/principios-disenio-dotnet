using FacturacionSOLIDApp.Interfaces;

namespace FacturacionSOLIDApp.Servicios
{
    // ============================
    // Clases de implementación (SRP + OCP + LSP)
    // ============================
    // SRP: solo calcula el total
    public class CalculadoraFactura : ICalculadoraFactura
    {
        public virtual decimal CalcularTotal(decimal subtotal, decimal igv)
        {
            return subtotal + igv;
        }
    }
}
