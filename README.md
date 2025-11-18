<p align="center">
  <img src="img/banner.png" width="800">
</p>

# 🚛 Sistema de Gestión de Viajes

Repositorio oficial del proyecto **Gestión de Viajes**, desarrollado en **C#**, **Windows Forms**, **ASP.NET Core Web API** y **SQL Server**.  
El objetivo del sistema es administrar viajes, pedidos, choferes, vehículos y sucursales de una empresa de transporte.

📌 **Repositorio:**  
https://github.com/JosemT03/GestionViajes.git

---

## 🧰 Tecnologías utilizadas

### 🖥️ Backend – Web API
- ASP.NET Core 7+
- Swagger (documentación de API)
- Entity Framework Core (Code First)
- AutoMapper (si se utiliza)
- Repositorios + Servicios
- Validaciones en controladores
- SQL Server (Base de Datos)

### 💻 Frontend – Windows Forms
- C# .NET
- Llamadas HTTP a la API
- Formularios para Roles: Administrador y Chofer
- Diseño estilo Material (bordes redondeados y UI moderna)

### 📦 Base de Datos
- SQL Server
- Migraciones con EF Core
- Tablas principales:
  - Usuarios
  - Choferes
  - Vehículos
  - Sucursales
  - Pedidos
  - Historial
  - Estadísticas

---

## 🔐 Roles del Sistema

### 👨‍💼 Administrador
El administrador puede:

- Gestionar usuarios  
- Gestionar choferes  
- Gestionar vehículos  
- Gestionar sucursales  
- Gestionar pedidos  
- Ver historial  
- Ver informes estadísticos  
- Cerrar sesión  

### 🚚 Chofer
El chofer puede:

- Ver sus pedidos asignados  
- Aceptar o rechazar viajes  
- Marcar viajes como completados  
- Ver datos del vehículo asignado  
- Consultar destino del viaje  

---

## 🧱 Arquitectura del Proyecto

El sistema está dividido en dos aplicaciones principales:

/GestionViajes.API
/Controllers
/Services
/Repositories
/Models
/DTOs
/Migrations
Program.cs
appsettings.json

/GestionViajes.Desktop
/Forms
/Models
/Services
Program.cs 

Patrones utilizados:

- Repository Pattern  
- Dependency Injection  
- DTO Mapping  
- Validaciones en backend + frontend  
- Arquitectura en capas  

---

👤 Autor

José Taboada
Desarrollador – Proyecto Gestión de Viajes
C# | .NET | SQL Server | Windows Forms | Web API
