# 💼 FacturacionSOLIDApp

Este proyecto simula un sistema de facturación utilizando los **principios SOLID** en un contexto empresarial. Forma parte de la solución `principios-disenio-dotnet`.

---

## 🎯 Objetivo

Aplicar y demostrar los 5 principios SOLID en un sistema que realiza cálculos, validaciones y persistencia de facturas.

---

## 🧱 Principios SOLID aplicados

| Principio | Aplicación en el código |
|----------|--------------------------|
| **SRP (Responsabilidad Única)** | Separación de responsabilidades entre `CalculadoraFactura`, `RepositorioFactura`, `ValidadorFactura`. |
| **OCP (Abierto/Cerrado)** | `CalculadoraFacturaConDescuento` extiende la lógica sin modificar la clase base. |
| **LSP (Sustitución de Liskov)** | `CalculadoraFacturaConDescuento` se puede usar donde se espera una `CalculadoraFactura`. |
| **ISP (Segregación de Interfaces)** | Interfaces `ICalculadoraFactura` e `IRepositorioFactura` definen contratos específicos. |
| **DIP (Inversión de Dependencias)** | `ServicioFactura` depende de interfaces, no de implementaciones concretas. |

---

## 🚀 Ejecución

```bash
dotnet run --project FacturacionSOLIDApp
```

### Salida esperada

```
Factura guardada con total: S/108.00
```

(Se aplica un descuento de S/10 sobre un total de S/118)

---

## 📂 Estructura del proyecto

```
FacturacionSOLIDApp/
│
├── Interfaces/
│   ├── ICalculadoraFactura.cs
│   └── IRepositorioFactura.cs
│
├── Servicios/
│   ├── ServicioFactura.cs
│   ├── CalculadoraFactura.cs
│   ├── CalculadoraFacturaConDescuento.cs
│   ├── RepositorioFactura.cs
│   └── ValidadorFactura.cs
│
├── Program.cs
└── README.md
```

---

## 👤 Autor

**Ricardo Jara Gaspar**  
Ingeniero de Software especializado en .NET y Arquitectura de Software  
[GitHub](https://github.com/RJARAG-92) · [LinkedIn](https://www.linkedin.com/in/ricardo-jara-gaspar-b7a515265/) · 🇵🇪 Perú
