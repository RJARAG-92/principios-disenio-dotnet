namespace FacturacionSOLIDApp.Servicios
{
    // OCP: extensión con lógica adicional sin modificar la clase base
    public class CalculadoraFacturaConDescuento : CalculadoraFactura
    {
        private readonly decimal descuento;

        public CalculadoraFacturaConDescuento(decimal descuento)
        {
            this.descuento = descuento;
        }

        public override decimal CalcularTotal(decimal subtotal, decimal igv)
        {
            var totalBase = base.CalcularTotal(subtotal, igv);
            return totalBase - descuento;
        }
    }
}
