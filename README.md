Proyecto MisionTic 2021

Intranet Gestion de Produccion para la empresa Consecha Tropical - Colombia

Programado en Lenguaje C# usando los siguientes Framework

Backend
 - ORM Entity Framework Core 3
 - Base de Datos SqlServer

Frontend
- Razor Pages in ASP.NET Core

Data Complementaria

Comandos En la capa de Persistencia 

dotnet add package Microsoft.EntityFrameworkCore --version 5.0.4
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.4
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.4
dotnet add package Microsoft.EntityFrameworkCore.sqlServer --version 5.0.4

Comandos de relacionamiento de proyectos

dotnet add reference ..\Produccion.App.Domain

Capa consola

dotnet add reference ..\Produccion.App.Domain\
dotnet add reference ..\Produccion.App.Persistence\
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.10

dotnet ef migrations add initial --startup-project ..\Produccion.App.Console\
dotnet ef database update --startup-project ..\Produccion.App.Console\
dotnet ef migrations remove Inicial --startup-project ..\Produccion.App.Console\



