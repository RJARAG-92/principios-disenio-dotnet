using FacturacionSOLIDApp.Servicios;
using FacturacionSOLIDApp.Validaciones;

var calculadora = new CalculadoraFacturaConDescuento(descuento: 10);
var repositorio = new RepositorioFactura();
var validador = new ValidadorFactura();

var servicio = new ServicioFactura(calculadora, repositorio, validador);
servicio.Procesar(100, 18);