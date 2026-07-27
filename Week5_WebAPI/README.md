# Week 5 - ASP.NET Core Web API

## Overview

This week focuses on developing RESTful Web APIs using ASP.NET Core. The labs cover API creation, Swagger documentation, CRUD operations, JWT Authentication, and Kafka Integration.

---

## Technologies Used

- ASP.NET Core Web API (.NET 10)
- C#
- Swagger / OpenAPI
- Entity Framework Core
- SQL Server
- JWT Authentication
- Docker Desktop
- Apache Kafka
- Apache ZooKeeper
- Postman
- Visual Studio Code

---

## Folder Structure

```
Week5_WebAPI/
│
├── Lab1_FirstWebAPI
├── Lab2_SwaggerAndPostman
├── Lab3_EmployeeAPI
├── Lab4_CRUDOperations
├── Lab5_JWTAuthentication
└── Lab6_KafkaIntegration
```

---

# Lab 1 - First Web API

### Objective

Create a simple ASP.NET Core Web API project.

### Topics Covered

- Creating a Web API project
- API Controllers
- HTTP GET endpoint
- Running API using Kestrel

### Outcome

Successfully created and executed the first ASP.NET Core Web API.

---

# Lab 2 - Swagger and Postman

### Objective

Learn API documentation and testing.

### Topics Covered

- Swagger UI
- OpenAPI Documentation
- Testing APIs using Postman
- HTTP Methods

### Outcome

Successfully tested API endpoints using Swagger and Postman.

---

# Lab 3 - Employee API

### Objective

Build an Employee Management API.

### Topics Covered

- Controllers
- Routing
- Models
- JSON Responses

### Endpoints

- GET Employees
- GET Employee by ID
- POST Employee
- PUT Employee
- DELETE Employee

### Outcome

Successfully developed Employee REST API.

---

# Lab 4 - CRUD Operations

### Objective

Implement CRUD operations using Entity Framework Core.

### Topics Covered

- Entity Framework Core
- SQL Server
- Database Context
- Repository Pattern
- CRUD Operations

### Operations

- Create
- Read
- Update
- Delete

### Outcome

Successfully connected Web API with SQL Server and performed CRUD operations.

---

# Lab 5 - JWT Authentication

### Objective

Secure APIs using JSON Web Tokens.

### Topics Covered

- JWT Authentication
- Authorization
- Token Generation
- Protected Endpoints
- Bearer Token Authentication

### Endpoints

#### POST

```
/api/Auth/login
```

Generates JWT Token.

#### GET

```
/api/Test
```

Protected endpoint requiring Bearer Token.

### Outcome

Successfully authenticated users using JWT and protected API endpoints.

---

# Lab 6 - Kafka Integration

### Objective

Integrate Apache Kafka with ASP.NET Core Web API.

### Topics Covered

- Docker Compose
- Kafka
- ZooKeeper
- Kafka Producer
- Kafka Consumer
- Confluent.Kafka Package

### API

#### POST

```
/api/Message
```

Example Request

```json
{
  "message": "Hello Kafka"
}
```

Example Response

```
Message sent successfully
```

### Consumer Output

```
Hello Kafka
```

### Outcome

Successfully implemented Kafka Producer and Consumer using Docker and ASP.NET Core.

---

# Learning Outcomes

After completing Week 5, the following concepts were learned:

- ASP.NET Core Web API Development
- REST API Design
- HTTP Methods
- Routing
- Controllers
- Swagger Documentation
- Postman Testing
- Entity Framework Core
- SQL Server Integration
- CRUD Operations
- JWT Authentication
- Authorization
- Docker Basics
- Apache Kafka
- Kafka Producer and Consumer

---

# Tools Used

- Visual Studio Code
- .NET SDK
- SQL Server
- SQL Server Management Studio
- Docker Desktop
- Apache Kafka
- Postman
- Git
- GitHub

---

# Status

- ✅ Lab 1 Completed
- ✅ Lab 2 Completed
- ✅ Lab 3 Completed
- ✅ Lab 4 Completed
- ✅ Lab 5 Completed
- ✅ Lab 6 Completed

---

## Conclusion

Week 5 provided hands-on experience in building secure and scalable ASP.NET Core Web APIs. The labs covered API development, database integration, authentication using JWT, and asynchronous messaging using Apache Kafka, forming the foundation for Microservices development in the upcoming weeks.