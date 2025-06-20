# 🏗️ Principios de Diseño en .NET (SOLID + Complementarios)

Este repositorio presenta una colección de ejemplos empresariales desarrollados en C# con .NET, aplicando tanto los principios **SOLID** como los **principios de diseño complementarios**. Cada conjunto de principios se aplica en proyectos independientes dentro de una solución organizada.

---

## 🎯 Objetivo

Demostrar cómo aplicar buenas prácticas de diseño en la construcción de software mantenible, extensible y desacoplado, usando ejemplos claros y aplicables a contextos reales.

---

## 📁 Estructura de la solución

```
principios-disenio-dotnet/
│
├── 1.PrincipiosSOLID/
│   ├── FacturacionSOLIDApp/      # Aplicación de SOLID en facturación
│   ├── InventarioSOLIDApp/       # Aplicación de SOLID en gestión de inventario
│   └── ReportesSOLIDApp/         # Aplicación de SOLID en generación de reportes
│
├── 2.PrincipiosComplementarios/
│   └── GestionTareasApp/         # Aplicación de DRY, KISS, YAGNI, SoC y Cohesión
│
└── principios-disenio-dotnet.sln
```

---

## 🧱 Principios aplicados

### 🔷 Principios SOLID (1.PrincipiosSOLID)
- **S**: Responsabilidad Única
- **O**: Abierto/Cerrado
- **L**: Sustitución de Liskov
- **I**: Segregación de Interfaces
- **D**: Inversión de Dependencias

### 🔶 Principios de Diseño Complementarios (2.PrincipiosComplementarios)
- **DRY** (Don't Repeat Yourself)
- **KISS** (Keep It Simple, Stupid)
- **YAGNI** (You Ain’t Gonna Need It)
- **Separation of Concerns (SoC)**
- **Alta cohesión / Bajo acoplamiento**

---

## ✅ Ejecución
Puedes ejecutar cualquier proyecto con el siguiente comando:

```bash
dotnet run --project <nombre_del_proyecto>
```
Ejemplo:
```bash
dotnet run --project 2.PrincipiosComplementarios/GestionTareasApp

---

## 👤 Autor
**Ricardo Jara Gaspar**  
Ingeniero de Software especializado en .NET y Arquitectura de Software  
🔗 [GitHub](https://github.com/RJARAG-92) · [LinkedIn](https://www.linkedin.com/in/ricardojarag) · 🇵🇪 Perú
