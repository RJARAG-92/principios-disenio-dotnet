using InventarioSOLIDApp.Interfaces;
using InventarioSOLIDApp.Servicios;

IProductoRepository repositorio = new RepositorioMemoria();
IGestorStock gestor = new GestorStock(repositorio);

gestor.RegistrarEntrada("P001", 5);
gestor.RegistrarSalida("P001", 3);