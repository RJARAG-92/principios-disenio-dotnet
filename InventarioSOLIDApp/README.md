# 📦 InventarioSOLIDApp

Este proyecto simula un sistema de gestión de inventario aplicando los **principios SOLID** en un entorno empresarial. Forma parte de la solución `principios-disenio-dotnet`.

---

## 🎯 Objetivo

Demostrar cómo aplicar los principios SOLID en un sistema que gestiona entradas y salidas de stock de productos.

---

## 🧱 Principios SOLID aplicados

| Principio | Aplicación en el código |
|----------|--------------------------|
| **SRP (Responsabilidad Única)** | Separación entre la lógica de negocio (`GestorStock`) y acceso a datos (`RepositorioMemoria`). |
| **OCP (Abierto/Cerrado)** | Posibilidad de extender `IGestorStock` o `IProductoRepository` sin modificar las clases existentes. |
| **LSP (Sustitución de Liskov)** | `RepositorioMemoria` puede ser sustituido por otro repositorio que implemente `IProductoRepository`. |
| **ISP (Segregación de Interfaces)** | Interfaces específicas y coherentes: `IProductoRepository` y `IGestorStock`. |
| **DIP (Inversión de Dependencias)** | `GestorStock` depende de abstracciones, no de clases concretas. |

---

## 🚀 Ejecución

```bash
dotnet run --project InventarioSOLIDApp
```

### Salida esperada

```
Entrada registrada: Laptop Dell +5 unidades.
Salida registrada: Laptop Dell -3 unidades.
```

---

## 📂 Estructura del proyecto

```
InventarioSOLIDApp/
│
├── Interfaces/
│   ├── IProductoRepository.cs
│   └── IGestorStock.cs
│
├── Servicios/
│   ├── GestorStock.cs
│   └── RepositorioMemoria.cs
│
├── Modelos/
│   └── Producto.cs
│
├── Program.cs
└── README.md
```

---

## 👤 Autor

**Ricardo Jara Gaspar**  
Ingeniero de Software especializado en .NET y Arquitectura de Software  
[GitHub](https://github.com/RJARAG-92) · [LinkedIn](https://www.linkedin.com/in/ricardojarag) · 🇵🇪 Perú