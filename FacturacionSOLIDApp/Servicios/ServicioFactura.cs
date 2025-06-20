using FacturacionSOLIDApp.Interfaces;
using FacturacionSOLIDApp.Validaciones;

namespace FacturacionSOLIDApp.Servicios
{
    // DIP: depende de abstracciones, no de clases concretas
    public class ServicioFactura
    {
        private readonly ICalculadoraFactura _calculadora;
        private readonly IRepositorioFactura _repositorio;
        private readonly ValidadorFactura _validador;

        public ServicioFactura(ICalculadoraFactura calculadora, IRepositorioFactura repositorio, ValidadorFactura validador)
        {
            _calculadora = calculadora;
            _repositorio = repositorio;
            _validador = validador;
        }

        public void Procesar(decimal subtotal, decimal igv)
        {
            if (!_validador.EsValido(subtotal, igv))
            {
                Console.WriteLine("Datos inválidos para la factura.");
                return;
            }

            var total = _calculadora.CalcularTotal(subtotal, igv);
            _repositorio.Guardar(total);
        }
    }
}
