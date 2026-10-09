# Student Management System

This is an ASP.NET Core MVC web application created to manage student records. It demonstrates full database operations using the Entity Framework Core Code-First approach.

## Core Technologies
- **Backend Framework:** C# and ASP.NET Core MVC (.NET 8.0 / 6.0)
- **Database ORM:** Entity Framework Core (EF Core)
- **Database Engine:** SQL Server Database

## Core Backend Features
- **Full CRUD Logic:** Implementation of Create, Read, Update, and Delete operations for Student entity.
- **Automated Database Creation:** Database schema created and updated automatically using C# Code-First Migrations (`Add-Migration` & `Update-Database`).
- **Dependency Injection:** Configured `ApplicationDbContext` within `Program.cs` for safe database connection lifecycle management.

## Setup Instructions
1. Open the project in Visual Studio 2022.
2. Update the connection string in appsettings.json.
3. Open Package Manager Console and run 'Update-Database'.
4. Run the project (F5).
