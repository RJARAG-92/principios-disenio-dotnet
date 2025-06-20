namespace FacturacionSOLIDApp.Validaciones
{
    // SRP: validación separada
    public class ValidadorFactura
    {
        public bool EsValido(decimal subtotal, decimal igv)
        {
            return subtotal >= 0 && igv >= 0;
        }
    }
}
