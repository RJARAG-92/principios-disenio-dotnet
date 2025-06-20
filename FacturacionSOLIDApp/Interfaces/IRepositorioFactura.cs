using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionSOLIDApp.Interfaces
{
    // ============================
    // Interfaces (ISP + DIP)
    // ============================
    public interface IRepositorioFactura
    {
        void Guardar(decimal total);
    }
}
