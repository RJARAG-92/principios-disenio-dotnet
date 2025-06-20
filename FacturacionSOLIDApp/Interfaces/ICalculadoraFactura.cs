namespace FacturacionSOLIDApp.Interfaces
{
    // ============================
    // Interfaces (ISP + DIP)
    // ============================
    public interface ICalculadoraFactura
    {
        decimal CalcularTotal(decimal subtotal, decimal igv);
    }
}
