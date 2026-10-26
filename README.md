# ContactManager

**A lightweight contact management application built with ASP.NET Core MVC, Entity Framework Core and SQL Server.**

ContactManager is a small web application designed to manage personal and business contacts through a clean, responsive interface.

The project focuses on implementing essential ASP.NET Core MVC concepts, database operations, server-side validation and data integrity.

![.NET 10](https://img.shields.io/badge/.NET-10-512BD4?logo=dotnet&logoColor=white)
![C%23](https://img.shields.io/badge/C%23-Programming-239120)
![EF Core](https://img.shields.io/badge/EF_Core-ORM-512BD4)
![SQL Server](https://img.shields.io/badge/SQL_Server-Database-CC2927)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5-7952B3?logo=bootstrap&logoColor=white)

---

## Features

- **Contact management** — Create, view, update and delete contacts.
- **Advanced search** — Filter contacts by first name, last name, email, phone number or company.
- **Email validation** — Validate email addresses and prevent duplicates during creation and editing.
- **Database integrity** — Enforce email uniqueness through an EF Core unique index.
- **Responsive interface** — User-friendly pages built with Razor Views and Bootstrap.
- **Database migrations** — Manage database schema changes using EF Core migrations.

## Screenshots

Application screenshots will be added here.

## Tech Stack

| Technology | Purpose |
|---|---|
| C# / .NET 10 | Application development |
| ASP.NET Core MVC | Web framework |
| Entity Framework Core | Database access and migrations |
| SQL Server LocalDB | Local development database |
| Razor Views | Server-rendered user interface |
| Bootstrap | Responsive UI styling |
| LINQ | Database querying and filtering |

## Project Structure

The application follows the standard ASP.NET Core MVC structure.

- **Controllers** — Handle HTTP requests and application flow.
- **Models** — Define application entities and validation attributes.
- **Views** — Render pages using Razor.
- **Data** — Configure EF Core and database access.
- **Migrations** — Track database schema changes.
- **wwwroot** — Store static assets such as CSS and JavaScript.

## Getting Started

### Prerequisites

- .NET 10 SDK
- SQL Server LocalDB
- Visual Studio with ASP.NET Core development support

### Installation

1. Clone the repository.
2. Open the project in Visual Studio.
3. Configure the `DefaultConnection` connection string in `appsettings.json` for your local SQL Server instance.
4. Open the Package Manager Console.
5. Apply the database migrations:

   `Update-Database`

6. Run the application using Visual Studio.

Alternatively, from the directory containing the project `.csproj` file:

`dotnet run`

## Key Learning Outcomes

This project demonstrates practical experience with:

- ASP.NET Core MVC routing, controllers and Razor Views.
- Dependency Injection and DbContext configuration.
- Entity Framework Core CRUD operations.
- Asynchronous LINQ queries.
- Model validation and application-level business rules.
- Unique database indexes and EF Core migrations.
- Responsive interface development using Bootstrap.

## Project Scope

ContactManager is a learning and portfolio project focused on MVC fundamentals and relational data management. It is not intended to be a complete production CRM.

---

Built as part of a practical C# and ASP.NET Core development journey.