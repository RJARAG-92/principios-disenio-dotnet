# GestionTareasApp

Este proyecto demuestra cómo aplicar los **principios complementarios de diseño de software** junto con POO en un escenario empresarial simple de gestión de tareas, utilizando .NET en C#.

---

## 🎯 Objetivo
Aplicar los siguientes principios:

- **KISS (Keep It Simple, Stupid)**: Código directo, sin complejidad innecesaria.
- **DRY (Don't Repeat Yourself)**: Evitar duplicación de lógica, como validaciones.
- **YAGNI (You Ain't Gonna Need It)**: No incluir funcionalidades no solicitadas.
- **SoC (Separation of Concerns)**: Separación entre lógica de dominio y presentación.
- **Alta Cohesión / Bajo Acoplamiento**: Clases con responsabilidades claras y mínimas dependencias.

---

## 🧱 Estructura del Código

- `Tarea`: Clase de dominio simple que representa una tarea. *(KISS)*
- `ServicioTarea`: Contiene la lógica de negocio para agregar y consultar tareas. *(DRY, SoC, Cohesión)*
- `Program`: Punto de entrada que simula una consola de control. *(YAGNI, SoC)*

---

## 🚀 Ejecución

```bash
dotnet run --project GestionTareasApp
```

---

## 👤 Autor

**Ricardo Jara Gaspar**  
Ingeniero de Software especializado en .NET y Arquitectura de Software  
[GitHub](https://github.com/RJARAG-92) · [LinkedIn](https://www.linkedin.com/in/ricardojarag) · 🇵🇪 Perú
