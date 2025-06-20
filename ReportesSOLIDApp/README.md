# 📊 ReportesSOLIDApp

Este proyecto simula un sistema de generación de reportes aplicando los **principios SOLID** en un entorno empresarial. Forma parte de la solución `principios-disenio-dotnet`.

---

## 🎯 Objetivo

Aplicar los principios SOLID en un sistema que permite generar reportes en diferentes formatos y desde distintas fuentes de datos.

---

## 🧱 Principios SOLID aplicados

| Principio | Aplicación en el código |
|----------|--------------------------|
| **SRP (Responsabilidad Única)** | Separación entre las clases de generación (`GeneradorReporte`) y de exportación (`ExportadorPdf`, `ExportadorCsv`). |
| **OCP (Abierto/Cerrado)** | Se pueden agregar nuevos formatos de exportación sin modificar el generador. |
| **LSP (Sustitución de Liskov)** | Los exportadores derivados pueden sustituir a la clase base `IExportadorReporte` sin alterar la funcionalidad. |
| **ISP (Segregación de Interfaces)** | Interfaces separadas: `IExportadorReporte`, `IRepositorioDatos`. |
| **DIP (Inversión de Dependencias)** | El generador depende de interfaces para datos y exportación. |

---

## 🚀 Ejecución

```bash
dotnet run --project ReportesSOLIDApp
```

### Salida esperada

```
Reporte generado y exportado en formato PDF.
```

---

## 📂 Estructura del proyecto

```
ReportesSOLIDApp/
│
├── Interfaces/
│   ├── IExportadorReporte.cs
│   └── IRepositorioDatos.cs
│
├── Servicios/
│   ├── GeneradorReporte.cs
│   ├── ExportadorPdf.cs
│   ├── ExportadorCsv.cs
│   └── RepositorioMemoria.cs
│
├── Modelos/
│   └── Reporte.cs
│
├── Program.cs
└── README.md
```

--- 

## 👤 Autor

**Ricardo Jara Gaspar**  
Ingeniero de Software especializado en .NET y Arquitectura de Software  
[GitHub](https://github.com/RJARAG-92) · [LinkedIn](https://www.linkedin.com/in/ricardojarag) · 🇵🇪 Perú
