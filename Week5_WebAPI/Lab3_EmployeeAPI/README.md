# Lab 3 - Employee Management API

## Objective

Build a RESTful Web API that performs CRUD operations on employee data using ASP.NET Core Web API.

---

## Technologies Used

- ASP.NET Core Web API
- Swagger (OpenAPI)
- C#
- .NET 8
- Visual Studio Code

---

## Project Structure

```
EmployeeManagementApi
│
├── Controllers
│   └── EmployeeController.cs
│
├── Models
│   └── Employee.cs
│
├── Program.cs
│
└── appsettings.json
```

---

## API Endpoints

### GET All Employees

```
GET /api/Employee
```

Returns all employees.

---

### GET Employee by Id

```
GET /api/Employee/{id}
```

Returns an employee using Employee ID.

---

### POST Employee

```
POST /api/Employee
```

Adds a new employee.

Example Request

```json
{
  "id": 4,
  "name": "Nazia",
  "department": "Cyber Security",
  "salary": 70000
}
```

---

### PUT Employee

```
PUT /api/Employee/{id}
```

Updates employee information.

---

### DELETE Employee

```
DELETE /api/Employee/{id}
```

Deletes an employee.

---

## Features

- REST API
- CRUD Operations
- Model Binding
- Attribute Routing
- Swagger Documentation
- HTTP Status Codes

---

## Learning Outcome

- Creating REST APIs
- CRUD Operations
- Routing
- Controllers
- Models
- Swagger Documentation
- Testing APIs