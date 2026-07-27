# Lab 4 - CRUD Operations using Entity Framework Core

## Objective
Develop a RESTful Web API that performs CRUD (Create, Read, Update, Delete) operations using Entity Framework Core with SQL Server.

---

## Technologies Used

- ASP.NET Core Web API (.NET 10)
- Entity Framework Core
- SQL Server LocalDB
- Swagger
- Visual Studio Code

---

## Project Structure

```
EmployeeCrudApi
│
├── Controllers
│   └── EmployeeController.cs
│
├── Data
│   └── EmployeeDbContext.cs
│
├── Models
│   └── Employee.cs
│
├── Migrations
│
├── Program.cs
├── appsettings.json
└── EmployeeCrudApi.csproj
```

---

## Database

Database Name

EmployeeCrudDb

Table

Employees

Fields

- Id
- Name
- Department
- Salary

---

## API Endpoints

| Method | Endpoint | Description |
|---------|-----------|-------------|
| GET | /api/Employee | Get all employees |
| GET | /api/Employee/{id} | Get employee by ID |
| POST | /api/Employee | Add new employee |
| PUT | /api/Employee/{id} | Update employee |
| DELETE | /api/Employee/{id} | Delete employee |

---

## Features

- Entity Framework Core Code First
- SQL Server Integration
- CRUD Operations
- Dependency Injection
- Swagger Documentation
- Database Migrations

---

## Outcome

Successfully implemented a RESTful CRUD API using ASP.NET Core and Entity Framework Core with SQL Server backend.